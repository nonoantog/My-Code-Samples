using System;
using System.ComponentModel.DataAnnotations;

namespace DogFinderEntity
{
    //class to store pet data, like description, name, etc
    public class Pet
    {
        public Pet()
        {

        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Int16  Age  { get; set; }
        public string Description { get; set; }
        public string PetType { get; set; }
        public PetOwner Owner { get; set; }
     }

}