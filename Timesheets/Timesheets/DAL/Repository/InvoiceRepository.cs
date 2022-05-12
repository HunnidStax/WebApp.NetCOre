using System;
using System.Collections.Generic;
using System.Linq;
using Timesheets.Controllers.Models;
using Timesheets.DB;
using Timesheets.Interfaces;

namespace Timesheets.DAL.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly DBHelper _context;
        public InvoiceRepository(DBHelper context)
        {
            _context = context;
        }
        public bool Create(InvoicesDto entity)
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
        public IEnumerable<InvoicesDto> GetAll()
        {
            return _context.Invoices.ToList();
        }
        public bool Update(InvoicesDto entity)
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
