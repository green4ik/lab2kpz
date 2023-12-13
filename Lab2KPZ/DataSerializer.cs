using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Model {
    public class DataSerializer {
        public static void SerializeData(string filename, DataModel data) {
            var formatter = new BinaryFormatter();
            var fstream = new FileStream(filename, FileMode.Create);
            formatter.Serialize(fstream, data);
            fstream.Close();
        }
        public static DataModel DeserializeData(string filename) {
            var formatter = new BinaryFormatter();
            var fstream = new FileStream(filename, FileMode.Open);
            return(DataModel)formatter.Deserialize(fstream);
        }
    }
}
