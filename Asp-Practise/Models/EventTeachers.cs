namespace Asp_Practise.Models
{
    public class EventTeachers
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int TeacherId { get; set; }
        public Event Events { get; set; }
        public Teacher Teacher { get; set; }
    }
}
