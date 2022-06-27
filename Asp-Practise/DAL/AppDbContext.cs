using Asp_Practise.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Asp_Practise.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Sliders> Slider { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
        public DbSet<NoticeSubject> NoticeSubjects { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Quotes> Quote { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<TeacherCategory> TeacherCategories { get; set; }
        public DbSet<Teacher> Teachers { get; internal set; }
        public DbSet<Course> Courses { get; set; }
    }
}

