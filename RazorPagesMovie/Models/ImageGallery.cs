using Microsoft.AspNetCore.Http;
using RazorPagesMovie.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class ImageGallery
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Path { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Please select a file.")]
        [DataType(DataType.Upload)]
        [Display(Name ="Image")]
        [MaxFileSize(1 * 1024)]
        [AllowedExtensions(new string[] { ".jpg", ".png" })]
        public IFormFile FormFile { get; set; }
    }
}
