using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Lissen_2
{
    internal class AppCont:DbContext
    {
        public DbSet<User> Users { get; set; }


        public AppCont() : base("C:\\Users\\KDFX Team\\Desktop\\Программирование\\BD\\lissen_2.db") { }
    }
}
