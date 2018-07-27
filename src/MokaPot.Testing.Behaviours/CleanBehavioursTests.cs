using MokaPot.Backend.Core.Features;
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
    }
}
