using System.Collections.Generic;

namespace Asp_Practise.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TeacherCategory> TeacherCategories{ get; set; }
        public Event Events { get; set; }
        public Course Course { get; set; }
    }
}
