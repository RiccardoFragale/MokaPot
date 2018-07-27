using MokaPot.Backend.Core.Entities;
using MokaPot.Backend.Core.Services;
using MokaPot.Frontend.Common;

namespace MokaPot.Backend.Core.Units
{
    public class SteamBlastUnit : ISteamBlastUnit
    {
        private CoffeeMachineEntity coffeeMachine;

        public SteamBlastUnit(CoffeeMachineEntity coffeeMachine)
        {
            this.coffeeMachine = coffeeMachine;
        }

        public UnitResult<CoffeeMachineEntity> Execute(int blastSeconds, int waterMl)
        {
            coffeeMachine.GetWater(waterMl);
            coffeeMachine.SteamBlast(blastSeconds);

            bool isSuccessful = false;
            if (coffeeMachine.IsReadyForSteamBlast())
            {
                ICoffeeMachineService coffeeMachineService = new CoffeeMachineService();

                isSuccessful = coffeeMachineService.GetWater(coffeeMachine.WaterQty);
                isSuccessful = isSuccessful && coffeeMachineService.SteamBlast(blastSeconds);
            }

            var operationResult = new UnitResult<CoffeeMachineEntity>
            {
                IsSuccessful = isSuccessful,
                Value = coffeeMachine
            };

            return operationResult;
        }
    }
}
