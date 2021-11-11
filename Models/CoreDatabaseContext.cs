using FriendApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FriendApplication.Data
{
    public class CoreDatabaseContext: DbContext
    {
        public CoreDatabaseContext(DbContextOptions<CoreDatabaseContext> options)
            : base(options)
        {
        }
        public DbSet<frd_create> frd_create{ get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=LAPTOP-14NO1BO3\\SQLEX`9ol.PRESS;DataBase=CoreDatabase;Integrated Security=True");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
