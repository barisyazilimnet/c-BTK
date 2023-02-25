using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee { Name = "Barış KURT" };
            Employee employee2 = new Employee { Name = "Güldane AKSU KURT" };
            Employee employee3 = new Employee { Name = "Bilge AKSU" };
            Employee employee4 = new Employee { Name = "Defne KURT" };
            employee1.AddSubordinate(employee2);
            employee1.AddSubordinate(employee3);
            employee2.AddSubordinate(employee4);
            Contractor contractor1 = new Contractor { Name = "Deniz KURT" };
            employee2.AddSubordinate(contractor1);
            Console.WriteLine(employee1.Name);
            foreach (Employee manager in employee1)
            {
                Console.WriteLine(manager.Name);
                foreach (IPerson employee in manager)
                {
                    Console.WriteLine(" " + employee.Name);
                }
            }

            Console.ReadLine();
        }
    }
    public interface IPerson
    {
        string Name { get; set; }
    }
    class Contractor : IPerson
    {
        public string Name { get; set; }
    }
    class Employee : IPerson, IEnumerable<IPerson>
    {
        List<IPerson> _subordinates = new List<IPerson>();
        public void AddSubordinate(IPerson person)
        {
            _subordinates.Add(person);
        }
        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }
        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }
        public string Name { get; set; }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
