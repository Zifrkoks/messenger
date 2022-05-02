namespace API.Domain.Database.Models
{
    public class Group
    {

        public int              Id          {get;set;}

        public string?          Name        {get;set;}

        public List<User>       Users       {get;set;} = new();
        public List<Massage>    Massages    {get;set;} = new();
        public List<Role>       Roles       {get;set;} = new();

    }
}