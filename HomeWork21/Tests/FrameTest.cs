using HomeWork21.Pages.InternetHerokuapp;

namespace HomeWork21.Tests
{
    internal class FrameTest : BaseTest
    {
        [TestCase("Left", "LEFT")]
        [TestCase("Middle", "MIDDLE")]
        [TestCase("Right", "RIGHT")]
        public void FramesTopTests(string frame, string expected)
        {
            BasePage.FramesClick();
            FramesPage.SwitchToFrame(FramesPage.DicOfFrames["Top"]);
            FramesPage.SwitchToFrame(FramesPage.DicOfFrames[frame]);

            Assert.That(FramesPage.GetFrameText(), Is.EqualTo(expected));
        }

        [TestCase("Bottom", "BOTTOM")]
        public void FrameBottomTest(string frame, string expected)
        {
            BasePage.FramesClick();
            FramesPage.SwitchToFrame(FramesPage.DicOfFrames[frame]);

            Assert.That(FramesPage.GetFrameText(), Is.EqualTo(expected));
        }
    }
}
