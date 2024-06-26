using Microsoft.EntityFrameworkCore;

namespace songAPI.Models
{
    public class Artist
    {
        public int artistId { get; set; }
        public string Name { get; set; } = "";
        public List<Album> Discography { get; set; } = new List<Album>();
        public List<Title> trackList { get; set; } = new List<Title>();

    }

}