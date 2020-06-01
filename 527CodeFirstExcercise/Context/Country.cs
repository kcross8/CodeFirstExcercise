using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _527CodeFirstExcercise.Context
{
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Continent { get; set; }
        public int Population { get; set; }
    }

    public class CountryContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public CountryContext(DbContextOptions options) : base(options) { }
    }   

}
