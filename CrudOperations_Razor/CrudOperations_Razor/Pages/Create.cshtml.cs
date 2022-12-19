using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CrudOperations_Razor.Data;
using CrudOperations_Razor.Models;

namespace CrudOperations_Razor.Pages
{
    public class CreateModel : PageModel
    {
        private readonly CrudOperations_Razor.Data.StuContext _context;

        public CreateModel(CrudOperations_Razor.Data.StuContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public StudentRegistration StudentRegistration { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.StudentRegistration.Add(StudentRegistration);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
