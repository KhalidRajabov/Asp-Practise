using System.Collections.Generic;

namespace Asp_Practise.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }
        public string AboutMe { get; set; }
        public string Degree { get; set; }
        public string Experience { get; set; }
        public string Hobbies { get; set; }
        public string Faculty { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Skype { get; set; }
        public List<TeacherCategory> TeacherCategories { get; set; }
        public List<EventTeachers> EventtEachers { get; set; }
    }
}
