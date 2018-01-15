using System.Collections.Generic;
using DP.Website.Models;

namespace DP.Website.Domain
{
    public class Builder4Skywalker : Builder
    {
        public override Home Init()
        {
            return new Home
            {
                Address = "Naboo"
            };
        }
        public override void BuildParent(Home home)
        {
            home.Parents = new List<Parent>{
              new Parent() { Name = "Anakin Skywalker"},
              new Parent() { Name = "Princess Amidala"},

            };
        }

        public override void BuildChild(Home home)
        {
            home.Children = new List<Child>{
                new Child(){Name="Luke Skywalker", Birthday="2099/5/4"},
                new Child(){Name="Luke Skywalker", Birthday="2099/5/4"}
            };
        }

        public override void BuildPet(Home home)
        {
            home.Pets = new List<Pet>{
                new Pet(){Name="Jar Jar Binks", PetType="Gungan"}    
            };
        }
    }
}