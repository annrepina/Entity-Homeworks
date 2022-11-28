using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreHomework2.Entities
{
    public class StudentCard
    {
        public int Id { get; set; } 

        public int SerialNumber { get; set; }

        public Student Student { get; set; }

    }
}
