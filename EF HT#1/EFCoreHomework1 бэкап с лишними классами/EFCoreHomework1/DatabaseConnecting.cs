using EFCoreHomework1.Builders;
using EFCoreHomework1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EFCoreHomework1
{
    public class DatabaseConnecting : INotifyPropertyChanged 
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        private const int RandomNumberOfOrders = 10;

        private string _connectionString;
        private string _serverName;
        private bool _isNotConnected;
        private bool _canConnect;
        private bool _hasCorrectServerName;

        //public string ConnectionString
        //{
        //    get => _connectionString;

        //    set
        //    {
        //        _connectionString = value;
        //    }
        //}

        public bool HasCorrectServerName 
        { 
            get => _hasCorrectServerName;

            set
            {
                _hasCorrectServerName = value;

                CanConnect = _isNotConnected && HasCorrectServerName;
            }
        }

        public string ServerName 
        { 
            get => _serverName; 

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _serverName = value;

                    _connectionString = $"Server={_serverName};Database=EFCoreHomework1Repina;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=True;";

                    HasCorrectServerName = true;
                }
            }            
        }

        public bool IsNotConnected
        {
            get => _isNotConnected;

            set
            {
                _isNotConnected = value;

                CanConnect = _isNotConnected && HasCorrectServerName;

                OnPropertyChanged(nameof(IsNotConnected));
            }
        }

        public bool CanConnect
        {
            get => _canConnect;

            set 
            {
                _canConnect = value;

                OnPropertyChanged(nameof(CanConnect));
            }
        }

        public DatabaseConnecting()
        {
            _connectionString = "";
            _serverName = "";
            IsNotConnected = true;
            HasCorrectServerName = false;
            CanConnect = false;
        }

        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public void FillDb()
        {
            using (EFCoreDbContext context = new EFCoreDbContext())
            {
                OrderBuilder builder = new OrderBuilder();

                for (int i = 0; i < RandomNumberOfOrders; i++)
                {
                    builder.BuildOrder();

                    Order order = builder.GetResult();

                    context.Orders.Add(order);
                }

                context.SaveChanges();

                IsNotConnected = false;

                CanConnect = false;



                //// создаем два объекта User
                //User tom = new User { Name = "Tom", Age = 33 };
                //User alice = new User { Name = "Alice", Age = 26 };

                //// добавляем их в бд
                //context.Users.Add(tom);
                //context.Users.Add(alice);

            }
        }





    }
}
