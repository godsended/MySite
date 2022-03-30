using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySite.Data;
using MySite.Models;

namespace MySite.Pages.Visitors;

public class VisitorsPageModel : PageModel
{
    private readonly VisitorsDbContext database;

    public IEnumerable<Visitor> Visitors = null!;

    public VisitorsPageModel(VisitorsDbContext database)
    {
        this.database = database;
    }

    public void OnGet()
    {
        if(database.Visitors!=null)
            Visitors = database.Visitors;
    }

    public IActionResult OnGetDelete()
    {
        database?.Visitors?.RemoveRange(database.Visitors);
        database?.SaveChangesAsync();

        return RedirectToPage("/Visitors/Index");
    }
}