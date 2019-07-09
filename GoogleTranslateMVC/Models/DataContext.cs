using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoogleTranslateMVC.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=mySqlConnection")
        {
        }
        public DbSet<Translate> Translate { get; set; }

    }
}