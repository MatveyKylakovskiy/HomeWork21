using Allure.Commons;
using HomeWork21.Pages.SalesSoft;
using PageObjectLib.Factories;

namespace HomeWork21.Tests
{

    internal class SalesSoftBasetest
    {

        [SetUp]
        public void SetUp()
        {
            Driver.GoUrl("https://saas-saas-9809.lightning.force.com/lightning/page/home");
            LoginPage.Login("egoaesu-ldqe@force.com", "7Wy7cm2ZAM9qRKS№%");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}



/*egoaesu - ldqe@force.com
7Wy7cm2ZAM9qRKS№%*/