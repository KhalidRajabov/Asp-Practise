using System;
using System.Collections.Generic;

namespace Asp_Practise.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Venue { get; set; }
        public string ImageUrl { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public DateTime StartTime { get; set; }
        public string Info3 { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Teacher Teacher { get; set; }
        public List<EventTeachers> EventTeachers { get; set; }
    }
}