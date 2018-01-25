using System.ComponentModel.DataAnnotations;

namespace DogFinderMVC.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public City Cities
        {
            get; set;
        }
    }
}
