using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWinFormProjects
{
    [Serializable]
    public class Components
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
