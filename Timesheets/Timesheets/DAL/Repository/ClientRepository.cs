using System;
using System.Collections.Generic;
using System.Linq;
using Timesheets.Controllers.Models;
using Timesheets.DB;
using Timesheets.Interfaces;

namespace Timesheets.DAL.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly DBHelper _context;
        public ClientRepository(DBHelper context)
        {
            _context = context;
        }
        public bool Create(ClientDto entity)
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
        public IEnumerable<ClientDto> GetAll()
        {
            return _context.Client.ToList();
        }
        public bool Update(ClientDto entity)
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
