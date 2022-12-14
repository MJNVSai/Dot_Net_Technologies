using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudOperations_Razor.Data;
using CrudOperations_Razor.Models;

namespace CrudOperations_Razor.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly CrudOperations_Razor.Data.StuContext _context;

        public DeleteModel(CrudOperations_Razor.Data.StuContext context)
        {
            _context = context;
        }

        [BindProperty]
      public StudentRegistration StudentRegistration { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.StudentRegistration == null)
            {
                return NotFound();
            }

            var studentregistration = await _context.StudentRegistration.FirstOrDefaultAsync(m => m.Stuid == id);

            if (studentregistration == null)
            {
                return NotFound();
            }
            else 
            {
                StudentRegistration = studentregistration;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.StudentRegistration == null)
            {
                return NotFound();
            }
            var studentregistration = await _context.StudentRegistration.FindAsync(id);

            if (studentregistration != null)
            {
                StudentRegistration = studentregistration;
                _context.StudentRegistration.Remove(StudentRegistration);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
