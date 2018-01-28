using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DogFinderEntity
{
    public class PetOwner
    {
        public PetOwner()
        {

        }
        [Key]
        public int Id { get; set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public Int16 Age { get;  set; }
        
        public Address Address { get; set; }
        public List<string> ContactPhone { get; set; }

        public IList<Pet> Pets { get; set; }
    }
}
