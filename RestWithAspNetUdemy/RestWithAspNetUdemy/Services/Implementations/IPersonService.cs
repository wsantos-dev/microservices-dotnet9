﻿using RestWithAspNetUdemy.Models;

namespace RestWithAspNetUdemy.Services.Implementations
{
    public interface IPersonService
    {
        Person Create (Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update (Person person);
        void Delete(long id);
    }
}
