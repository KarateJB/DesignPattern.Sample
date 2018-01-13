using System.ComponentModel;

namespace DP.Website.Models
{
    public class Child
    {
        public string Id { get; set; }

        [DisplayName("小孩姓名")]
        public string Name {get;set;}

        [DisplayName("生日")]
        public string Birthday { get; set; }
    }
}