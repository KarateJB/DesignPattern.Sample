using System.Collections.Generic;
using DP.Website.Models;

namespace DP.Website.Domain
{
    public class Builder4Solo : Builder
    {
        public override Home Init()
        {
            return new Home
            {
                Address = "Milian falcon"
            };
        }
        public override void BuildParent(Home home)
        {
            home.Parents = new List<Parent>{
              new Parent() { Name = "Han Solo"},
              new Parent() { Name = "Leia Skywalker"},

            };
        }

        public override void BuildChild(Home home)
        {
            home.Children = new List<Child>{
                new Child(){Name="Ben Solo", Birthday="2123/5/4"}
            };
        }

        public override void BuildPet(Home home)
        { 
            //Not a good idea of putting Chewbacca here...
        }
    }
}