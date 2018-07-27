using MokaPot.Backend.Core.Entities;
using MokaPot.Backend.Core.Units;
using MokaPot.Frontend.Common;

namespace MokaPot.Backend.Core.Features
{
    public class EspressoFeature : IEspressoFeature
    {
        public bool Execute()
        {
            var entity = new CoffeeMachineEntity();

            ISteamBlastUnit cleaningUnit = new SteamBlastUnit(entity);
            UnitResult<CoffeeMachineEntity> operationResult = cleaningUnit.Execute(9, 50);

            IEspressoUnit espressoUnit = new EspressoUnit(operationResult.Value);
            operationResult = espressoUnit.Execute(6, 50);

            bool isSuccessful = operationResult.IsSuccessful && operationResult.IsSuccessful;

            return isSuccessful;
        }
    }
}