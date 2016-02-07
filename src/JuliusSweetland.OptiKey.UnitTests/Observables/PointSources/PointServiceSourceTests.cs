using JuliusSweetland.OptiKey.Enums;
using JuliusSweetland.OptiKey.Observables.PointSources;
using JuliusSweetland.OptiKey.Services;
using Moq;
using NUnit.Framework;
using System;

namespace JuliusSweetland.OptiKey.UnitTests.Observables.PointSources
{
    [TestFixture]
    public class PointServiceSourceTests
    {
        [Test]
        public void IsStateRunningAfterCreate()
        {
            var pointTtl = new TimeSpan();
            var mockPointGeneratingService = new Mock<IPointService>();

            var pointServicePoint = new PointServiceSource(pointTtl, mockPointGeneratingService.Object);

            Assert.AreEqual(pointServicePoint.State, RunningStates.Running);
        }

        [Test]
        public void IsSequenceSettedAfterCreate()
        {
            var pointTtl = new TimeSpan();
            var mockPointGeneratingService = new Mock<IPointService>();

            var pointServicePoint = new PointServiceSource(pointTtl, mockPointGeneratingService.Object);

            Assert.IsNotNull(pointServicePoint.Sequence);
        }
    }
}
