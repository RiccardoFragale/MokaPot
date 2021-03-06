using MokaPot.Backend.Core.Entities;
using MokaPot.Frontend.Common;

namespace MokaPot.Backend.Core.Units
{
    public interface ISteamBlastUnit
    {
        UnitResult<CoffeeMachineEntity> Execute(int blastSeconds, int waterMl);
    }
}