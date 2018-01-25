﻿using System.ComponentModel.DataAnnotations;

namespace DogFinderMVC.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
