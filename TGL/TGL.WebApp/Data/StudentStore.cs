using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL.WebApp.Models;

namespace TGL.WebApp.Data
{
    public class StudentStore
    {
        //private List<Student> Students { get; set; } = new List<Student>(); //Inicializa Lista
        public TGLContext Context { get; set; }
        public StudentStore(TGLContext context)
        {
            Context = context;
        }

        internal void EditStudent(Student student)
        {
            Student currentStudent = GetStudentById(student.Id);
            currentStudent.Name = student.Name;
            currentStudent.LastName = student.LastName;
            currentStudent.Age = student.Age;
            currentStudent.Nit = student.Nit;
            Context.Student.Update(currentStudent);
            Context.SaveChanges();
        }

        internal Student GetStudentById(Guid id)
        {
            return Context.Student.FirstOrDefault(x => x.Id == id);
        }

        internal void AddStudent(Student student)
        {
            Context.Student.Add(student);
            Context.SaveChanges();

        }

        internal void DeleteStudent(Guid id)
        {
            var student = Context.Student.FirstOrDefault(x => x.Id == id);
            Context.Student.Remove(student);
            Context.SaveChanges();
        }

        public List<Student> GetStudents() {
            return Context.Student.ToList();
        }
    }
}
