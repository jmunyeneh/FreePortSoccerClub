using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreePortSoccer.Models
{

    public enum PosiDesc
    {
        Goalkeepers = 1
       , Defenders = 2
       , Midfielders = 3
       , Forward = 4
    }
    public class Player
    {
        public long PlayerId { get; set; }
        public int JerseyNo { get; set; }
        public string PlayerName { get; set; }
      
        [Display(Name = "Date Of Birth"),DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public int Age { get; set; }
        public string PlayingClub { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int PositionId { get; set; }
        public Position position { get; set; }

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
