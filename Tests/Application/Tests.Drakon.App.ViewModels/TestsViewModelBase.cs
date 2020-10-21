using System;

using Tests.Drakon.App.ViewModels.Common;

using Xunit;

namespace Tests.Drakon.App.ViewModels
{
    public class TestsViewModelBase
    {
        [Fact]
        public void TestUpdateValidProperty()
        {
            var itWorks = false;
            var sampleViewModelBase = new SampleViewModelBase();
            sampleViewModelBase.Name = "test";
            sampleViewModelBase.PropertyChanged += (s, args) => itWorks = true;
            sampleViewModelBase.Name = "blablabla";

            Assert.True(itWorks);
        }

        [Fact]
        public void TestUpdateNullProperty()
        {
            var itWorks = false;
            var sampleViewModelBase = new SampleViewModelBase();
            sampleViewModelBase.Name = null;
            sampleViewModelBase.PropertyChanged += (s, args) => itWorks = true;
            sampleViewModelBase.Name = "blablabla";

            Assert.True(itWorks);
        }

        [Fact]
        public void TestUpdatePropertyByEqualValues()
        {
            var itWorks = false;
            var sampleViewModelBase = new SampleViewModelBase();
            sampleViewModelBase.Name = "blablabla";
            sampleViewModelBase.PropertyChanged += (s, args) => itWorks = true;
            sampleViewModelBase.Name = "blablabla";

            Assert.False(itWorks);
        }
    }
}
