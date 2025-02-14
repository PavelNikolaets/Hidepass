
namespace Hidepass.CustomControl.Cell
{
    public partial class StripInfoCell : UserControl
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public StripInfoCell(string name, string description, string logn, string password, DateTime createTime, DateTime updateTime)
        {
            InitializeComponent();
            Name = name;
            Description = description;
            Login = logn;
            Password = password;
            CreateTime = createTime;
            UpdateTime = updateTime;
        }
    }
}
