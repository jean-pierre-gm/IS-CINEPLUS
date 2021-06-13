using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Cineplus.Services;

namespace Cineplus.Models
{
    public class Actor: DbEntity
    {
        [Required]
        [Filter(FilterBy = "name")]
        [Sortable(OrderBy = "name")]
        public string ActorName { get; set; }
        
        [JsonIgnore]
        public virtual ICollection<ActorMovie> Movies { get; set; }

        public Actor()
        {
            this.Movies = new HashSet<ActorMovie>();
        }
    }
}