using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL.WebApp.Models;

namespace TGL.WebApp.Data
{
    public class TGLContext : DbContext
    {

        public DbSet<Student> Student { get; set; }
        public TGLContext(DbContextOptions<TGLContext> options):base(options)
        {

        }
    }
}
