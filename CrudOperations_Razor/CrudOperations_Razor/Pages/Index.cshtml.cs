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
    public class IndexModel : PageModel
    {
        private readonly CrudOperations_Razor.Data.StuContext _context;

        public IndexModel(CrudOperations_Razor.Data.StuContext context)
        {
            _context = context;
        }

        public IList<StudentRegistration> StudentRegistration { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.StudentRegistration != null)
            {
                StudentRegistration = await _context.StudentRegistration.ToListAsync();
            }
        }
    }
}
