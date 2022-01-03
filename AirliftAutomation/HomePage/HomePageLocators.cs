using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirliftAutomation.HomePage
{
    internal class HomePageLocators
    {
        public static String Country = "(//nz-select-search/input)[1]";
        public static String City = "(//nz-select-search/input)[2]";
        public static String Address = "(//nz-select-search/input)[3]";
        public static String AddressSelect = "div > i";
        public static String ContinueButton = "//span[normalize-space()='Continue']";
        public static String Seachbar = "//input[@placeholder='Search for items...']";
        public static String AddtoCart = "//button[@nztype='default']";
        public static String CartCount = "//span[@class='bb-count ng-star-inserted']";
        public static String NoProductValidation = "//div/span";
        public static String ListofSearchResult = "//ecp-product[@class='plw-col ng-star-inserted']";
        
    }
}
