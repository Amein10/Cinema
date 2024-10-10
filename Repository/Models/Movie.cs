using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title can't be longer than 100 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        [StringLength(50, ErrorMessage = "Genre can't be longer than 50 characters")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Duration is required")]
        [Range(1, 300, ErrorMessage = "Duration should be between 1 and 300 minutes")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "Year of release is required")]
        [Range(1900, 2100, ErrorMessage = "Year of release must be between 1900 and 2100")]
        public int YearOfRelease { get; set; }
    }
}
