﻿using EFCoreHomework2.Entities;
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
            using (GroupDbContext db = new GroupDbContext())
            {
                StudentCard studentCard = new StudentCard() { SerialNumber = 153 };
                StudentCard studentCard1 = new StudentCard() { SerialNumber = 163 };
                StudentCard studentCard2 = new StudentCard() { SerialNumber = 173 };

                db.StudentCards.AddRange(studentCard, studentCard1, studentCard2);

                Student ann = new Student() { FirstName = "Анна", LastName = "Репина", Birthday = new DateTime(1995, 12, 12), PhoneNumber = "9588887411", StudentCard = studentCard2 };
                Student gevork = new Student() { FirstName = "Геворк", LastName = "Софоян", Birthday = new DateTime(1991, 10, 22), PhoneNumber = "9525788498", StudentCard = studentCard1 };
                Student igor = new Student() { FirstName = "Игорь", LastName = "Доронов", Birthday = new DateTime(1997, 05, 02), PhoneNumber = "954466411", StudentCard = studentCard };

                db.Students.AddRange(ann, gevork, igor);

                db.SaveChanges();

                var students = db.Students.Include(c => c.StudentCard).ToList();
            }

            InitializeComponent();
        }
    }
}
