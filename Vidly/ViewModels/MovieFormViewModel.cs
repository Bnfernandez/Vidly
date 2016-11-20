using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<MovieGenre> MovieGenres { get; set; }
        public List<Movie> Movies { get; set; }

        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter movie's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter movie's release date.")]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please enter movie's number in stock.")]
        [Range(1, 20, ErrorMessage = "The number in stock of your movie should be between 1 and 20.")]
        [Display(Name = "Number In Stock")]
        public int? NumberInStock { get; set; }

        [Required(ErrorMessage = "Please enter movie's genre.")]
        [Display(Name = "Movie Genre")]
        public int? MovieGenreId { get; set; }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            MovieGenreId = movie.MovieGenreId;
        }

        public string Title => Id != 0 ? "Edit Movie" : "New Movie";
    }
}