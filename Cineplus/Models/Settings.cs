using System.ComponentModel.DataAnnotations;

namespace Cineplus.Models
{
    public class Settings: DbEntity
    {
        [Required]
        public string Name { get; set; }
        public bool Active { get; set; }
        public string Type { get; set; }
    }
}