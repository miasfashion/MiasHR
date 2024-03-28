using MiasHR.Api.Data;
using MiasHR.Api.Entities;
using MiasHR.Api.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Drawing.Imaging;

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

                // Calculate the size for the square crop
                int cropSize = Math.Min(originalBitmap.Width, originalBitmap.Height);

                // Calculate cropping rectangle to center the crop area
                int cropX = (originalBitmap.Width - cropSize) / 2;
                int cropY = (originalBitmap.Height - cropSize) / 2;

                // Create a new bitmap for the cropped image
                using (Bitmap croppedBitmap = new Bitmap(cropSize, cropSize))
                {
                    using (Graphics g = Graphics.FromImage(croppedBitmap))
                    {
                        g.DrawImage(originalBitmap,
                                    new Rectangle(0, 0, cropSize, cropSize),
                                    new Rectangle(cropX, cropY, cropSize, cropSize),
                                    GraphicsUnit.Pixel);

                        // Prepare to save the image to a MemoryStream
                        MemoryStream memoryStream = new MemoryStream();

                        // Save the resized image to the MemoryStream, preserving the original format
                        croppedBitmap.Save(memoryStream, originalBitmap.RawFormat);

                        return memoryStream.ToArray();
                    }
                }
            }
        }
    }
}
