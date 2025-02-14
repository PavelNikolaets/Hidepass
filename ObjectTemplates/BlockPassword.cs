using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hidepass.ObjectTemplates
{
    internal class BlockPassword(int id, string name, string description)
    {
        public int Id { get; } = id;
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public List<CellPassword> CellsPasswors { get; set; } = [];
    }
}
