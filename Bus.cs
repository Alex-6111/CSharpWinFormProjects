using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWinFormProjects
{
    [Serializable]
    public class Bus
    {
        public string Number { get; set; }
        public string Type { get; set; }
        public string Destination { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrivale { get; set; }
    }
}
