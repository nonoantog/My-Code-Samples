using System.ComponentModel.DataAnnotations;

namespace DogFinderEntity
{
    public class Address
    {
        public Address()
        {

        }
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public Country Country { get; set; }
    }
}
