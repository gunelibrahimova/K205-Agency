using K205Agency.Models;

namespace K205Agency.ViewModel
{
    public class HomeVM
    {
        public Masthead Masthead { get; set; }
        public List<Service> Services { get; set; }
        public List<Team> Teams { get; set; }
        public List<Photo> Photos { get; set; }
    }
}
