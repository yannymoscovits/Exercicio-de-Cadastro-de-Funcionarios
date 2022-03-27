using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Entities;

namespace Empresa.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level  { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }

        public Worker(string name, WorkerLevel level, double basesalary)
        {
            this.Name = name;
            this.Level = level;
            this.BaseSalary = basesalary;
        }

        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();
     
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
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.totalValue();
                }
            }

            return sum;

        }
    }


}
