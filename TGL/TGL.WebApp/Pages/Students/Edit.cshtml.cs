using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TGL.WebApp.Data;
using TGL.WebApp.Models;

namespace TGL.WebApp.Pages.Students
{
    public class EditModel : PageModel
    {
        public StudentStore StudentStore { get; set; }
        public EditModel(StudentStore studentStore)
        {
            StudentStore = studentStore;
        }

        [BindProperty]
        public Student Student { get; set; }
        public void OnGet(Guid id) //aqui recibe el que envio en route
        {
            Student = StudentStore.GetStudentById(id);
        }

        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //Edit
            StudentStore.EditStudent(Student);
            return RedirectToPage("./Index");
        }
    }
}