using Drakon.Lang.Primitives;
using NUnit.Framework;

namespace Drakon.Tests.Coding
{
    /// <summary>
    /// Code primitives testing here
    /// </summary>
    public class TestCodePrimitives
    {
        [SetUp]
        public void Setup()
        {
            // TODO: Add some global configurations and initializations here
        }

        [Test]
        public void TestActionDefaultCtor()
        {
            IActionPrimitive action = default;
            
            Assert.IsTrue(action.Name.Equals("Action") && action.IsArgsCorrect() && action.Result.Equals("void"));
        }
    }
}