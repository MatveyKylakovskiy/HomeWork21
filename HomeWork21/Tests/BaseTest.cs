using PageObjectLib.Factories;

namespace HomeWork21.Tests
{
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
