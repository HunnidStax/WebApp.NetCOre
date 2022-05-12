using System;
using System.Collections.Generic;
using System.Linq;
using Timesheets.Controllers.Models;
using Timesheets.DB;
using Timesheets.Interfaces;

namespace Timesheets.DAL.Repository
{
    public class ContractRepository : IContractRepository
    {
        private readonly DBHelper _context;
        public ContractRepository(DBHelper context)
        {
            _context = context;
        }
        public bool Create(ContractDto entity)
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
        public IEnumerable<ContractDto> GetAll()
        {
            return _context.Contract.ToList();
        }
        public bool Update(ContractDto entity)
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
