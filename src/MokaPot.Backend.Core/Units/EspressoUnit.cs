using MokaPot.Backend.Core.Entities;
using MokaPot.Backend.Core.Services;
using MokaPot.Frontend.Common;

namespace MokaPot.Backend.Core.Units
{
    public class EspressoUnit : IEspressoUnit
    {
        private CoffeeMachineEntity coffeeMachine;

        public EspressoUnit(CoffeeMachineEntity coffeeMachine)
        {
            this.coffeeMachine = coffeeMachine;
        }

        public UnitResult<CoffeeMachineEntity> Execute(int coffeeGrams, int waterMl)
        {
            if (coffeeMachine.IsClean)
            {
                coffeeMachine.SetCoffee(coffeeGrams);
                coffeeMachine.GetWater(waterMl);
            }

            bool ranSuccessfully = false;
            if (coffeeMachine.IsReadyForEspresso())
            {
                ICoffeeMachineService coffeeMachineService = new CoffeeMachineService();    //external service
                ranSuccessfully = coffeeMachineService.SetCoffee(coffeeMachine.CoffeeQty);
                ranSuccessfully = ranSuccessfully && coffeeMachineService.GetWater(coffeeMachine.WaterQty);
                ranSuccessfully = ranSuccessfully && coffeeMachineService.Run();
            }

            UnitResult<CoffeeMachineEntity> operationResult = new UnitResult<CoffeeMachineEntity>
            {
                IsSuccessful = ranSuccessfully,
                Value = coffeeMachine
            };

            return operationResult;
        }
    }
}