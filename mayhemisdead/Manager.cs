using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayhemisdead
{
    class Manager : Employee
    {
        private List<Employee> employed = new List<Employee>();
        Manager podchineni = new Manager();

        public Manager()
        {

        }

        public Manager(string ID, string name, string fullName, string type, float successRate)
        {
            this.ID = ID;
            this.name = name;
            this.fullName = fullName;
            this.type = type;
            this.successRate = successRate;
        }

        public void PrintStatus()
        {
            for (int i = 0; i < podchineni.Count; i++)
            {
                Console.WriteLine(
                    "Ime" + podchineni.fullName +
                    "Broi" + podchineni.Count +
                    "Uspevaemost" + podchineni.successRate);
            }
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
        
        public override void SuccessRate()
        {
            podchineni.successRate += 1;
        }

        public void AddEmployee(Employee employee)
        {
            employed.Add(employee);
        }

        public void RemoveEmployee(string names)
        {
            employed.RemoveAt(employed.Count);
        }
    }
}
