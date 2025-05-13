﻿using RestWithAspNetUdemy.Models;

namespace RestWithAspNetUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }
        public Person FindById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Wellington",
                LastName  = "Santos",
                Address   = "Rua dois",
                Gender    = "Male"
            };
        }
        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }

        public Person Update(Person person)
        {
            return person;
        }
        public void Delete(long id)
        {

        }


        private Person MockPerson(int i)
        {
            return new Person 
            { 
                Id = IncrementAndGet(), 
                FirstName = "Person Name " + i, 
                LastName = "Person LastName", 
                Address = "Some Address", 
                Gender = "Female" 
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
