using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace songAPI.Models
{
    public class Title
    {
        // Primary Key
        [Key]
        public int songId { get; set; }
        
        // Foreign keys
        public int artistId { get; set; }
        public int albumId { get; set; }

        public string titleName { get; set; } = "";
        public string genre { get; } = "";
        public DateOnly releaseDate { get; set; }
    }

}