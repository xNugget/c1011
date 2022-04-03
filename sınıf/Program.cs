using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            kole kole1 = new kole();
            kole1.name = "Leblebi";
            kole1.surname = "Turunçgil";
            kole1.id = 199;
            kole1.department = "manav";
            kole1.sorgulama();
            Console.WriteLine("* * * * * * * * * * *");

            kole kole2 = new kole();
            kole2.name = "Fatih";
            kole2.surname = "terim";
            kole2.id = 1905;
            kole2.department = "fussbalspielen";
            kole2.sorgulama();
            Console.WriteLine("* * * * * * * * * * *");

            Console.ReadLine();
        }
        class kole
        {
            public int id;
            public string name;
            public string surname;
            public string department;

            public void sorgulama()
            {
                Console.WriteLine("Employee name : {0}", name);
                Console.WriteLine("Employee surname : {0}", surname);
                Console.WriteLine("Employee id : {0}", id);
                Console.WriteLine("Employee department : {0}", department);

            }
        }
    }
}