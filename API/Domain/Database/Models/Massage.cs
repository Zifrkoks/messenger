using System.ComponentModel.DataAnnotations.Schema;


namespace API.Domain.Database.Models
{
    public class Massage
    {
        public int              Id              {get;set;}

        [ForeignKey("SenderId")]
        public User?            Sender          {get;set;}
        public int              SenderId        {get;set;}
        [ForeignKey("ReceiverId")]
        public User?            Receiver        {get;set;}
        public int              ReceiverId      {get;set;}
        public string?          Text            {get;set;}
        public DateTime         DateTimeSended  {get;set;}

    }
}