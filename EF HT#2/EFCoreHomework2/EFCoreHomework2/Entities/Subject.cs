using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreHomework2.Entities
{
    /// <summary>
    /// Класс - предмет
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Список зачеток
        /// </summary>
        public List<StudentCard> StudentCards { get; set; }

        /// <summary>
        /// Список оценок
        /// </summary>
        public List<Mark> Marks { get; set;}
             
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Subject()
        {
            StudentCards = new List<StudentCard> ();
            Marks = new List<Mark> (); 
        }
    }
}