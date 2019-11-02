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
    public class AddModel : PageModel

    {
        public StudentStore StudentStore { get; set; }
        public AddModel(StudentStore studentStore)
        {
            StudentStore = studentStore;
        }

        [BindProperty]
        public Student Student { get; set; }
        
        public IActionResult OnPostAsync(){
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //Add
            StudentStore.AddStudent(Student);
            return RedirectToPage("./Index");
        }
        public void OnGet()
        {
        }

    }
}