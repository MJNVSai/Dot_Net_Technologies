using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudOperations_Razor.Models;

namespace CrudOperations_Razor.Data
{
    public class StuContext : DbContext
    {
        public StuContext (DbContextOptions<StuContext> options)
            : base(options)
        {
        }

        public DbSet<CrudOperations_Razor.Models.StudentRegistration> StudentRegistration { get; set; } = default!;
    }
}
