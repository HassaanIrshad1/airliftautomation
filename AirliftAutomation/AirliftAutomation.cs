using AirliftAutomation.HomePage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace AirliftAutomation
{
    [TestClass]
    public class AirliftAutomation 
    {
        BaseClass airliftexpress = new BaseClass();
        HomePageBy homePage = new HomePageBy();
        [TestMethod]
        public void AddItemtotheCart()
        {
            airliftexpress.OpenUrl();
            airliftexpress.waitForElementtoLoad(10);
            
            //Select Country
            airliftexpress.clickOnButton(homePage.Country);
            airliftexpress.entertext(homePage.Country, "Pakistan"+Keys.Enter);


            //Select City
            airliftexpress.clickOnButton(homePage.City);
            airliftexpress.entertext(homePage.City, "Karachi"+Keys.Enter);
            airliftexpress.hardWait(3);


            airliftexpress.clickOnButton(homePage.AddressSelect);
            airliftexpress.hardWait(8);
            airliftexpress.clickOnButton(homePage.ContinueButton);


            airliftexpress.entertext(homePage.Seachbar, "Milk" + Keys.Enter);
            airliftexpress.hardWait(15);
            airliftexpress.clickOnButton(homePage.AddtoCart);

            Assert.AreEqual(airliftexpress.getText(homePage.CartCount),"1");
        }
        [TestMethod]
        public void FindingAProducThatdoesntExist()
        {
            airliftexpress.OpenUrl();
            airliftexpress.waitForElementtoLoad(10);

            //Select Country
            airliftexpress.clickOnButton(homePage.Country);
            airliftexpress.entertext(homePage.Country, "Pakistan" + Keys.Enter);


            //Select City
            airliftexpress.clickOnButton(homePage.City);
            airliftexpress.entertext(homePage.City, "Karachi" + Keys.Enter);
            airliftexpress.hardWait(3);


            airliftexpress.clickOnButton(homePage.AddressSelect);
            airliftexpress.hardWait(8);
            airliftexpress.clickOnButton(homePage.ContinueButton);


            airliftexpress.entertext(homePage.Seachbar, "Hassaan Irsahd" + Keys.Enter);
            airliftexpress.hardWait(8);
            
            Assert.AreEqual(airliftexpress.getText(homePage.NoProductValidation), "No Products Found");
        }

    }
}




