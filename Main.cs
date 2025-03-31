
using Hidepass.Forms.Block;
using Hidepass.Forms.Cell;
using Hidepass.Logic;
using Hidepass.Logic.FileOperations;
using Hidepass.Logic.MVC;
using Hidepass.Logic.MVC.Block;
using Hidepass.Logic.MVC.Cell;
using Hidepass.Logic.MVC.ImportExport;
using Hidepass.Logic.OperationCryptography;
using Hidepass.ObjectTemplates;
using Microsoft.VisualBasic;
using File = System.IO.File;

namespace Hidepass
{
    public partial class Main : Form
    {
        public static readonly string GPathToDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Hidepass";
        public static readonly string GPathToFileMetadata = GPathToDir + @"\blockmetadata.json";

        public static ListBox GListBlocks;
        public static ListBox GListCells;

        public static string CurrentMasterKey = string.Empty;

        private static int SelectedBlockIndex = -1;

        public Main()
        {
            Initialization.ComponentsCheck(GPathToDir, GPathToFileMetadata);
            InitializeComponent();

            GListBlocks = ListBlocks;
            GListCells = ListCells;

            Initialization.InitDisplay(GPathToFileMetadata);
        }

        private void ListBlocks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = ListBlocks.IndexFromPoint(e.Location);

            if (index >= 0)
            {
                CurrentMasterKey = Interaction.InputBox("Введите ключ от этого блока", "Ввод ключа", "");
                SelectedBlockIndex = index;

                if (CurrentMasterKey != string.Empty)
                {
                    string metadatablock = File.ReadAllText(GPathToFileMetadata);
                    string path = JsonService.ToObject<RootBlock>(metadatablock).Blocks[SelectedBlockIndex].PathToFile;
                    ViewPassword.DisplayCells(ListCells, path, CurrentMasterKey);
                }

                ViewPassword.DisplayLabelDescription(BlockDescription, SelectedBlockIndex);
            }
        }

        private void ButtonCreateBlock_Click(object sender, EventArgs e)
        {
            FCreateBlock fCreateBlock = new();
            fCreateBlock.Show();
        }

        private void ButtonChangeBlock_Click(object sender, EventArgs e)
        {
            if (SelectedBlockIndex >= 0)
            {
                BlockObject obj = JsonService.ToObject<RootBlock>(File.ReadAllText(GPathToFileMetadata)).Blocks[SelectedBlockIndex];

                FChangeBlock fChangeBlock = new(obj, SelectedBlockIndex);
                fChangeBlock.Show();
            }
        }

        private void ButtonDeleteBlock_Click(object sender, EventArgs e)
        {
            if (SelectedBlockIndex >= 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить блок?", "Удалить?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string path = JsonService.ToObject<RootBlock>(File.ReadAllText(GPathToFileMetadata)).Blocks[SelectedBlockIndex].PathToFile;

                    ControllerBlock.ControllerDeleteBlock(path, SelectedBlockIndex, CurrentMasterKey);
                    BlockDescription.Text = "Описание: ";
                }
            }
        }

        private void ButtonCreateCell_Click(object sender, EventArgs e)
        {
            int index = ListBlocks.SelectedIndex;

            if (index >= 0 && CurrentMasterKey != "")
            {
                string path = JsonService.ToObject<RootBlock>(File.ReadAllText(GPathToFileMetadata)).Blocks[index].PathToFile;

                FCreateCell createCell = new(path);
                createCell.Show();
            }
        }

        private void ButtonDeleteCell_Click(object sender, EventArgs e)
        {
            int index = ListCells.SelectedIndex;

            if (index >= 0 && CurrentMasterKey != "")
            {
                if (MessageBox.Show("Вы действительно хотите удалить ячейку?", "Удалить?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string path = JsonService.ToObject<RootBlock>(File.ReadAllText(GPathToFileMetadata)).Blocks[SelectedBlockIndex].PathToFile;

                    ControllerCell.ControlerDeleteCell(path, index, CurrentMasterKey);
                }
            }
        }

        private void ListCells_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = ListCells.IndexFromPoint(e.Location);

            if (index >= 0)
            {
                ListCells.SelectedIndex = index;

                string path = JsonService.ToObject<RootBlock>(File.ReadAllText(GPathToFileMetadata)).Blocks[SelectedBlockIndex].PathToFile;

                string encryptedCellData = File.ReadAllText(path);
                RootCell cellData = JsonService.ToObject<RootCell>(CryptographyModule.Decrypt(encryptedCellData, CurrentMasterKey));

                CellObject obj = cellData.Cells[index];

                FViewCell fViewCell = new(obj);
                fViewCell.Show();
            }
        }

        private void ButtonChangeCell_Click(object sender, EventArgs e)
        {
            int index = ListCells.SelectedIndex;

            if (index >= 0 && CurrentMasterKey != "")
            {
                string path = JsonService.ToObject<RootBlock>(File.ReadAllText(GPathToFileMetadata)).Blocks[SelectedBlockIndex].PathToFile;

                string encryptedCellData = File.ReadAllText(path);
                try
                {
                    RootCell rootCell = JsonService.ToObject<RootCell>(CryptographyModule.Decrypt(encryptedCellData, CurrentMasterKey));
                    CellObject obj = rootCell.Cells[index];

                    FChangeCell fChangeCell = new(obj, path, index);
                    fChangeCell.Show();
                }
                catch
                {
                    return;
                }

            }
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new()
            {
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentMasterKey = Interaction.InputBox("Введите ключ от этого блока", "Ввод ключа", "");
                ControllerExportImport.ControllerImport(openFileDialog.FileName, CurrentMasterKey);
                ListCells.Items.Clear();

            }
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedBlockIndex >= 0 && CurrentMasterKey != string.Empty)
            {
                string jsonBlock = File.ReadAllText(GPathToFileMetadata);
                BlockObject blockObj = JsonService.ToObject<RootBlock>(jsonBlock).Blocks[SelectedBlockIndex];

                string rootCellObjDecrypt = CryptographyModule.Decrypt(File.ReadAllText(blockObj.PathToFile), CurrentMasterKey);
                RootCell rootCellObj = JsonService.ToObject<RootCell>(rootCellObjDecrypt);

                using SaveFileDialog saveFileDialog = new()
                {
                    FileName = blockObj.Name,
                    Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*",
                    DefaultExt = "*.txt",
                    AddExtension = true,
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string name = saveFileDialog.FileName;

                    ControllerExportImport.ControllerExport(name, blockObj, rootCellObj, CurrentMasterKey);
                }
            }
            else if (CurrentMasterKey == string.Empty)
            {
                MessageBox.Show("Перед тем как экспортировать блок вам нужно ввести от него ключ выбрав его из списка блоков!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListBlocks_MouseClick(object sender, MouseEventArgs e)
        {
            SelectedBlockIndex = ListBlocks.IndexFromPoint(e.Location);
            ViewPassword.DisplayLabelDescription(BlockDescription, SelectedBlockIndex);
            CurrentMasterKey = string.Empty;
            ListCells.Items.Clear();
        }

        private void ToolStripBtnAbout_Click(object sender, EventArgs e)
        {
            string textAbout = File.ReadAllText(@"about.txt");
            MessageBox.Show(textAbout, "О проекте");
        }
    }
}
