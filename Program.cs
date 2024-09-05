using System;
using System.Globalization;
using System.Collections.Generic;


namespace list_employees {
    class Program {
        static void Main(string[] args) {


            List<Employe> employees = new List<Employe>();


            Console.Write("How many employees will be registrered? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                Console.WriteLine($"Employees #{i + 1}:");
                Console.Write("Id: ");
                int Id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Console.Write("Salary: ");
                double Salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                employees.Add(new Employe(Id, Name, Salary));
            }

            Console.Write("Enter the employe id that will have salary increase : ");
            int increaseId = int.Parse(Console.ReadLine());

            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine());

            Employe emp = employees.Find(e => e.Id == increaseId);
            if(emp != null) {
                emp.Increase(percentage);
            }
            else {
                Console.WriteLine("Employee with the give ID not found.");
            }

            Console.WriteLine("\n Updated employee details: ");
            foreach(Employe e in employees) {
                Console.WriteLine(e);
            }
        }
    }
}

