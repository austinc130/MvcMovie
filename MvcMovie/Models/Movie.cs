using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage ="The title must have at least 3 letters.")]
        [Required(ErrorMessage ="Please enter the movie's title.")]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


        [Required]
        [StringLength(30)]
        public string Genre { get; set; }


        [StringLength(5)]
        [Required]
        public string Rating { get; set; }
    }
}