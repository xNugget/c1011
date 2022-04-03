﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Lebron";
            student.Surname = "Jeyms";
            student.StudentNo = 556;
            student.ClassNo = 2;
            student.GetInfo();

            student.IncreaseTheClass();
            student.GetInfo();

            Student student2 = new Student("Adriana", "soyisim", 666, 3);
            student2.GetInfo();
            student2.DecreaseTheClass();
            student2.DecreaseTheClass();
            student2.GetInfo();

            Console.ReadLine();
        }
    }

    class Student
    {
        private string name;
        private string surname;
        private int studentNo;
        private int classNo;

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname { get => surname; set => surname = value; }
        public int StudentNo { get => studentNo; set => studentNo = value; }
        public int ClassNo 
        {
            get => classNo;
            set
            {
                if (value<1)
                {
                    Console.WriteLine("The class can be at least 1.");
                    classNo = 1;
                }
                else
                {
                    classNo = value;
                }
                
            } 
        }

        public Student(string name, string surname, int studentNo, int classNo)
        {
            Name = name;
            Surname = surname;
            StudentNo = studentNo;
            ClassNo = classNo;
        }
        public Student()
        {

        }

        public void GetInfo()
        {
            Console.WriteLine("* * * * * Student Information * * * * *");
            Console.WriteLine("Student name : {0}",this.Name);
            Console.WriteLine("Student surname : {0}", this.Surname);
            Console.WriteLine("Student no : {0}", this.StudentNo);
            Console.WriteLine("Student class no : {0}", this.ClassNo);
        }

        public void IncreaseTheClass()
        {
            this.ClassNo++;
        }

        public void DecreaseTheClass()
        {

            this.ClassNo--;
        }
    
    }
}