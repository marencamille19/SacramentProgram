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
    public class DetailsModel : PageModel
    {
        private readonly SacramentProgram.Data.SacramentProgramContext _context;

        public DetailsModel(SacramentProgram.Data.SacramentProgramContext context)
        {
            _context = context;
        }

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
    }
}
