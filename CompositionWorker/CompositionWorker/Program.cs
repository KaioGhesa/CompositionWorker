﻿
using CompositionWorker.Entites.Enums;
using CompositionWorker.Entites;
using System.Globalization;


namespace CompositionWorker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Departament's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter Worker Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior):");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary,dept);

            Console.Write("How many contracts to this worker?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter #"+ i + " contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration (hours):");
                int hours = int.Parse(Console.ReadLine());


                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.addContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.name);
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine("Income for: " + monthAndYear + ": " + worker.Income(year,month).ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}
