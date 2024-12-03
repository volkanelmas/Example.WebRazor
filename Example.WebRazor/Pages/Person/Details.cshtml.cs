using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Example.WebRazor.Pages.Person
{
    public class DetailsModel : PageModel
    {
        private readonly Example.WebRazor.Models.MyDbContext _context;

        public DetailsModel(Example.WebRazor.Models.MyDbContext context)
        {
            _context = context;
        }

        public Models.Person Person { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Persons.FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }
            else
            {
                Person = person;
            }
            return Page();
        }
    }
}
