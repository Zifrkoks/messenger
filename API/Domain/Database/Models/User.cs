using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Domain.Database.Models
{
    public class User
    {
        public int              Id          {get;set;}

        public string?          Username    {get;set;}

        public string?          Password    {get;set;}

        public string?          Family      {get;set;}

        public string?          Name        {get;set;}

        public List<Group>      Groups      {get;set;} = new();

        public List<Massage>    Massages    {get;set;} = new();
    }
}