using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreHomework2.Entities
{
    /// <summary>
    /// Класс - оценка
    /// </summary>
    public class Mark
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Значение оценки
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Предмет - навигационное свойство
        /// </summary>
        public Subject Subject { get; set; }

        /// <summary>
        /// Id предмета
        /// </summary>
        public int SubjectId { get; set; }

        /// <summary>
        /// Зачетка - навигационное свойство
        /// </summary>
        public StudentCard StudentCard { get; set; }

        /// <summary>
        /// Id зачетки
        /// </summary>
        public int StudentCardId { get; set; }   
    }
}