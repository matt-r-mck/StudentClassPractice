using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StudentClassPractice {

     class Student {
        public double GPA;
        public int SAT;
        public int TimesTardy;
        public string Name;
        public int ID;

        private double SecretNumberCalculation(double Bnumber, int SecretNumber) {
            return Bnumber / SecretNumber;
        }//calculates BC number secretly

        public double BC(int SecretNumber) {
            var dblSAT = SAT * 2;
            var b = dblSAT * GPA;
            var bc = SecretNumberCalculation (b, SecretNumber);
            return bc;
        }//calculates BC number publically

        public string GetValues() {
            return $"{ID}|{Name}|{SAT}|{GPA}|{TimesTardy}";
            //shows what exists in instance

            }
        public Student() {//default constructor
            this.ID = 0;
            this.GPA = 2.0;
            this.SAT = 1000;
        }

        public Student(double GPA, int SAT, int TimesTardy, string Name, int ID) {
            this.GPA = GPA;
            this.SAT = SAT;
            this.TimesTardy = TimesTardy;
            this.Name = Name; //when parameter matches variable, must call this._
            this.ID = ID;

        }
    } 
}
