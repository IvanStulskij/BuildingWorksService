using System;
using GalaSoft.MvvmLight.Command;
using BuildingWorks.Models.Databasable.Contexts;
using BuildingWorks.Models.Databasable.Tables.Provides;
using BuildingWorks.Models.Bases;
using BuildingWorks.ViewModels.Materials;
using BuildingWorks.ViewModels.Operations;
using BuildingWorks.UI.Desktop.Models.ServiceReceivers;
using BuildingWorks.Models.Resources.Providers;

namespace BuildingWorks.ViewModels
{
    public class ProvidersViewModel : ViewModel
    {
        public MaterialsCostViewModel MaterialsCostViewModel { get; private set; } = new MaterialsCostViewModel();
        public ProviderStatesViewModel ProviderStatesViewModel { get; private set; } = new ProviderStatesViewModel();
        public DataViewModel<Provider> DataViewModel { get; private set; }
        public RemoveViewModel<Provider> RemoveViewModel { get; set; }

        private readonly ProviderContext _context = new ProviderContext();
        private readonly ProviderReceiver _providerReceiver;

        public ProvidersViewModel()
        {
            _providerReceiver = new ProviderReceiver();
            DataViewModel = new DataViewModel<Provider>(_context.Providers);
            RemoveViewModel = new RemoveViewModel<Provider>(DataViewModel, _context.Providers, _providerReceiver);
        }

        public RelayCommand<Tuple<string, string, string>> AddProvider
        {
            get
            {
                return new RelayCommand<Tuple<string, string, string>>
                (
                    providerData =>
                    {
                        var resource = new ProviderResource();
                        resource.Name = providerData.Item1;
                        resource.AdditionalData = providerData.Item2;
                        resource.Country = providerData.Item3;
                        _providerReceiver.Create(resource);
                    }
                );
            }
        }

        public RelayCommand<Tuple<int, Tuple<string, string, string>>> UpdateCommand
        {
            get
            {
                return new RelayCommand<Tuple<int, Tuple<string, string, string>>>
                (
                    newData =>
                    {
                        var resource = new ProviderResource();
                        resource.Id = newData.Item1;
                        resource.Name = newData.Item2.Item1;
                        resource.AdditionalData = newData.Item2.Item2;
                        resource.Country = newData.Item2.Item3;
                        _providerReceiver.Update(resource);
                    }
                );
            }
        }
    }
}
