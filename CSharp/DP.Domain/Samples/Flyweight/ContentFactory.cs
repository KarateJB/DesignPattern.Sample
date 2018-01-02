using System.Collections.Generic;

namespace DP.Domain.Samples.Flyweight
{
    public class Content
    {
        public string Id { get; set; }
        public string Value { get; set; }
    }

    public class ContentFactory
    {
        public static List<Content> CreateTeam()
        {
            return new List<Content>(){
                new Content{ Id="Company name", Value="The Force"},
                new Content{ Id="Company phone", Value="02 XXXX XXX"},
                new Content{ Id="Company address", Value="Taipei, Taiwan"}
            };
        }
        public static List<Content> CreateCrews()
        {
            return new List<Content>(){
                new Content{ Id="Product Owner", Value="Amy"},
                new Content{ Id="Scrum master", Value="JB"},
                new Content{ Id="Principle developer", Value="Lily"},
                new Content{ Id="Senior developer", Value="Hachi"}
            };
        }

        public static List<Content> CreateProducts()
        {
            return new List<Content>(){
                new Content{ Id="1", Value="樂透iThome AI智能服務應用大賽 (2017)"},
                new Content{ Id="2", Value="iT邦幫忙鐵人賽完賽-Learning ASP.NET core + Angular2 (2017)"}
            };
        }
    }

    
}