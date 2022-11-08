using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreHomework1.Model
{
    /// <summary>
    /// Класс - заказ
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Id заказа
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Сумма
        /// </summary>
        public int Sum { get; set; }


        /// <summary>
        /// Дата заказа
        /// </summary>
        ////[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //[DefaultValue(typeof(DateTime), "08/11/2022")]
        //public DateTime DateTime { get; set; }
    }
}
