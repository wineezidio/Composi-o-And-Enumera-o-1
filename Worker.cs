using Mid.Entities;
using System.Collections.Generic;

namespace Mid.Entities

{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker () { }

        public Worker (string name, WorkLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;

        }

        public void AddContract (HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract (HourContract contract) 
        { 
            Contracts.Remove(contract); 
        }

        public double Income (int yaer, int mont)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == yaer && contract.Date.Month == mont)
                {
                    sum += contract.TotalVelue();

                }
            }
            return sum;
        }
    }
}
