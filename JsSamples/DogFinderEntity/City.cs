using System.ComponentModel.DataAnnotations;

namespace DogFinderEntity
{
    public class City
    {
        public City()
        {

        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
