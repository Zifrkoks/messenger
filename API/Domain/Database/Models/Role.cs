using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Domain.Database.Models
{
    public class Role
    {
        public int      Id      {get;set;}
        public int      GroupId {get;set;}
        [ForeignKey("GroupId")]
        public Group?   Group   {get;set;}
        public string?  Name    {get;set;} 
    }
}