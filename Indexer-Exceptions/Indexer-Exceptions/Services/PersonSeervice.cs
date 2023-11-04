using System;
using Indexer_Exceptions.Data;
using Indexer_Exceptions.Models;
using Indexer_Exceptions.Services.Interface;

namespace Indexer_Exceptions.Services
{
    public class PersonService : IPersonService
    {
        private readonly AppDbContext _context;

        public PersonService()
        {
            _context = new AppDbContext();
                
        }

        public Person GetById(int? id)
        {
            if (id is null) throw new ArgumentException();

            Person? existPerson = _context.People().FirstOrDefault(m => m.Id == id);

            if(existPerson == null)throw new NullReferenceException("Data not found");

            return existPerson;
        }
    }
}

