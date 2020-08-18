using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreePortSoccer.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.MultilineText)]
        public string Article { get; set; }
        public string Author { get; set; }
        [DataType(DataType.Date)]
        public DateTime InsertedDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime ModifiedDate { get; set; }
        public bool IsHighLights { get; set; }

        #region Image 
        public byte[] Image { get; set; }

        public string ImageContentType { get; set; }

        public string GetInlineImageSrc()
        {
            if (Image == null || ImageContentType == null)
                return null;

            var base64Image = System.Convert.ToBase64String(Image);
            return $"data:{ImageContentType};base64,{base64Image}";
        }

        public void SetImage(Microsoft.AspNetCore.Http.IFormFile file)
        {
            if (file == null)
                return;

            ImageContentType = file.ContentType;

            using (var stream = new System.IO.MemoryStream())
            {
                file.CopyTo(stream);
                Image = stream.ToArray();
            }
        }
        #endregion
    }
}
