using OpenQA.Selenium;
using PageObjectLib.Elements;

namespace HomeWork21.Tests
{
    internal class UploadDown
    {   
        string dir = Directory.GetCurrentDirectory();

        public static WebElements upload = new(By.Id("uploadFile"));

        public static void Upload() => upload.SendValue(Directory.GetCurrentDirectory() + "/TestFile.txt");

        public static WebElements Downlod = new(By.Id("downloadButton"));
    }
}
