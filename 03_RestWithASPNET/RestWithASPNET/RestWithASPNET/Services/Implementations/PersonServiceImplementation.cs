using RestWithASPNET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 8; i++)
            {

            }
            return persons;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Isadora",
                LastName = "Vieira",
                Address = "Marechal Dutra",  
                Gender = "Female"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Address = "Some Adress" + i,
                Gender = "Female"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

    }
}
