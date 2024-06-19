using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using CompositionWorker.Entites.Enums;

namespace CompositionWorker.Entites
{
    internal class Worker
    {

        public string name { get; set; }
        public WorkerLevel level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            this.name = name;
            this.level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.date.Year == year && contract.date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }

    }
}
