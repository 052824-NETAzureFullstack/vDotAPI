using Microsoft.EntityFrameworkCore;

namespace songAPI.Models
{
    public class Title
    {
        public int songId { get; set; }
        public string titleName { get; set; } = "";
        public string genre { get; } = "";
        public DateOnly releaseDate { get; set; }

    }

}