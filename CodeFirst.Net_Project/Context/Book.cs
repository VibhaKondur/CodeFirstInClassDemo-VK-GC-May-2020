using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Net_Project.Context
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MinLength(0)]
        public string Genre { get; set; }
        [MinLength(0)]
        public int PageCount { get; set; }


        //Context needs 3 things:
        //1) Subclass DbContext 
 

    }

    public class BookContext : DbContext
    {

        //2) Create a constructor passing in options 
        public BookContext(DbContextOptions options) : base(options)
        {

        }

        //3) A DbSet<model> for each table you want to make
        public DbSet<Book> Books { get; set; }

    }
}
