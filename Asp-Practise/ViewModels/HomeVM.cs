using Asp_Practise.Models;
using System.Collections.Generic;

namespace Asp_Practise.ViewModels
{
    public class HomeVM
    {
        public List<Sliders> Slider { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
        public List<NoticeSubject> NoticeSubjects { get; set; }
        public Banner Banners { get; set; }
        public Quotes Quote { get; set; }
        public List<Course> Courses { get; set; }
    }
}
