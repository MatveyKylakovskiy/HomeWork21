using HomeWork21.Pages.InternetHerokuapp;
using PageObjectLib.Factories;

namespace HomeWork21.Tests
{
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    internal class EntryAdTests : BaseTest
    {
        [TestCase(true)]
        [TestCase(true)]
        [TestCase(true)]
        [TestCase(true)]
        [TestCase(true)]
        [TestCase(true)]
        public void AdTest(bool expected)
        {
            // BasePage.EntryAdClick();
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/entry_ad");
            EntryAdPage.CloseModalWindow();
            EntryAdPage.RestartAd();

            var result1 = EntryAdPage.IsAdVisible();
            Assert.That(result1, Is.EqualTo(expected));

            EntryAdPage.CloseModalWindow();

            var result2 = EntryAdPage.CheckElement();
            Assert.That(result2, Is.EqualTo(expected));
        }
    }
}
