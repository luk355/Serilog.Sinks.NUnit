using NUnit.Framework;

namespace Serilog.Sinks.NUnit.Sample
{
    [TestFixture]
    public class TestClass
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.NUnitOutput()
                .CreateLogger();
        }

        [Test]
        public void DotNetFrameworkSampleTest()
        {
            Log.Error("Error from .netFramework sample project!");
        }
    }
}
