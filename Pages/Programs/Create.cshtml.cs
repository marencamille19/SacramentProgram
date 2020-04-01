using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SacramentProgram.Data;
using SacramentProgram.Models;

namespace SacramentProgram
{
    public class CreateModel : PageModel
    {
        private readonly SacramentProgram.Data.SacramentProgramContext _context;

        public CreateModel(SacramentProgram.Data.SacramentProgramContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Program Program { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Program.Add(Program);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
