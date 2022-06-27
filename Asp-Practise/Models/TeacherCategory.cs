namespace Asp_Practise.Models
{
    public class TeacherCategory
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int CategoryId { get; set; }
        public Category Categories { get; set; }
        public Teacher Teachers { get; set; }
    }
}
