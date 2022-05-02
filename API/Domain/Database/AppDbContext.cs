using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Domain.Database.Models;
namespace API.Domain.Database
{
    public class AppDbContext:DbContext
    {
        public DbSet<User> Users {get;set;} = null!;
        public DbSet<Role> Roles {get;set;} = null!;
        public DbSet<Massage> Massages {get;set;} = null!;
        public DbSet<Group> Groups {get;set;} = null!;
        AppDbContext(DbContextOptions<AppDbContext> options)
        :base(options){
            Database.EnsureCreated();
        }
    }
}