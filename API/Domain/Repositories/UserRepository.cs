using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Domain.Repositories.Interfaces;
using API.Domain.Database.Models;
using API.Domain.Database;

namespace API.Domain.Repositories
{
    public class UserRepository : IRepository<User>
    {
        AppDbContext db;

        public UserRepository(AppDbContext db)
        {
            this.db = db;
        }

        public bool Create(User obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Read(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, User obj)
        {
            throw new NotImplementedException();
        }
    }
}