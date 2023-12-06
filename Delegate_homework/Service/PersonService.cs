using Delegate_homework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_homework.Service
{
    internal class PersonService
    {
        public delegate bool CheckSalary(Person person);

        public void SortBySalary(List<Person> people, CheckSalary check)
        {
         
            foreach (Person person in people)
            {
                if (check(person))
                {
                    Console.WriteLine($"{person.Name}-{person.Surname}-{person.Address}");
                }
            }
        }

        public void ShowResult()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { Id = 1, Address = "Yasamal", Name = "Arzu", Surname = "Kerimli", Salary = 1000 });
            people.Add(new Person { Id = 2, Address = "Nesimi", Name = "Zeyvi", Surname = "Kerimova", Salary = 2000 });
            people.Add(new Person { Id = 3, Address = "Nizami", Name = "Feride", Surname = "Ezizli", Salary = 2500 });
            people.Add(new Person { Id = 4, Address = "Ehmedli", Name = "Nurane", Surname = "Eliyeva", Salary = 500 });

            SortBySalary(people, person => person.Salary > 1000);
        }
    }
}
