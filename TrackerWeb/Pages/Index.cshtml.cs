using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrackerWeb.Data;
using TrackerWeb.Models;
namespace TrackerWeb.Pages;

public class IndexModel : PageModel
{
    private TrackerWebContext _context;

    public IndexModel(TrackerWebContext context)
    {
        _context = context;
    }

    public async void OnGet()
    {
        Issues = await _context.Issue.Where(i => i.Completed == null)
            .OrderByDescending(i => i.Created)
            .ToListAsync();
    }
    public IEnumerable<Issue> Issues { get; set; } = Enumerable.Empty<Issue>();
}

