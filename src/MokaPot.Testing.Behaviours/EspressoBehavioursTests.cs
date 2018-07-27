using MokaPot.Backend.Core.Entities;
using MokaPot.Backend.Core.Features;
using MokaPot.Backend.Core.Units;
using MokaPot.Frontend.Common;
using NUnit.Framework;

namespace MokaPot.Testing.Behaviours
{
    [TestFixture]
    public class EspressoBehavioursTests
    {
        [Test]
        public void EspressoFeatureShouldReturnTrue()
        {
            var espressoFeature = new EspressoFeature();
            var result = espressoFeature.Execute();

            Assert.IsTrue(result);
        }

        [TestCase(6, 50)]
        [TestCase(8, 60)]
        public void EspressoUnitShouldReturnTrueWhenValidInputAndCleanMachine(int coffeeGrams, int waterMl)
        {
            var espressoUnit = new EspressoUnit(new CoffeeMachineEntity());
            UnitResult<CoffeeMachineEntity> result = espressoUnit.Execute(coffeeGrams, waterMl);

            Assert.IsTrue(result.IsSuccessful);
        }

        [TestCase(20, 50)]
        [TestCase(8, 200)]
        public void EspressoUnitShouldReturnFalseWhenInvalidInput(int coffeeGrams, int waterMl)
        {
            var espressoUnit = new EspressoUnit(new CoffeeMachineEntity());
            var result = espressoUnit.Execute(coffeeGrams, waterMl);

            Assert.IsFalse(result.IsSuccessful);
        }
    }
}
