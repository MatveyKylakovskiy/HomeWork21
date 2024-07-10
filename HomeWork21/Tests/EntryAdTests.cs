using HomeWork21.Pages.InternetHerokuapp;

namespace HomeWork21.Tests
{
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
            BasePage.EntryAdClick();
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
