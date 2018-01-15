using System.Collections.Generic;
using DP.Website.Models;

namespace DP.Website.Domain.State
{
    public class StateSoloParent : State
    {
        public override void Action(HomeContext context)
        {
            context.Home.Parents = new List<Parent>{
              new Parent() { Name = "Han Solo"},
              new Parent() { Name = "Leia Skywalker"},

            };

            //Set next state
            context.CurrentState = new StateSoloChild();
        }
    }
}