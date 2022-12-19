using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrudOperations_Razor.Data;
using CrudOperations_Razor.Models;

namespace CrudOperations_Razor.Pages
{
    public class EditModel : PageModel
    {
        private readonly CrudOperations_Razor.Data.StuContext _context;

        public EditModel(CrudOperations_Razor.Data.StuContext context)
        {
            _context = context;
        }

        [BindProperty]
        public StudentRegistration StudentRegistration { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.StudentRegistration == null)
            {
                return NotFound();
            }

            var studentregistration =  await _context.StudentRegistration.FirstOrDefaultAsync(m => m.Stuid == id);
            if (studentregistration == null)
            {
                return NotFound();
            }
            StudentRegistration = studentregistration;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(StudentRegistration).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentRegistrationExists(StudentRegistration.Stuid))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StudentRegistrationExists(int id)
        {
          return _context.StudentRegistration.Any(e => e.Stuid == id);
        }
    }
}
