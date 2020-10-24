using Drakon.App.ViewModels.Base;

using System;
using System.Collections.Generic;
using System.Text;

using Xunit;

namespace Tests.Drakon.App.ViewModels
{
    public class TestsDelegateCommand
    {
        [Fact]
        public void TestConstructorWithNullArg()
        {
            Assert.Throws<ArgumentNullException>(() => new DelegateCommand(null));
        }
        
        [Fact]
        public void TestExecuting()
        {
            var executed = false;
            var newDelegateCommand = new DelegateCommand(p => executed = true);
            newDelegateCommand.Execute(null);

            Assert.True(executed);
        }
    }
}
