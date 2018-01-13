using System.Collections.Generic;

namespace DP.Website.Models
{
    public class Home
    {
        public Parent Father { get; set; }
        public Parent Mother { get; set; }
        public List<Child> Children { get; set; }
        public List<Pet> Pets { get; set; }
    }
}