using HomeWork21.Pages.InternetHerokuapp;

namespace HomeWork21.Tests
{
    internal class AlertsTests : BaseTest
    {
        [TestCase("I am a JS Alert", "You successfully clicked an alert")]
        public void JsAlertTest(string expected1, string expected2)
        {
            BasePage.JavaScriptAlertsClick();

            AlertsPage.AlertButtonClick();
            var result1 = AlertsPage.GetAlertText();

            Assert.That(result1, Is.EqualTo(expected1));

            AlertsPage.AcceptAlert();
            var result2 = AlertsPage.GetResultMessage();

            Assert.That(result2, Is.EqualTo(expected2));
        }

        [TestCase("I am a JS Confirm", "You clicked: Ok")]
        public void JsConfirmAcceptTest(string expected1, string expected2)
        {
            BasePage.JavaScriptAlertsClick();

            AlertsPage.ConfirmButonClick();
            var result1 = AlertsPage.GetAlertText();

            Assert.That(result1, Is.EqualTo(expected1));

            AlertsPage.AcceptAlert();
            var result2 = AlertsPage.GetResultMessage();

            Assert.That(result2, Is.EqualTo(expected2));
        }

        [TestCase("I am a JS Confirm", "You clicked: Cancel")]
        public void JsConfirmDissmisTest(string expected1, string expected2)
        {
            BasePage.JavaScriptAlertsClick();

            AlertsPage.ConfirmButonClick();
            var result1 = AlertsPage.GetAlertText();

            Assert.That(result1, Is.EqualTo(expected1));

            AlertsPage.DissmisAlert();
            var result2 = AlertsPage.GetResultMessage();

            Assert.That(result2, Is.EqualTo(expected2));
        }

        [TestCase("124", "I am a JS prompt", "You entered: 124")]
        public void JsPromtSendTextTest(string inputText, string expected1, string expected2)
        {
            BasePage.JavaScriptAlertsClick();
            AlertsPage.PromtButtonClick();
            AlertsPage.SendTextToAlert(inputText);

            var result1 = AlertsPage.GetAlertText();
            Assert.That(result1, Is.EqualTo(expected1));

            AlertsPage.AcceptAlert();
            var result2 = AlertsPage.GetResultMessage();

            Assert.That(result2, Is.EqualTo(expected2));
        }

        [TestCase("124", "I am a JS prompt", "You entered: null")]
        public void JsPromtDissmisTest(string inputText, string expected1, string expected2)
        {
            BasePage.JavaScriptAlertsClick();
            AlertsPage.PromtButtonClick();
            AlertsPage.SendTextToAlert(inputText);

            var result1 = AlertsPage.GetAlertText();
            Assert.That(result1, Is.EqualTo(expected1));

            AlertsPage.DissmisAlert();
            var result2 = AlertsPage.GetResultMessage();

            Assert.That(result2, Is.EqualTo(expected2));
        }
    }
}
