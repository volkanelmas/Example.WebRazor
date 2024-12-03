using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Example.WebRazor.Pages.Person
{
    public class IndexModel : PageModel
    {
        private readonly Example.WebRazor.Models.MyDbContext _context;

        public IndexModel(Example.WebRazor.Models.MyDbContext context)
        {
            _context = context;
        }

        public IList<Models.Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
