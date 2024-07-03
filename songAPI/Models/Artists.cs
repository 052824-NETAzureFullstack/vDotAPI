using Microsoft.EntityFrameworkCore;

namespace songAPI.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public List<Title> Songs {get; set; } = new List<Title>();
        public List<Album> Discography { get; set; } = new List<Album>();

    }

}