using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TrackerWeb.Data;
using TrackerWeb.Models;

namespace TrackerWeb.Pages.Issues
{
    public class DeleteModel : PageModel
    {
        private readonly TrackerWeb.Data.TrackerWebContext _context;

        public DeleteModel(TrackerWeb.Data.TrackerWebContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Issue Issue { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(uint? id)
        {
            if (id == null || _context.Issue == null)
            {
                return NotFound();
            }

            var issue = await _context.Issue.FirstOrDefaultAsync(m => m.Id == id);

            if (issue == null)
            {
                return NotFound();
            }
            else 
            {
                Issue = issue;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(uint? id)
        {
            if (id == null || _context.Issue == null)
            {
                return NotFound();
            }
            var issue = await _context.Issue.FindAsync(id);

            if (issue != null)
            {
                Issue = issue;
                _context.Issue.Remove(Issue);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
