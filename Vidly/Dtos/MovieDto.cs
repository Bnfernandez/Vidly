using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required()]
        [StringLength(255)]
        public string Name { get; set; }

        [Required()]
        [Column(TypeName = "DateTime2")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; } = new DateTime(1900, 1, 1);

        [Required()]
        [Range(1, 20)]
        public int NumberInStock { get; set; }

        [Required()]
        public int MovieGenreId { get; set; }

        public MovieGenreDto MovieGenre { get; set; }
    }
}