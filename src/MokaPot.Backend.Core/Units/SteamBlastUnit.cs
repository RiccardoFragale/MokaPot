using MokaPot.Backend.Core.Entities;
using MokaPot.Backend.Core.Services;

namespace MokaPot.Backend.Core.Units
{
    public class SteamBlastUnit : ISteamBlastUnit
    {
        public bool Execute(int blastSeconds, int waterMl)
        {
            var coffeeMachine = new CoffeeMachineEntity();
            coffeeMachine.GetWater(waterMl);
            coffeeMachine.SteamBlast(blastSeconds);

            bool isSuccessful = false;
            if (coffeeMachine.IsReadyForSteamBlast())
            {
                ICoffeeMachineService coffeeMachineService = new CoffeeMachineService();

                isSuccessful = coffeeMachineService.GetWater(coffeeMachine.WaterQty);
                isSuccessful = isSuccessful && coffeeMachineService.SteamBlast(blastSeconds);
            }

            return isSuccessful;
        }
    }
}
