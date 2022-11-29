using EFCoreHomework2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EFCoreHomework2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // действия, выполняемые для тестирования связей
            using (GroupDbContext db = new GroupDbContext())
            {
                //StudentCard studentCard = new StudentCard() { SerialNumber = 153 };
                //StudentCard studentCard1 = new StudentCard() { SerialNumber = 163 };
                //StudentCard studentCard2 = new StudentCard() { SerialNumber = 173 };

                //db.StudentCards.AddRange(studentCard, studentCard1, studentCard2);

                //Student ann = new Student() { FirstName = "Анна", LastName = "Репина", Birthday = new DateTime(1995, 12, 12), PhoneNumber = "9588887411", StudentCard = studentCard2 };
                //Student gevork = new Student() { FirstName = "Геворк", LastName = "Софоян", Birthday = new DateTime(1991, 10, 22), PhoneNumber = "9525788498", StudentCard = studentCard1 };
                //Student igor = new Student() { FirstName = "Игорь", LastName = "Доронов", Birthday = new DateTime(1997, 05, 02), PhoneNumber = "954466411", StudentCard = studentCard };

                //db.Students.AddRange(ann, gevork, igor);

                //db.SaveChanges();

                //Subject java = new Subject() { Name = "Java" };
                //Subject database = new Subject() { Name = "Database" };
                //Subject python = new Subject() { Name = "Python"};

                //var students = db.Students.Include(c => c.StudentCard).ToList();

                //foreach (var student in students)
                //{
                //    if(student.FirstName == "Анна")
                //    {
                //        student.StudentCard.Subjects.Add(java);
                //        student.StudentCard.Subjects.Add(database);
                //    }

                //    else if(student.FirstName == "Геворк")
                //    {
                //        student.StudentCard.Subjects.Add(database);
                //        student.StudentCard.Subjects.Add(python);
                //    }

                //    else
                //    {
                //        student.StudentCard.Subjects.Add(python);
                //        student.StudentCard.Subjects.Add(java);
                //    }
                //}

                //Mark mark5 = new Mark() { Value = 5 };
                //Mark mark4 = new Mark() { Value = 4 };
                //Mark mark3 = new Mark() { Value = 3 };

                var students = db.Students.Include(c => c.StudentCard).ThenInclude(s => s.Subjects).ToList();

                foreach (var student in students)
                {
                    var subjects = student.StudentCard.Subjects;

                    foreach (var subject in subjects)
                    {
                        Mark mark5 = new Mark() { Value = 5, StudentCard = student.StudentCard, Subject = subject };
                        Mark mark4 = new Mark() { Value = 4, StudentCard = student.StudentCard, Subject = subject };
                        Mark mark3 = new Mark() { Value = 3, StudentCard = student.StudentCard, Subject = subject };

                        db.Marks.AddRange(mark5, mark4, mark3);

                        //subject.Marks.AddRange(new List<Mark> { mark5, mark4, mark3 });
                    }
                }

                db.SaveChanges();
            }

            InitializeComponent();
        }
    }
}