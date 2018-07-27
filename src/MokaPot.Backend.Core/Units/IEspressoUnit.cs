using MokaPot.Backend.Core.Entities;
using MokaPot.Frontend.Common;

namespace MokaPot.Backend.Core.Units
{
    public interface IEspressoUnit
    {
        UnitResult<CoffeeMachineEntity> Execute(int coffeeGrams, int waterMl);
    }
}