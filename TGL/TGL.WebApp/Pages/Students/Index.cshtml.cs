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
    public class IndexModel : PageModel
    {
        public StudentStore StudentStore { get; set; }
        public List<Student> Students { get; set; }
        public IndexModel(StudentStore studentStore, ComputerStore computerStore)
        {
            StudentStore = studentStore;
            Students = StudentStore.GetStudents();
        }

        public IActionResult OnPostDelete(Guid id)
        {
            StudentStore.DeleteStudent(id);
            return RedirectToPage();
        }

        public void OnGet()
        {
        }
    }
}
