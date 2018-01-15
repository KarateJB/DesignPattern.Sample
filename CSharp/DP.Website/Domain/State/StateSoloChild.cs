using System.Collections.Generic;
using DP.Website.Models;

namespace DP.Website.Domain.State
{
    public class StateSoloChild : State
    {
        public override void Action(HomeContext context)
        {
            context.Home.Children = new List<Child>{
                new Child(){Name="Ben Solo", Birthday="2123/5/4"}
            };

            //Set next state
            context.CurrentState = new StateSoloPet();
        }
    }
}