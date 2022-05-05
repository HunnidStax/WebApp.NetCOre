using System;
using System.Collections.Generic;
using System.Linq;
using Timesheets.Controllers.Models;
using Timesheets.DB;
using Timesheets.Interfaces;

namespace Timesheets.DAL.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DBHelper _context;
        public PersonRepository(DBHelper context)
        {
            _context = context;
        }
        public bool Create(PersonDto entity)
        {
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception exception)
            {
                return false;
            }
            return true;
        }
        public IEnumerable<PersonDto> GetAll()
        {
            return _context.Person.ToList();
        }
        public bool Update(PersonDto entity)
        {
            return Commit();
        }
        public bool Delete(int id)
        {
            return Commit();
        }
        private bool Commit()
        {
            int count = _context.SaveChanges();
            return count > 0;
        }
    }
}
