using Microsoft.EntityFrameworkCore;

namespace songAPI.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; } = "";
        public List<Album> Discography { get; } = new List<Album>();
        public List<Title> TrackList { get; } = new List<Title>();

    }

}