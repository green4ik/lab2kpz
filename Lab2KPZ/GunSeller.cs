using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Model {
    [Serializable]
    public class GunSeller {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Salary { get; set; }
    }
}
