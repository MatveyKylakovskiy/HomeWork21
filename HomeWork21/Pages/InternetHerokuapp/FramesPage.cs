using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace HomeWork21.Pages.InternetHerokuapp
{
    internal class FramesPage
    {
        private static WebElements frameText = new(By.XPath("/html/body"));

        public static Dictionary<string, WebElements> DicOfFrames = new Dictionary<string, WebElements>()
        {
            {"Top", new(By.XPath("//*[@src='/frame_top']"))},
            {"Left", new(By.XPath("//*[@src='/frame_left']"))},
            {"Middle", new(By.XPath("//*[@src='/frame_middle']"))},
            {"Right", new(By.XPath("//*[@src='/frame_right']"))},
            {"Bottom", new(By.XPath("//*[@src='/frame_bottom']"))},
        };
        public static void SwitchToFrame(WebElements frame) => frame.SwitchToFrame();

        public static string GetFrameText() => frameText.GetText();
    }
}
