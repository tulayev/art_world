using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ArtWorld.Models
{
    public class Anime
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string TitleRomadzi { get; set; }
#nullable enable
        public int? Rating { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public string? Info { get; set; }
        public string? Image { get; set; }
        public string? Images { get; set; }
        public string? Teaser { get; set; }

        [ForeignKey(nameof(Studio))]
        public int? StudioId { get; set; }
        [JsonIgnore]
        public Studio? Studio { get; set; }
        [NotMapped]
        public string? Genres { get; set; }
        [JsonIgnore]
        public ICollection<AnimeGenre>? AnimeGenres { get; set; }
#nullable disable
    }
}
