using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTrabajoFinal2021.Models;

namespace WebApiTrabajoFinal2021.Models
{
    public class DBAutoContext: DbContext
    {
        public DBAutoContext() {}
        public DBAutoContext(DbContextOptions<DBAutoContext> options): base(options)
        {

        }

        public virtual DbSet<Auto> Autos { get; set; }
    }
}
