using Microsoft.EntityFrameworkCore;

namespace songAPI.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Name { get; set; } = "";
        public int artistId { get; set; }

        public List<Title> trackList { get; set; } = new List<Title>();

    }

}