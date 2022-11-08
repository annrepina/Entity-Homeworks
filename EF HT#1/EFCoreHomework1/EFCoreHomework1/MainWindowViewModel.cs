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

        public DelegateCommand OnAddOrdersCommand { get; private set; }

        public DelegateCommand OnRemoveOrdersCommand { get; private set; }

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
            OnAddOrdersCommand = new DelegateCommand(OnAddOrders);

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

        private void OnAddOrders()
        {
            using (EFCoreDbContext db = new EFCoreDbContext())
            {
                Order order1 = new Order { Sum = 200 };
                Order order2 = new Order { Sum = 300 };

                // Добавление
                db.Orders.Add(order1);
                db.Orders.Add(order2);
                db.SaveChanges();
            }


        }

    }
}
