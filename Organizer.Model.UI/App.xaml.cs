using AutoMapper;
using Organizer.Model.UI.Mapper;
using Organizer.Model.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Organizer.Model.UI {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        private DataModel dataModel;
        private DataViewModel dataViewModel;
        private IMapper mapper;
        public App() {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<Mapping>());
            mapper = config.CreateMapper();
            dataModel = DataModel.LoadFile();
            dataViewModel = mapper.Map<DataModel, DataViewModel>(dataModel);
            var window = new MainWindow(){DataContext = dataViewModel };
            window.Show();
        }
        protected override void OnExit(ExitEventArgs e) {
            try {
                dataModel = mapper.Map<DataViewModel,DataModel>(dataViewModel);
                dataModel.SaveFile();
            } catch (Exception) {
                base.OnExit(e);
                throw;
            }
        }
    }
}
