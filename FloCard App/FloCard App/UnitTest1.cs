using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Interfaces;
namespace FloCard_App
{
    public class Tests
    {
        private AppiumDriver<AndroidElement> driver;

        [SetUp]
        public void Setup()
        {
            var appPath = @"C:\Users\ASUS\Downloads\FloCard-0.13.apk";
            var driveroption = new AppiumOptions();
            driveroption.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driveroption.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Pixel 4 API 30.avd");
            driveroption.AddAdditionalCapability(MobileCapabilityType.App, appPath);

            driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), driveroption);


        }


        [Test]
        public void Test1()
        {
            //getstarted
            driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[1]/android.view.ViewGroup/android.widget.Button").Click();
            Thread.Sleep(5000);

            //linkedIn
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.view.ViewGroup / android.widget.FrameLayout[1] / android.view.ViewGroup / android.widget.Button[2]").Click();

            //username
            driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View[3]/android.view.View[1]/android.widget.EditText").SendKeys("navneet.206.ns@gmail.com");
            //password
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.view.ViewGroup / android.webkit.WebView / android.webkit.WebView / android.view.View / android.view.View / android.view.View / android.view.View[3] / android.view.View[2] / android.widget.EditText\r\n").SendKeys("WASDgamer206#");
            //signin
            driver.FindElementByXPath("/ hierarchy / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.widget.LinearLayout / android.widget.FrameLayout / android.view.ViewGroup / android.webkit.WebView / android.webkit.WebView / android.view.View / android.view.View / android.view.View / android.view.View[3] / android.widget.Button[2]").Click();

            //cards
            //driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout[1]/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View/android.view.View[2]/android.view.View[1]").Click();

            //CONTACTS
            //driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout[1]/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View/android.view.View[3]/android.view.View[1]").Click();

            //sdgs
            //driver.FindElementByXPath("//hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout[1]/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[4]/android.view.View[1]").Click();
            //more
           // driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout[1]/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View/android.view.View[5]/android.view.View[1]").Click();

            Assert.Pass();
        }


    }

}




