using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TGL.WebApp.Models
{
    public class Computer
    {
        public Computer()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Cpu { get; set; }
        public string Ram { get; set; }



}
}
