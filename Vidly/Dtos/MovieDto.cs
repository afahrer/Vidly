﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public DateTime releaseDate { get; set; }
        [Range(1, 20)]
        public int stock { get; set; }
        [Required]
        public byte GenreId { get; set; }
    }
}