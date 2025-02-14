
using System.Xml.Linq;

namespace Hidepass.CustomControl.Block
{
    public partial class StripInfoBlock : UserControl
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime TimeCreate { get; set; }
        public DateTime TimeUpdate { get; set; }

        public StripInfoBlock(string name, string description, DateTime timeCreate, DateTime timeUpdate)
        {
            InitializeComponent();
            Name = name;
            Description = description;
            TimeCreate = timeCreate;
            TimeUpdate = timeUpdate;
        }
    }
}
