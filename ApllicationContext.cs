using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace WpfApp1
{
    class ApllicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApllicationContext() : base("DefaultConnection") { }

    }
}
