using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TGL.WebApp.Models
{
    public class Student
    {
        public Student()
        {
            Id = Guid.NewGuid();
        }
        
        public Guid Id { get; set; }
               
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Nit { get; set; }
        public int? Age { get; set; }
        public List<Computer> Computers { get; set; }

    }
}
