using System.ComponentModel.DataAnnotations;

namespace DogFinderMVC.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public Country Country { get; set; }
    }
}
