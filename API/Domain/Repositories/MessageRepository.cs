using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Domain.Repositories.Interfaces;
using API.Domain.Database.Models;
using API.Domain.Database;

namespace API.Domain.Repositories
{
    public class MessageRepository : IRepository<Massage>
    {
        AppDbContext db;

        public MessageRepository(AppDbContext db)
        {
            this.db = db;
        }

        public bool Create(Massage obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Massage Read(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Massage obj)
        {
            throw new NotImplementedException();
        }
    }
}