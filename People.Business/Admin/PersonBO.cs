namespace People.Business.Admin
{
    using People.Business.Interfaces;
    using People.Domain.Context;
    using People.Domain.Entities;
    using People.Repository.Interfaces;
    using People.Repository.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PersonBO : IPersonBO
    {
        private readonly IPersonRepository _repository;
        public PersonBO(DataContext context)
        {
            _repository = new PersonRepository(context);
        }
        public async Task<Person> CreateAsync(Person entity)
        {
            return await _repository.CreateAsync(entity);
        }

        public async Task DeleteAsync(Person entity)
        {
            await _repository.DeleteAsync(entity);
        }

        public IQueryable<Person> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Person> UpdateAsync(Person entity)
        {
            return await _repository.UpdateAsync(entity);
        }
    }
}
