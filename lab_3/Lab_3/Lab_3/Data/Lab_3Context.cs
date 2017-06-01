using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab_3.Models
{
    public class Lab_3Context : DbContext
    {
        public Lab_3Context (DbContextOptions<Lab_3Context> options)
            : base(options)
        {
        }

        public DbSet<Lab_3.Models.Movie> Movie { get; set; }
    }
}
