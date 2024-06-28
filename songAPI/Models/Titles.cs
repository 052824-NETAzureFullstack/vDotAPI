using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Microsoft.EntityFrameworkCore;

namespace songAPI.Models
{
    public class Title
    {
        // Primary Key
        public int Id { get; set; }

        // Foreign Key(s)
        public Artist Artist { get; set; }
        public Album Album { get; set; }

        
        public string SongName { get; set; } = "";
        public string Genre { get; set; } = "";
        public int Tempo { get; set; }
      }

}