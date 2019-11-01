using System;

namespace MavenDate.API.Dtos
{
    public class MessageToReturnDto
    {
        public int Id { get; set; } 
       public int SenderId { get; set; } 
       public string SenderKnownAs { get; set; }
       public string SenderPhotoUrl { get; set; }

        public int RecipentId { get; set; } 
       public string RecipentKnownAs { get; set; }
       public string RecipentPhotoUrl { get; set; }

       public string Content { get; set; }

       public bool IsRead { get; set; }

       public DateTime? DateRead { get; set; }

       public DateTime MessageSent { get; set; }
    }
}