using Allure.Commons;
using HomeWork21.Pages.InternetHerokuapp;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using PageObjectLib.Factories;

namespace HomeWork21.Tests
{
    [Parallelizable(ParallelScope.Fixtures)]
    [TestFixture]
    [AllureNUnit]
    internal class AlertsTests : BaseTest
    {
        
        [TestCase("I am a JS Alert", "You successfully clicked an alert")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Matvey")]
        [AllureLink("Website", "https://the-internet.herokuapp.com/javascript_alerts")]
        [AllureIssue("UI-1")]
        [AllureTms("TMS-456")]
        public void JsAlertTest(string expected1, string expected2)
        {
           // BasePage.JavaScriptAlertsClick();
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");

            AlertsPage.AlertButtonClick();
            var result1 = AlertsPage.GetAlertText();

            Assert.That(result1, Is.EqualTo(expected1));

            AlertsPage.AcceptAlert();
            var result2 = AlertsPage.GetResultMessage();

            Assert.That(result2, Is.EqualTo(expected2));
        }

        [TestCase("I am a JS Confirm", "You clicked: Ok")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("Matvey")]
        [AllureLink("Website", "https://the-internet.herokuapp.com/javascript_alerts")]
        [AllureIssue("UI-2")]
        [AllureTms("TMS-456")]
        public void JsConfirmAcceptTest(string expected1, string expected2)
        {
            //BasePage.JavaScriptAlertsClick();
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
            AlertsPage.ConfirmButonClick();
            var result1 = AlertsPage.GetAlertText();

            Assert.That(result1, Is.EqualTo(expected1));

            AlertsPage.AcceptAlert();
            var result2 = AlertsPage.GetResultMessage();

            Assert.That(result2, Is.EqualTo(expected2));
        }

        [TestCase("I am a JS Confirm", "You clicked: Cancel")]
        [AllureSeverity(SeverityLevel.minor)]
        [AllureOwner("User")]
        [AllureLink("Website", "https://the-internet.herokuapp.com/javascript_alerts")]
        [AllureIssue("UI-3")]
        [AllureTms("TMS-456")]
        public void JsConfirmDissmisTest(string expected1, string expected2)
        {
            //BasePage.JavaScriptAlertsClick();
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
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
            //BasePage.JavaScriptAlertsClick();
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
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
            //BasePage.JavaScriptAlertsClick();
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
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
