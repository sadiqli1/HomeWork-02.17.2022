using System;

namespace HomeWork_02._17._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.Name = "Isa";
            student.Surname = "Sadiqli";
            student.Group = "P127";
            student.Point = 85;
            student.Graduated = false;

            Console.WriteLine(student.GetFullname());

            Console.WriteLine(student.Getinfo());

            Console.WriteLine(student.Getgraduated());

            Console.WriteLine(student.Getpoint());


        }
    }

    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool Graduated;

        public string GetFullname()
        {
            return Name + " " + Surname;
        }

        public string Getinfo()
        {
            return $"Name:{Name}\nSurname:{Surname}\nGroup:{Group}\nPoint:{Point}\nGraduated:{Graduated}";

            
        }

        public bool Getgraduated()
        {
            if (Graduated == true)
            {
                Console.WriteLine("Bu telebe mezun olub");
            }
            else
            {
                Console.WriteLine("Bu telebe mezun olmayib");
            }
            return Graduated;
        }

        public byte Getpoint()
        {
            if (Point>=80)
            {
                Console.WriteLine("Siz ikinci imtahana gire bilersiz");
            }
            else
            {
                Console.WriteLine("siz ikinci imtahana gire bilmezsiz");
            }
            return Point;
        }
    }
}
