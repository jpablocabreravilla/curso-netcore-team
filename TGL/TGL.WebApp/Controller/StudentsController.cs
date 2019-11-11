using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TGL.WebApp.Data;
using TGL.WebApp.Models;

namespace TGL.WebApp.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public StudentStore StudentStore { get; set; }
        public StudentsController(StudentStore studentStore)
        {
            StudentStore = studentStore;
        }
        // GET: api/Students
        [HttpGet]
        public IActionResult Get()
        {
            var students = StudentStore.GetStudents();
            return Ok(students);
        }

        // GET: api/Students/5
        [HttpGet("{id}", Name = "Get")]

        public IActionResult Get(Guid id)
        {
            var student = StudentStore.GetStudentById(id);
            return Ok(student);
        }

        // POST: api/Students
        [HttpPost]

        public IActionResult Post([FromBody] Student student)
        {
            StudentStore.AddStudent(student);
            return Ok();
        }

        // PUT: api/Students/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Student student)
        {
            student.Id = id;
            StudentStore.EditStudent(student);
            return Ok();
        }

        /// <summary>
        /// Metodo para eliminar un estudiante por el identificador (id)
        /// </summary>
        /// <param name="id">Identificador del estudiante</param>
        /// <returns>Retorna Ok si fue eliminado</returns>
        /// 

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            StudentStore.DeleteStudent(id);
            return Ok();
        }
    }
}
