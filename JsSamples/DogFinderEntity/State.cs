using System.ComponentModel.DataAnnotations;

namespace DogFinderEntity
{
    public class State
    {
        public State()
        {

        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public City Cities
        {
            get; set;
        }
    }
}
