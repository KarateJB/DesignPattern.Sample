using System.Collections.Generic;
using DP.Website.Models;

namespace DP.Website.Domain.State
{
    public class StateSkywalkerPet : State
    {
        public override void Action(HomeContext context)
        {
            context.Home.Pets = new List<Pet>{
                new Pet(){Name="Jar Jar Binks", PetType="Gungan"}    
            };

            //Set next state
            context.CurrentState = null;
        }
    }
}