using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreHomework2.Entities
{
    /// <summary>
    /// Класс - студент
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Id 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string? PhoneNumber { get; set; }

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