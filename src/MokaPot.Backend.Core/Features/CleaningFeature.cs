using MokaPot.Backend.Core.Entities;
using MokaPot.Backend.Core.Units;
using MokaPot.Frontend.Common;

namespace MokaPot.Backend.Core.Features
{
    public class CleaningFeature : ICleaningFeature
    {
        public bool Execute()
        {
            ISteamBlastUnit steamBlastUnit = new SteamBlastUnit(new CoffeeMachineEntity());
            return steamBlastUnit.Execute(9, 100).IsSuccessful;
        }
    }
}