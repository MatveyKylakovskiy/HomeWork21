using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace HomeWork21.Pages.InternetHerokuapp
{
    internal class BasePage
    {
        private static WebElements JavaScriptAlertsLink = new(By.XPath("//a[@href='/javascript_alerts']"));
        private static WebElements FramesLink = new(By.XPath("//*[text()='Nested Frames']"));
        private static WebElements EntryAdlink = new(By.XPath("//*[text()='Entry Ad']"));

        public static void JavaScriptAlertsClick() => JavaScriptAlertsLink.Click();

        public static void FramesClick() => FramesLink.Click();

        public static void EntryAdClick() => EntryAdlink.Click();
    }
}
