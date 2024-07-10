using Allure.Commons;
using PageObjectLib.Factories;

namespace HomeWork21.Tests
{
    [TestFixture]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    
    internal class BaseTest
    {

        [SetUp]
        public void SetUp()
        {
            Driver.GoUrl("https://the-internet.herokuapp.com/");
            
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
