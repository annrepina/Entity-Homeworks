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

        /// <summary>
        /// Id элемента
        /// </summary>
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
            SetSummRandomly();
            _element.Id = ++_id;
        }

        /// <summary>
        /// Задать сумму заказа рандомно
        /// </summary>
        private void SetSummRandomly()
        {
            int summ = _random.Next(MinSumm, MaxSumm);

            _element.Sum = summ;
        }
    }
}
