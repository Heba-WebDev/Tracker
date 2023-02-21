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
    public class IndexModel : PageModel
    {
        private readonly TrackerWeb.Data.TrackerWebContext _context;

        public IndexModel(TrackerWeb.Data.TrackerWebContext context)
        {
            _context = context;
        }

        public IList<Issue> Issue { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Issue != null)
            {
                Issue = await _context.Issue.ToListAsync();
            }
        }
    }
}
