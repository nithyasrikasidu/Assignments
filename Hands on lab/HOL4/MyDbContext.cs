using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Hands_on_lab3.Models
{
    public class MyDbContext : DbContext
    {



        public MyDbContext()
                    : base("name=conn")
        {

        }
        public DbSet<Users> Users
        {
            get; set;
        }

    }
}