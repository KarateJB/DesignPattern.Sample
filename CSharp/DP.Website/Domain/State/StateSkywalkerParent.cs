using System.Collections.Generic;
using DP.Website.Models;

namespace DP.Website.Domain.State
{
    public class StateSkywalkerParent : State
    {
        public override void Action(HomeContext context)
        {
             context.Home.Parents = new List<Parent>{
              new Parent() { Name = "Anakin Skywalker"},
              new Parent() { Name = "Princess Amidala"},
            };

            //Set next state
            context.CurrentState = new StateSkywalkerChild();
        }
    }
}