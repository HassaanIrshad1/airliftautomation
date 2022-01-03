using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA;
using OpenQA.Selenium;

namespace AirliftAutomation.HomePage{
    internal class HomePageBy 

    {
        /// <summary>
        /// Where do you want to deliver Window 
        /// </summary>
        //Country Field
        public  By Country = By.XPath(HomePageLocators.Country);
        //City
        public  By City = By.XPath(HomePageLocators.City);
        //Address
        public By Address = By.XPath(HomePageLocators.Address);

        public By AddressSelect = By.CssSelector(HomePageLocators.AddressSelect);
        //ContinueButton
        public By ContinueButton  = By.XPath(HomePageLocators.ContinueButton);

        public By Seachbar = By.XPath(HomePageLocators.Seachbar);

        public By AddtoCart = By.XPath(HomePageLocators.AddtoCart);

        public By CartCount = By.XPath(HomePageLocators.CartCount);

        public By NoProductValidation = By.XPath(HomePageLocators.NoProductValidation);

        public By ListofSearchResult = By.XPath(HomePageLocators.ListofSearchResult);


    }
}
