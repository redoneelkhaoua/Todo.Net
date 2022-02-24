using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain
{
    public class ContextBase : DbContext
    {
        public DbSet<TodoCodeFirst> Todos { get; set; }
        public ContextBase(DbContextOptions options) : base(options)
        {
        }

        
    }
}
