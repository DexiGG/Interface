﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Students student = new Students();
            student.Stud("Марк", 480000, 4, 93);
            Console.WriteLine("Имя студента: " + student.GetName);
            Console.WriteLine("Плата за обучение: " + student.GetPaymentStudy);
            Console.WriteLine("Срок обучения: " + student.GetYearStudy);
            Console.WriteLine("Рейтинг студента: " + student.GetRating);
            Console.ReadLine();
        }
    }
}