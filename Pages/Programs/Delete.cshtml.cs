using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentProgram.Data;
using SacramentProgram.Models;

namespace SacramentProgram
{
    public class DeleteModel : PageModel
    {
        private readonly SacramentProgram.Data.SacramentProgramContext _context;

        public DeleteModel(SacramentProgram.Data.SacramentProgramContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Program Program { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Program = await _context.Program.FirstOrDefaultAsync(m => m.ID == id);

            if (Program == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Program = await _context.Program.FindAsync(id);

            if (Program != null)
            {
                _context.Program.Remove(Program);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
