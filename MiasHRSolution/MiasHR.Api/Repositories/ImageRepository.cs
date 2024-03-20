using MiasHR.Api.Data;
using MiasHR.Api.Entities;
using MiasHR.Api.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace MiasHR.Api.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly MiasHRDbContext _miasHRDbContext;
        private readonly IConfiguration _configuration;

        public ImageRepository(MiasHRDbContext miasHRDbContext, IConfiguration configuration)
        {
            _miasHRDbContext = miasHRDbContext;
            _configuration = configuration;
        }

        public async Task<byte[]> GetProfileImage(string emplCode)
        {
            var imageBytes = await _miasHRDbContext.HrEmployees
                .AsNoTrackingWithIdentityResolution()
                .FirstAsync(x => x.EmplCode == emplCode);

            return imageBytes.Photo;
        }

        public async Task<byte[]> GetProfileImageIcon(string emplCode)
        {
            var imageBytes = await _miasHRDbContext.HrEmployees
                .AsNoTrackingWithIdentityResolution()
                .FirstAsync(x => x.EmplCode == emplCode);

            if (imageBytes.Photo == null)
            {
                return null;
            }
            else
            {
                var ms = new MemoryStream(imageBytes.Photo);
                var originalBitmap = new Bitmap(ms);

                int originalWidth = originalBitmap.Width;
                int newHeight = originalWidth;

                var resizedBitmap = new Bitmap(originalWidth, newHeight);
                using (var graphics = Graphics.FromImage(resizedBitmap))
                {
                    graphics.DrawImage(originalBitmap, 0,0, originalWidth, newHeight);
                }

                // Convert back to byte array
                var resultStream = new MemoryStream();
                resizedBitmap.Save(resultStream, originalBitmap.RawFormat); // Preserve original format
                return resultStream.ToArray();
            }
        }
    }
}
