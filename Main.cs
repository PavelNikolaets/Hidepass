
using Hidepass.Forms.Block;
using Hidepass.Forms.Cell;
using Hidepass.Logic;
using Hidepass.Logic.FileOperations;
using Hidepass.Logic.MVC;
using Hidepass.Logic.MVC.Block;
using Hidepass.Logic.MVC.Cell;
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

        private static int SelectedBlockIndex = 0;

        public Main()
        {
            Initialization.ComponentsCheck(GPathToDir, GPathToFileMetadata);
            InitializeComponent();

            GListBlocks = ListBlocks;
            GListCells = ListCells;

            Initialization.InitDisplay(GPathToFileMetadata);
        }

        private void ListBlocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Добавить диалоговое окно с вводом мастер пароля

            CurrentMasterKey = Interaction.InputBox("Введите ключ от этого блока", "Ввод ключа", "");

            if (CurrentMasterKey != string.Empty)
            {
                SelectedBlockIndex = ListBlocks.SelectedIndex;

                if (SelectedBlockIndex >= 0)
                {
                    string path = JsonService.ToObject<RootBlock>(File.ReadAllText(GPathToFileMetadata)).Blocks[SelectedBlockIndex].PathToFile;
                    ViewPassword.DisplayCells(ListCells, path, CurrentMasterKey);
                }

                ViewPassword.DisplayLabelDescription(BlockDescription, SelectedBlockIndex, CurrentMasterKey);
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
                string path = JsonService.ToObject<RootBlock>(File.ReadAllText(GPathToFileMetadata)).Blocks[SelectedBlockIndex].PathToFile;

                ControllerBlock.ControllerDeleteBlock(path, SelectedBlockIndex, CurrentMasterKey);
                ViewPassword.DisplayLabelDescription(BlockDescription, -1, CurrentMasterKey);
            }
        }

        private void ButtonCreateCell_Click(object sender, EventArgs e)
        {
            int index = ListBlocks.SelectedIndex;

            if (index >= 0)
            {
                string path = JsonService.ToObject<RootBlock>(File.ReadAllText(GPathToFileMetadata)).Blocks[index].PathToFile;

                FCreateCell createCell = new(path);
                createCell.Show();
            }
        }

        private void ButtonDeleteCell_Click(object sender, EventArgs e)
        {
            int index = ListBlocks.SelectedIndex;

            if (index >= 0)
            {
                string path = JsonService.ToObject<RootBlock>(File.ReadAllText(GPathToFileMetadata)).Blocks[index].PathToFile;

                ControllerCell.ControlerDeleteCell(path, index, CurrentMasterKey);
            }
        }

        //private void ListCells_DoubleClick(object sender, EventArgs e)
        //{
        //    int index = ListCells.SelectedIndex;

        //    if (index >= 0)
        //    {
        //        string path = JsonService.ToObject<RootBlock>(File.ReadAllText(GPathToFileMetadata)).Blocks[SelectedBlockIndex].PathToFile;
        //        CellObject obj = JsonService.ToObject<RootCell>(File.ReadAllText(path)).Cells[index];

        //        FViewCell fViewCell = new(obj);
        //        fViewCell.Show();
        //    }
        //}

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

                //CellObject obj = JsonService.ToObject<RootCell>(File.ReadAllText(path)).Cells[index];

                FViewCell fViewCell = new(obj);
                fViewCell.Show();
            }
        }

        private void ButtonChangeCell_Click(object sender, EventArgs e)
        {
            int index = ListCells.SelectedIndex;

            if (index >= 0)
            {
                string path = JsonService.ToObject<RootBlock>(File.ReadAllText(GPathToFileMetadata)).Blocks[SelectedBlockIndex].PathToFile;

                string encryptedCellData = File.ReadAllText(path);
                RootCell rootCell = JsonService.ToObject<RootCell>(CryptographyModule.Decrypt(encryptedCellData, CurrentMasterKey));
                CellObject obj = rootCell.Cells[index];

                FChangeCell fChangeCell = new(obj, path, index);
                fChangeCell.Show();

            }
        }
    }
}
