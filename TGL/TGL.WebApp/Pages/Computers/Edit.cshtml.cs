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
    public class EditModel : PageModel
    {
        public ComputerStore ComputerStore { get; set; }
        public EditModel(ComputerStore computerStore)
        {
            ComputerStore = computerStore;
        }
        [BindProperty]
        public Computer Computer { get; set; }

        public void OnGet(Guid id)
        {
            Computer = ComputerStore.GetComputerById(id);
        }
        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //Edit
            ComputerStore.EditComputer(Computer);
            return RedirectToPage("./Index");
        }

    }
}

