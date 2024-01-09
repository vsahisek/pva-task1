using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Feedback;

namespace Feedback.Pages
{
    public class FeedbackModel : PageModel
    {
        private readonly Feedback.CreditsDbContext _context;

        public FeedbackModel(Feedback.CreditsDbContext context)
        {
            _context = context;
            Credits = new Credits();
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Credits Credits { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Credits.Add(Credits);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
