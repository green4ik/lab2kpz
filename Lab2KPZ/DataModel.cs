using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Model {
    [Serializable]
    public class DataModel {
        public IEnumerable<WeaponShop> weaponShops { get; set; }
        public IEnumerable<Gun> guns { get; set; }
        public IEnumerable<GunSeller> gunSellers { get; set; }

        public static string dataPath = "G:\\orgaizer.dat";

        public DataModel() {
         
        }
        public static DataModel LoadFile() {
            if(File.Exists(dataPath)) {
                return DataSerializer.DeserializeData(dataPath);
            }
            return new DataModel();
        }
        public void SaveFile() {
            DataSerializer.SerializeData(dataPath, this);
        }
    }
}
