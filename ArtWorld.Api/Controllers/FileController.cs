using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ArtWorld.DataAccess.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArtWorld.Api.Controllers
{
    public class FileController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;
        private readonly ArtWorldDBContext _db;

        public FileController(IWebHostEnvironment env, ArtWorldDBContext db)
        {
            _env = env;
            _db = db;
        }

        [HttpGet]
        public IActionResult GetVideo(string video)
        {
            string path = Path.Combine(_env.WebRootPath, video);
            return new FileStreamResult(new FileStream(path, FileMode.Open, FileAccess.Read), "video/*");
        }

        [Route("api/videos")]
        [RequestSizeLimit(524288000)]
        [HttpPost]
        public async Task<IActionResult> UploadVideo(IFormCollection video)
        {
            var formKeys = video.Keys;

            if (formKeys.Count > 0)
            {
                string dbFileName = _db.Anime.FirstOrDefault(a => a.Id == Int32.Parse(formKeys.First())).Teaser;
                DeleteFile(dbFileName);
            }

            var formFile = video.Files[0];
            string ext = Path.GetExtension(formFile.FileName);
            string fileName = String.Concat(Path.GetRandomFileName(), ext);
            string path = Path.Combine(_env.WebRootPath, fileName);

            using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                await formFile.CopyToAsync(fs);
            }

            return Ok(fileName);
        }

        [Route("api/image")]
        [HttpPost]
        public async Task<IActionResult> UploadImage(IFormCollection image)
        {
            var formKeys = image.Keys;

            if (formKeys.Count > 0)
            {
                string dbFileName = _db.Anime.FirstOrDefault(a => a.Id == Int32.Parse(formKeys.First())).Image;
                DeleteFile(dbFileName);
            }

            var formFile = image.Files[0];
            string ext = Path.GetExtension(formFile.FileName);
            string fileName = String.Concat(Path.GetRandomFileName(), ext);
            string path = Path.Combine(_env.WebRootPath, fileName);

            using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                await formFile.CopyToAsync(fs);
            }

            return Ok(fileName);
        }

        [Route("api/images")]
        [HttpPost]
        public async Task<IActionResult> UploadImages(IFormCollection images)
        {
            var formKeys = images.Keys;

            if (formKeys.Count > 0)
            {
                string dbFileNames = _db.Anime.FirstOrDefault(a => a.Id == Int32.Parse(formKeys.First())).Images;
                DeleteFiles(dbFileNames.Split(','));
            }

            var formFiles = images.Files;
            List<string> fileNames = new List<string>();

            foreach (var formFile in formFiles)
            {
                string ext = Path.GetExtension(formFile.FileName);
                string fileName = String.Concat(Path.GetRandomFileName(), ext);
                string path = Path.Combine(_env.WebRootPath, fileName);

                using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    await formFile.CopyToAsync(fs);
                }

                fileNames.Add(fileName);
            }

            return Ok(String.Join(',', fileNames));
        }

        private void DeleteFile(string fileName)
        {
            string path = Path.Combine(_env.WebRootPath, fileName);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
        }

        private void DeleteFiles(string[] fileNames)
        {
            foreach (string fileName in fileNames)
            {
                string path = Path.Combine(_env.WebRootPath, fileName);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
            }
        }
    }
}
