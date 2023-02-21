using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TrackerWeb.Data;
using TrackerWeb.Models;

namespace TrackerWeb.Pages.Issues
{
    public class CreateModel : PageModel
    {
        private readonly TrackerWeb.Data.TrackerWebContext _context;

        public CreateModel(TrackerWeb.Data.TrackerWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Issue Issue { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Issue == null || Issue == null)
            {
                return Page();
            }


            Issue.Created = DateTime.Now.ToString("dddd, dd MMMM yyyy", new CultureInfo("en-US"));
            _context.Issue.Add(Issue);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
