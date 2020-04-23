using System;

namespace ProjectApp.API.Dtos
{
    public class PhotosForDetailedDto
    {
        public string Url { get; set;}
        public string Description {get; set;}
        public DateTime DateAdded { get; set;}
        public Boolean IsMain { get; set; }
        public int UserId {get; set;}
    }
}