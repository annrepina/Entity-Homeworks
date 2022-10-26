using EFCoreHomework1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreHomework1.Builders
{
    /// <summary>
    /// Строитель заказов - Создает заказы
    /// </summary>
    public class OrderBuilder : Builder<Order>
    {
        /// <summary>
        /// Константа - минимальная сумма заказа для создания заказа
        /// </summary>
        public const int MinSumm = 5000;

        /// <summary>
        /// Константа - максимальная сумма заказа для создания заказа
        /// </summary>
        public const int MaxSumm = 99999;

        private static int _id = 0;
        
        /// <summary>
        /// Экземпляр рандома
        /// </summary>
        private Random _random;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public OrderBuilder()
        {
            _random = new Random();
        }

        /// <summary>
        /// Создать заказ
        /// </summary>
        public void BuildOrder()
        {
            //SetUserIdRandomly();
            SetSummRandomly();
            _element.Id = ++_id;
            //SetDateTimeRandomly();
        }

        /// <summary>
        /// Задать сумму заказа рандомно
        /// </summary>
        private void SetSummRandomly()
        {
            int summ = _random.Next(MinSumm, MaxSumm);

            _element.Sum = summ;
        }

        ///// <summary>
        ///// Задать дату рандомно
        ///// </summary>
        //private void SetDateTimeRandomly()
        //{
        //    DateTime start = new DateTime(2010, 1, 1);

        //    int range = (DateTime.Now - start).Days;

        //    DateTime res = start.AddDays(_random.Next(range));

        //    _element.DateTime = res;
        //}
    }
}
