using Market.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.DataLayer.Context
{
    public class ApplicationContext:DbContext
    {
        #region Constractor
        public ApplicationContext(DbContextOptions<ApplicationContext>options):base(options)
        {

        }
        #endregion

        public DbSet<MainSlader> MainSladers { get; set; }
    }
}
