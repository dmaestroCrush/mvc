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

        [Required, StringLength(255)]
        public string Name { get; set; }

        public DateTime ReleasedDate { get; set; }

        public DateTime DateAdded { get; set; }

        public GenreDto Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }
  
        [Range(1, 20)]
        public short NumberInStocks { get; set; }
    }
}