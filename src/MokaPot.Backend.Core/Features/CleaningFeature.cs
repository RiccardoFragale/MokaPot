using MokaPot.Backend.Core.Units;
using MokaPot.Frontend.Common;

namespace MokaPot.Backend.Core.Features
{
    public class CleaningFeature : ICleaningFeature
    {
        public bool Execute()
        {
            ISteamBlastUnit steamBlastUnit = new SteamBlastUnit();
            return steamBlastUnit.Execute(9, 100);
        }
    }
}