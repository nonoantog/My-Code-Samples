using DogFinderMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace DogFinderMVC.DAL
{
    public class PetFinderContext : DbContext
    {
        public PetFinderContext() : base("PetFinderContext")
        {
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Cuntries { get; set; }
        public DbSet<Pet> Pets            { get; set; }
        public DbSet<PetOwner> PetsOwners { get; set; }
        public DbSet<State> States        { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

       
    }
}