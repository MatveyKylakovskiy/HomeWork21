using OpenQA.Selenium;
using PageObjectLib.Elements;
using PageObjectLib.Factories;
using SeleniumExtras.WaitHelpers;

namespace HomeWork21.Pages.InternetHerokuapp
{
    internal class EntryAdPage
    {
        private static WebElements modalContainer = new(By.XPath("//div[@id='modal']"));
        private static WebElements closeButton = new(By.XPath("//*[text()='Close']"));
        private static WebElements clickHereButton = new(By.Id("restart-ad"));
        private static WebElements checkElement = new(By.XPath("//*[text()='Elemental Selenium']"));

        public static bool IsAdVisible() => Driver.GetWaitByTime(TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@id='modal']"))).Displayed;

        public static void CloseModalWindow()
        {
            var modal = Driver.GetWait().Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@id='modal']")));

            modal.FindElement(By.XPath("//*[text()='Close']")).Click();
        }

        public static void RestartAd() => clickHereButton.Click();

        public static bool CheckElement()
        {
            try
            {
                Driver.GetWaitByTime(TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[text()='Elemental Selenium']")));
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
