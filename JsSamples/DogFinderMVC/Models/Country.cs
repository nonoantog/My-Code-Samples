using System.ComponentModel.DataAnnotations;

namespace DogFinderMVC.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public State States { get; set; }
    }
}