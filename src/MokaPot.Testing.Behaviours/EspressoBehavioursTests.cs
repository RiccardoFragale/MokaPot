using MokaPot.Backend.Core.Entities;
using MokaPot.Backend.Core.Features;
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
    }
}
