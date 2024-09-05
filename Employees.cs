using System;
using System.Globalization;


namespace list_employees {
    internal class Employe {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


        public Employe(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void Increase(double percentage) {

            Salary += Salary * percentage / 100.0;

        }



        public override string ToString () {
            return $"ID: {Id}, Name: {Name}, Salary: {Salary:F2}";
             
        }
    }
}
