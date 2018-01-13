using System.Collections.Generic;

namespace DP.Website.Models
{
    public class Home
    {
        public string Address { get; set; }
        public List<Parent> Parents { get; set; }
        public List<Child> Children { get; set; }
        public List<Pet> Pets { get; set; }
    }
}