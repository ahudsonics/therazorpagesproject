using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razorpagesproject.Models;

    public class razorpagesprojectContext : DbContext
    {
        public razorpagesprojectContext (DbContextOptions<razorpagesprojectContext> options)
            : base(options)
        {
        }

        public DbSet<razorpagesproject.Models.Movie> Movie { get; set; } = default!;
    }
