﻿using System;

namespace MovieAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string PosterUrl { get; set; }
        public string TrailerUrl { get; set; }
    }
}