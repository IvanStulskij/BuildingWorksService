using BuildingWorks.Common.Extensions;
using BuildingWorks.Models;
using BuildingWorks.Models.Bases;
using GalaSoft.MvvmLight.Command;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace BuildingWorks.ViewModels.Operations
{
    public class RemoveViewModel<T, TResource>
        where T : class, IPersistable<int>
        where TResource : IResource 
    {
        private readonly DataViewModel<T> _dataViewModel;
        private readonly DbSet<T> _databaseData;
        private readonly ServiceReceiver<T, TResource> _baseTable;

        public RemoveViewModel(DataViewModel<T> dataViewModel, DbSet<T> databaseData, ServiceReceiver<T, TResource> baseTable)
        {
            _dataViewModel = dataViewModel;
            _databaseData = databaseData;
            _baseTable = baseTable;
        }

        public RelayCommand RemoveCommand
        {
            get
            {
                return new RelayCommand
                (
                    () =>
                    {
                        if (_dataViewModel.SelectedValue != null)
                        {
                            _baseTable.Delete(_dataViewModel.SelectedValue.Id);
                            _dataViewModel.DataToSelect = new ObservableCollection<T>(_databaseData);
                        }
                    }
                );
            }
        }
    }
}
