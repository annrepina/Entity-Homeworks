using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreHomework2.Entities
{
    /// <summary>
    /// Класс - зачетка
    /// </summary>
    public class StudentCard
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; } 

        /// <summary>
        /// Серийный номер зачетки
        /// </summary>
        public int SerialNumber { get; set; }

        /// <summary>
        /// Навигационное свойство - студент
        /// </summary>
        public Student Student { get; set; }

        /// <summary>
        /// Список предметов
        /// </summary>
        public List<Subject> Subjects { get; set; }

        /// <summary>
        /// Список оценок
        /// </summary>
        public List<Mark> Marks { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public StudentCard()
        {
            Subjects = new List<Subject>();
            Marks = new List<Mark>();
        }
    }
}