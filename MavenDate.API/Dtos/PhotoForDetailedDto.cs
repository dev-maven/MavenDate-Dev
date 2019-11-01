using System;

namespace MavenDate.API.Dtos
{
    public class PhotoForDetailedDto
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }

        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }  
    }
}