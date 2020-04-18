using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public ICollection<Category> categories;

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ModifiedDate { get; set; }
    }
}
