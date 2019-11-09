using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL.WebApp.Models;

namespace TGL.WebApp.Data
{
    public class ComputerStore
    {
        public TGLContext Context { get; set; }
        public ComputerStore(TGLContext context)
        {
            Context = context;
        }
        internal void EditComputer(Computer computer) {
            Computer currentComputer = GetComputerById(computer.Id);
            currentComputer.Brand = computer.Brand;
            currentComputer.Model = computer.Model;
            currentComputer.Ram = computer.Ram;
            currentComputer.Cpu = computer.Cpu;
            currentComputer.StudentId = computer.StudentId;
            Context.Computer.Update(currentComputer);
            Context.SaveChanges();
        }

        public Computer GetComputerById(Guid id)
        {
            return Context.Computer.FirstOrDefault(x => x.Id == id);
        }

        internal void AddComputer(Computer computer) {

            Context.Computer.Add(computer);
            Context.SaveChanges();
        }

        internal void DeleteComputer(Guid id) { 
        var computer = Context.Computer.FirstOrDefault(x => x.Id == id);
            Context.Computer.Remove(computer);
            Context.SaveChanges();
        }

        public List<Computer> GetComputers()
        {
            return Context.Computer.ToList();
        }

    }
}

