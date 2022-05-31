using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ArtWorld.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
#nullable enable
        [JsonIgnore]
        public ICollection<AnimeGenre>? AnimeGenres { get; set; }
#nullable disable
    }
}
