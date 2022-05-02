using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Domain.Repositories.Interfaces;
using API.Domain.Database.Models;
using API.Domain.Database;

namespace API.Domain.Repositories
{
    public class GroupRepository : IRepository<Group>
    {
        AppDbContext db;

        public GroupRepository(AppDbContext db)
        {
            this.db = db;
        }


        public bool Create(Group obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Group Read(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Group obj)
        {
            throw new NotImplementedException();
        }
    }
}