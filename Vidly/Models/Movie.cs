﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set;  }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Display(Name="Release Date")]
        [Required]
        public DateTime releaseDate { get; set; }
        [Required]
        public DateTime dateAdded { get; set; }
        [Display(Name = "Number in Stock")]
        [Required]
        public int stock { get; set; }
        public Genre Genre { get; set; }
        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }
    }
}