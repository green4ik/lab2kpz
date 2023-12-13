using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Model.UI.ViewModels
{
    public class WeaponShopViewModel : INotifyPropertyChanged {
        private string name;
        private string description;
        private GunSellerViewModel gunSellers;
        private ObservableCollection<GunViewModel> guns;

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

       /* public GunSellerViewModel GunSellers {
            get { return gunSellers; }
            set {
                if (gunSellers != value) {
                    gunSellers = value;
                    OnPropertyChanged(nameof(GunSellerViewModel));
                }
            }
        }*/
        public ObservableCollection<GunViewModel> Guns {
            get { return guns; }
            set {
                if (value != guns) {
                    guns = value;
                    OnPropertyChanged(nameof(Guns));
                }

            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
