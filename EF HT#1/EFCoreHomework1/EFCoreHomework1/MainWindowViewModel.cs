using EFCoreHomework1.Model;
using Microsoft.EntityFrameworkCore;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreHomework1
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Order> Orders { get; private set; }

        public DelegateCommand OnConnectToServerCommand { get; private set; }

        private DatabaseConnecting _databaseConnecting;

        public DatabaseConnecting DatabaseConnecting 
        { 
            get => _databaseConnecting; 

            set
            {
                _databaseConnecting = value;

                OnPropertyChanged(nameof(DatabaseConnecting));
            }
        }

        public MainWindowViewModel()
        {
            DatabaseConnecting = new DatabaseConnecting();

            OnConnectToServerCommand = new DelegateCommand(OnConnectToServer);

            Orders = new ObservableCollection<Order>();
        }

        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        private void OnConnectToServer()
        {
            _databaseConnecting.FillDb();


        }

    }
}
