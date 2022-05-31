using ArtWorld.DataAccess.Data;
using ArtWorld.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWorld.Api.Controllers
{
    [ApiController]
    [Route("api/anime")]
    public class AnimeController : ControllerBase
    {
        private readonly ArtWorldDBContext _db;

        public AnimeController(ArtWorldDBContext db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Anime anime)
        {
            if (anime == null)
            {
                return BadRequest();
            }

            var genreIds = anime.Genres.Split(',').Select(g => Int32.Parse(g));
            var animeGenres = new List<AnimeGenre>();

            foreach (int genreId in genreIds)
            {
                animeGenres.Add(new AnimeGenre
                {
                    Anime = anime,
                    Genre = _db.Genres.FirstOrDefault(g => g.Id == genreId)
                });
            }

            anime.AnimeGenres = animeGenres;
            _db.Anime.Add(anime);
            await _db.SaveChangesAsync();

            return Ok(anime);
        }
    }
}
