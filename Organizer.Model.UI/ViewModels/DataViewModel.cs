using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace Organizer.Model.UI.ViewModels
{
    public class DataViewModel : INotifyPropertyChanged {
        private DataModel dataModel;
        private string visibleControl = "WeaponShops";
        public ObservableCollection<WeaponShopViewModel> weaponShops;
        public ObservableCollection<GunViewModel> guns;
        public ObservableCollection<GunSellerViewModel> gunSellers;

        private WeaponShopViewModel selectedWeaponShop;
        public WeaponShopViewModel SelectedWeaponShop {
            get {
                return selectedWeaponShop;
            }
            set {
                selectedWeaponShop = value;
                OnPropertyChanged(nameof(SelectedWeaponShop));
            }
        }
        private GunViewModel selectedGun;
        public GunViewModel SelectedGun {
            get {
                return selectedGun;
            }
            set {
                selectedGun = value;
                OnPropertyChanged(nameof(SelectedGun));
            }
        }
        private GunSellerViewModel selectedGunSeller;
        public GunSellerViewModel SelectedGunSeller {
            get {
                return selectedGunSeller;
            }
            set {
                selectedGunSeller = value;
                OnPropertyChanged(nameof(SelectedGunSeller));
            }
        }
        public ICommand SetControlVisibility {
            get;set;
        }
        public ICommand RemoveItem {
            get;set;
        }
        public void removeItem(object args) {
            if((string)args == "1")
                gunSellers.Remove(SelectedGunSeller);
            if ((string)args == "2")
                guns.Remove(SelectedGun);
            if ((string)args == "3")
                weaponShops.Remove(SelectedWeaponShop);
        }
        public void ControlVisibility(object args) {
            VisibleControl = args.ToString();
        }
        public DataViewModel() {
            SetControlVisibility = new Command(ControlVisibility);
            RemoveItem = new Command(removeItem);
            }
        public string VisibleControl {
            get {
                return visibleControl;
            }
            set {
                    visibleControl = value;
                OnPropertyChanged(nameof(VisibleControl));
            }
        }
        public ObservableCollection<WeaponShopViewModel> WeaponShops {
            get {return weaponShops; }
            set {
                if(value != weaponShops) {
                    weaponShops = value;
                    OnPropertyChanged(nameof(WeaponShops));
                }
                }
        }
        public ObservableCollection<GunViewModel> Guns {
            get { return guns; }
            set {
                if (value != guns) {
                    guns = value;
                    OnPropertyChanged(nameof(Guns));
                }
                    
            }
        }
        public ObservableCollection<GunSellerViewModel> GunSellers {
            get { return gunSellers; }
            set {
                if (value != gunSellers) {
                    gunSellers = value;
                    OnPropertyChanged(nameof(GunSellers));
                }
                    
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
