namespace People.Repository.Interfaces
{
    using People.Domain.Entities;
    using People.Repository.Base;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public interface IPersonRepository : IGenericRepository<Person>
    {
        List<Person> GetAllByDocumentNumber(string documentNumber);
    }
}
