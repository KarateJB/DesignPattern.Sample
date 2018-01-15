using System.Collections.Generic;
using DP.Website.Models;

namespace DP.Website.Domain.State
{
    public class StateSkywalkerChild : State
    {
        public override void Action(HomeContext context)
        {
            context.Home.Children = new List<Child>{
                new Child(){Name="Luke Skywalker", Birthday="2099/5/4"},
                new Child(){Name="Luke Skywalker", Birthday="2099/5/4"}
            };

            //Set next state
            context.CurrentState = new StateSkywalkerPet();
        }
    }
}