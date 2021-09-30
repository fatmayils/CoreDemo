using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string tanımlaması yaptık
            optionsBuilder.UseSqlServer("server=DESKTOP-7GT6TBF\\SQLEXPRESS;database=CoreBlogDb;integrated security=true;");
        }
        public DbSet<AboutDal> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogDal> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
