using System.ComponentModel.DataAnnotations;

namespace DogFinderEntity
{
    public class Country
    {
        public Country()
        {

        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public State States { get; set; }
    }
}