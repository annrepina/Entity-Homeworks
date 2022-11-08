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
    public class Order
    {
        public int Id { get; set; }

        public int Sum { get; set; }

        ////[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //[DefaultValue(typeof(DateTime), "08/11/2022")]
        //public DateTime DateTime { get; set; }
    }
}
