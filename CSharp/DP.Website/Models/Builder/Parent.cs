using System.ComponentModel;


namespace DP.Website.Models
{
    public class Parent
    {
        public string Id { get; set; }

        [DisplayName("父母姓名")]
        public string Name { get; set; }
    }
}