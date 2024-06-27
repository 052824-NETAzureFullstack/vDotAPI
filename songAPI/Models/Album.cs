using Microsoft.EntityFrameworkCore;

namespace songAPI.Models
{
    public class Album
    {
        public int Id { get; set; }
        public List<Title> TrackList {get; set; } = new List<Title>();
        public List<Artist> Composers {get; set; } = new List<Artist>();
        public string AlbumName { get; set; } = "";

    }

}