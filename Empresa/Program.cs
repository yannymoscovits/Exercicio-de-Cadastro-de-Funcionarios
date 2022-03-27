using System;
using Empresa.Entities;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter depart´s name: ");
            string depart = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevel/Senior: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base Salary: ");
            double basesalary = double.Parse(Console.ReadLine());

            Department department = new Department(depart);
            Worker worker = new Worker(name, level, basesalary);


            Console.WriteLine("How Many contracts to this worker? ");
            int answer = int.Parse(Console.ReadLine());

            for(int i = 0; i < answer; i++)
            {
                Console.WriteLine("Enter #" + i + " contract data: ");
                Console.Write("Date: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value Per Hour: ");
                double valueperhour = Double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valueperhour, hours);
                worker.addContract(contract);
            }

            Console.WriteLine("Enter month and year to calculate income (mm/yyyy)");
            string monthAndyear = Console.ReadLine();
            int month = int.Parse(monthAndyear.Substring(0,2));
            int year = int.Parse(monthAndyear.Substring(3));
            Console.WriteLine("Name : " + worker.Name);
            Console.WriteLine("Department : " + department.Name) ;
            Console.WriteLine("Income for " + monthAndyear + " :" + worker.Income(year,month).ToString("F2"));
        }
    }
}
