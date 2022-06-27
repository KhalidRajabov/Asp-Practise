using System.Collections.Generic;

namespace Asp_Practise.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }
        public List<TeacherCategory> TeacherCategories { get; set; }
        public List<EventTeachers> EventtEachers { get; set; }
    }
}
