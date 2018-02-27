using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GridCore.Models
{
    public class PetContext:DbContext
    {
        public DbSet<Pet> Pets { get; set; }
        public PetContext(DbContextOptions<PetContext> options) : base(options) { }
    }
}
