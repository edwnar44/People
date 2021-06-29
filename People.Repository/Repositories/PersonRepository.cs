namespace People.Repository.Repositories
{
    using People.Domain.Context;
    using People.Domain.Entities;
    using People.Repository.Base;
    using People.Repository.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        private readonly DataContext _context;
        public List<Person> PersonList;

        public PersonRepository(
            DataContext context) : base(context)
        {
            _context = context;
            LoadData();
        }

        public List<Person> GetAllByDocumentNumber(string documentNumber)
        {
            try
            {
                if (string.IsNullOrEmpty(documentNumber)) {
                    return PersonList;
                }
                else
                {
                    return PersonList.Where(p => p.DocumentNumber.Contains(documentNumber)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void LoadData()
        {
            try
            {
                PersonList = new List<Person>();

                Person person1 = new Person
                {
                    Id = 1,
                    Name = "Pepito",
                    LastName = "Perez",
                    Address = "Pasto",
                    DocumentNumber = "1234567890",
                    Email = "pepito@gmail.com",
                    PhoneNumber = "3216547878"
                };

                Person person2 = new Person
                {
                    Id = 2,
                    Name = "Sandra",
                    LastName = "Ramirez",
                    Address = "Bogota",
                    DocumentNumber = "987654321",
                    Email = "sandra@gmail.com",
                    PhoneNumber = "3217845122"
                };

                Person person3 = new Person
                {
                    Id = 3,
                    Name = "Edwin",
                    LastName = "Narvaez",
                    Address = "Pastop",
                    DocumentNumber = "870615154",
                    Email = "edwin@gmail.com",
                    PhoneNumber = "3206865421"
                };

                Person person4 = new Person
                {
                    Id = 4,
                    Name = "Ramiro",
                    LastName = "Bolaños",
                    Address = "Cali",
                    DocumentNumber = "870685455",
                    Email = "ramiro@gmail.com",
                    PhoneNumber = "3225487566"
                };

                Person person5 = new Person
                {
                    Id = 5,
                    Name = "Oscar",
                    LastName = "Vallejo",
                    Address = "Santa Marta",
                    DocumentNumber = "98652145",
                    Email = "oscar@gmail.com",
                    PhoneNumber = "311548752"
                };

                PersonList.Add(person1);
                PersonList.Add(person2);
                PersonList.Add(person3);
                PersonList.Add(person4);
                PersonList.Add(person5);

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
