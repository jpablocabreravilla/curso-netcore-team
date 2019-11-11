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
    public class IndexModel : PageModel
    {
        public ComputerStore ComputerStore { get; set; }
        public List<Computer> Computers { get; set; }
        [BindProperty]
        public Guid Studentid { get; set; }

        public void OnGet(Guid studentid)
        {
            Studentid = studentid;

        }
        public IndexModel(ComputerStore computerStore)
        {
            ComputerStore = computerStore;
            Computers = ComputerStore.GetComputers();
        }

        public IActionResult OnPostDelete(Guid id) {
            ComputerStore.DeleteComputer(id);
            return RedirectToPage();
        }

    }
}
