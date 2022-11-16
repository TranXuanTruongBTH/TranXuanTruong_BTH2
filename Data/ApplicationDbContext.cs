using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TranXuanTruongBTH2.Models;

namespace TranXuanTruongBTH2.Data
{
    public class ApplicationDbcontext:DbContext
    {
        public ApplicationDbcontext (DbContextOptions<ApplicationDbcontext> options):base(options)
        {
        }
        public DbSet<TranXuanTruongBTH2.Models.Faculty> Faculty {get; set;} =default!;
        public DbSet<TranXuanTruongBTH2.Models.Student> Student {get; set;} = default!;
        public DbSet<TranXuanTruongBTH2.Models.Customer>? Customer { get; set; }
        public DbSet<TranXuanTruongBTH2.Models.Person>? Person { get; set; }
        public DbSet<TranXuanTruongBTH2.Models.Employee>? Employee { get; set; }
    }
}