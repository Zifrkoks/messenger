using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Domain.Database;
using API.Domain.Database.Models;
using API.Domain.Repositories.Interfaces;

namespace API.Domain.Repositories
{
    public class RoleRepository : IRepository<Role>
    {
        AppDbContext db;

        public RoleRepository(AppDbContext db)
        {
            this.db = db;
        }

        public bool Create(Role obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Role Read(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Role obj)
        {
            throw new NotImplementedException();
        }
    }
}