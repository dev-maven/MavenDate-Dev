using System;

namespace MavenDate.API.Models
{
    public class Message
    {
       public int Id { get; set; } 
       public int SenderId { get; set; } 
       public User Sender { get; set; }

        public int RecipentId { get; set; } 
       public User Recipent { get; set; }

       public string Content { get; set; }

       public bool IsRead { get; set; }

       public DateTime? DateRead { get; set; }

       public DateTime MessageSent { get; set; }

       public bool SenderDeleted { get; set; }

       public bool RecipentDeleted { get; set; }
    }
}