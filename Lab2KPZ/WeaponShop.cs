using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Model {
    [Serializable]
    public class WeaponShop {
        public string Name { get; set; }
        public string Description { get; set; }
        public GunSeller gunSeller { get; set; }
        public IEnumerable<Gun> guns { get; set; }
    }
}
