using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter movie's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter movie's release date.")]
        [Display( Name = "Release Date")]
        [Column(TypeName = "DateTime2")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; } = new DateTime(1900,1,1);

        [Required(ErrorMessage = "Please enter movie's number in stock.")]
        [Range(1,20,ErrorMessage = "The number in stock of your movie should be between 1 and 20.")]
        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }

        public MovieGenre MovieGenre { get; set; }

        [Required(ErrorMessage = "Please enter movie's genre.")]
        [Display(Name = "Movie Genre")]
        public int MovieGenreId { get; set; }

        public int NumberAvailable { get; set; }
    }
}