using MokaPot.Backend.Core.Entities;
using MokaPot.Backend.Core.Features;
using MokaPot.Backend.Core.Units;
using MokaPot.Frontend.Common;
using NUnit.Framework;

namespace MokaPot.Testing.Behaviours
{
    [TestFixture]
    public class CleanBehavioursTests
    {
        [Test]
        public void CleanFeatureShouldReturnTrueWhenValidInput()
        {
            var cleaningFeature = new CleaningFeature();
            var result = cleaningFeature.Execute();

            Assert.IsTrue(result);
        }

        [TestCase(1, 50)]
        [TestCase(9, 50)]
        public void CleanFeatureShouldReturnTrueWhenValidInput(int blastSeconds, int waterMl)
        {
            var cleaningUnit = new SteamBlastUnit(new CoffeeMachineEntity());
            UnitResult<CoffeeMachineEntity> result = cleaningUnit.Execute(blastSeconds, waterMl);

            Assert.IsTrue(result.IsSuccessful);

        }

        [TestCase(5, 101)]
        [TestCase(15, 50)]
        public void CleanFeatureShouldReturnFalseWhenInvalidInput(int seconds, int waterMl)
        {
            var cleaningUnit = new SteamBlastUnit(new CoffeeMachineEntity());
            UnitResult<CoffeeMachineEntity> result = cleaningUnit.Execute(seconds, waterMl);

            Assert.IsFalse(result.IsSuccessful);
        }
    }
}
