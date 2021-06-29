namespace People.Repository.Repositories
{
    using People.Domain.Context;
    using People.Domain.Entities;
    using People.Repository.Base;
    using People.Repository.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        private readonly DataContext _context;

        public PersonRepository(
            DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
