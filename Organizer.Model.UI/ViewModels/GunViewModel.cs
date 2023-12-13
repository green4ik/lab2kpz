using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Model.UI.ViewModels
{
    public class GunViewModel : INotifyPropertyChanged {
        private string name;
        private string description;
        private int cost;

        public string Name {
            get { return name; }
            set {
                if (name != value) {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Description {
            get { return description; }
            set {
                if (description != value) {
                    description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }

        public int Cost {
            get { return cost; }
            set {
                if (cost != value) {
                    cost = value;
                    OnPropertyChanged(nameof(Cost));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
