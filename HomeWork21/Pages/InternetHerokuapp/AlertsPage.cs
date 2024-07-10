using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace HomeWork21.Pages.InternetHerokuapp
{
    internal class AlertsPage
    {
        private static WebElements _jSAlertButton() => new(By.XPath("//button[@onclick='jsAlert()']"));
        private static WebElements _jSConfirmButton() => new(By.XPath("//button[@onclick='jsConfirm()']"));
        private static WebElements _jSPromptButton() => new(By.XPath("//button[@onclick='jsPrompt()']"));
        private static WebElements _resultMessage() => new(By.XPath("//p[@id='result']"));

        public static void AlertButtonClick() => _jSAlertButton().Click();

        public static void ConfirmButonClick() => _jSConfirmButton().Click();

        public static void PromtButtonClick() => _jSPromptButton().Click();

        public static void AcceptAlert() => WebElements.AcceptAlert();

        public static void DissmisAlert() => WebElements.DismissAlert();

        public static string GetAlertText() => WebElements.GetAlertText();

        public static void SendTextToAlert(string text) => WebElements.SendTextToAlert(text);

        public static string GetResultMessage() => _resultMessage().GetText();
    }
}
