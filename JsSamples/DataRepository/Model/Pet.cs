using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataRepository.Model
{
    public class Pet
    {
        [Key]
        public long   Id    { get; set; }
        public string Name  { get; set; }
        public string Raze  { get; set; }
        public int    Years { get; set; }
    }
}
