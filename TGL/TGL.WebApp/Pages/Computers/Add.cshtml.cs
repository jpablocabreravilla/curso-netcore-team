using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TGL.WebApp.Data;
using TGL.WebApp.Models;

namespace TGL.WebApp.Pages.Computers
{

    public class AddModel : PageModel
    {
        public ComputerStore ComputerStore { get; set; }
        public AddModel(ComputerStore computerStore)
        {
            ComputerStore = computerStore;
        }

        [BindProperty]
        public Computer  Computer { get; set; }
        [BindProperty]
        public Guid Studentid { get; set; }

        public void OnGet(Guid studentid)
        {
            Studentid = studentid;

        }

        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //Add
            Computer.StudentId = Studentid;
            ComputerStore.AddComputer(Computer);
            return RedirectToPage("./Index");
        }
    }
}

