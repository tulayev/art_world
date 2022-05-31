using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ArtWorld.Models
{
    public class Studio
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }        
#nullable enable
        [JsonIgnore]
        public ICollection<Anime>? Anime { get; set; }
#nullable disable
    }
}
