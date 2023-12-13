using AutoMapper;
using Organizer.Model.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Model.UI.Mapper
{
    public class Mapping : Profile{
       public Mapping() {
            CreateMap<DataModel, DataViewModel>();
            CreateMap<DataViewModel, DataModel>();
           

            CreateMap<Gun, GunViewModel>();
            CreateMap<GunViewModel, Gun>();
            

            CreateMap<GunSeller, GunSellerViewModel>();
            CreateMap<GunSellerViewModel, GunSeller > ();
            

            CreateMap<WeaponShop, WeaponShopViewModel>();
            CreateMap<WeaponShopViewModel, WeaponShop>();
            
        }
    }
}
