using System;
using System.Collections.Generic;
using System.Linq;
using Timesheets.Controllers.Models;
using Timesheets.DB;
using Timesheets.Interfaces;

namespace Timesheets.DAL.Repository
{
    public class EmployeeRepository : IEmplyeeRepository
    {
        private readonly DBHelper _context;
        public EmployeeRepository(DBHelper context)
        {
            _context = context;
        }
        public bool Create(EmployeeDto entity)
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
        public IEnumerable<EmployeeDto> GetAll()
        {
            return _context.Employee.ToList();
        }
        public bool Update(EmployeeDto entity)
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
