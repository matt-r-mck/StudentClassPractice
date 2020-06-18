using System;
using System.Linq.Expressions;
using StudentClassPractice;

namespace StudentClassPractice {
    class Program {
        static void Main(string[] args) {

            var jada = new Student(); //
            jada.Name = "Jada";
            jada.ID = 1;
            jada.GPA = 3.5;
            jada.SAT = 1600;
            jada.TimesTardy = 1112;
            Console.WriteLine($"Jada's name is {jada.Name}");

            var steve = new Student();
            steve.Name = "Steve";
            steve.ID = 2;
            steve.GPA = 4.0;
            steve.SAT = 1599;
            steve.TimesTardy = 0;
            var SteveString = steve.GetValues();
            Console.WriteLine($"Steve: {SteveString}");
            //Calls the BC method for steve's instance
            Console.WriteLine($"Steve's BC score is {steve.BC(2)}");

            var dave = new Student(3.3, 1150, 5, "Dave", 3);
            var DaveString = dave.GetValues();
            Console.WriteLine($"{DaveString}");
        }
    }
}   