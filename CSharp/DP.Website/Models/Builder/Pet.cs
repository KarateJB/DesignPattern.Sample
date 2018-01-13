using System.ComponentModel;

namespace DP.Website.Models
{
    public class Pet
    {
        public string Id { get; set; }

        [DisplayName("名字")] 
        public string Name { get; set; }

        [DisplayName("寵物")]
        public string PetType { get; set; }
    }
}