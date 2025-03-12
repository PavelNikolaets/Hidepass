
namespace Hidepass.ObjectTemplates
{
    public class RootCell
    {
        public List<CellObject> Cells { get; set; } = [];
    }

    public class CellObject(string Name, string Description, string Login, string Password)
    {
        public string Name { get; set; } = Name;
        public string Description { get; set; } = Description;
        public string Login { get; set; } = Login;
        public string Password { get; set; } = Password;
        public string DateCreate { get; } = DateTime.Now.ToString("g");
        public string DateUpdate { get; set; } = "";
    }
}
