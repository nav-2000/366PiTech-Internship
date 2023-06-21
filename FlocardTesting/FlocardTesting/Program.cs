using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Threading;
using NUnit.Framework.Internal.Execution;

namespace FlocardTesting 
{
    internal class program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        { }



        [SetUp]
        public void initialize() {
            driver.Navigate().GoToUrl("https://flocard.app/");
            driver.Manage().Window.Maximize();
        }


        [Test]
        public void test1() {
            IWebElement sdgs = driver.FindElement(By.XPath("//*[@id=\"navBar\"]/div/ul/li[1]/a"));
            sdgs.Click();

            IWebElement plantTree = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div[1]/div[2]/a/div/div/div/span"));
            plantTree.Click();
            driver.Navigate().Back();

            IWebElement supportsdg1 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div[2]/div[1]/a/div/div"));
            supportsdg1.Click();
            driver.Navigate().Back();
        }
        [Test]
        public void test2()
        {
            IWebElement integrated = driver.FindElement(By.XPath("//*[@id=\'navBar\']/div/ul/li[2]/a"));
            integrated.Click();

            IWebElement enterprise = driver.FindElement(By.XPath("//*[@id=\'content\']/div[1]/section/div/div/div/div[2]/div[1]"));
            enterprise.Click();
            driver.Navigate().Back();

            IWebElement planter = driver.FindElement(By.XPath("//*[@id='content']/div[1]/section/div/div/div/div[2]/div[2]/a/div/div[1]/img"));
            planter.Click();
        }
        [Test]
        public void test3()
        {
            IWebElement knowledge = driver.FindElement(By.XPath("//*[@id=\"navBar\"]/div/ul/li[3]/a"));
            knowledge.Click();

            IWebElement climateChange = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div/div[1]/a/div"));
            climateChange.Click();
            driver.Navigate().Back();

            IWebElement game = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div/div[2]/a/div"));
            game.Click();

        }
        [Test]
        public void test4()
        {
            IWebElement contact = driver.FindElement(By.XPath("//*[@id=\"navBar\"]/div/ul/li[4]/a"));
            contact.Click();

            //IWebElement map = driver.FindElement(By.XPath("//*[@id=\'content\']/div[1]/section/div/div/div/div/div[2]/a/div"));
            //map.Click();
            //driver.Navigate().Back();

            IWebElement firstName = driver.FindElement(By.XPath("//*[@id=\"firstName\"]"));
            firstName.SendKeys("Navneet");

            IWebElement lastName = driver.FindElement(By.XPath("//*[@id=\"lastName\"]"));
            lastName.SendKeys("Singh");

            IWebElement email = driver.FindElement(By.XPath("//*[@id=\"emailAddress\"]"));
            email.SendKeys("navneet.205.ns@gmail.com");

            IWebElement message = driver.FindElement(By.XPath("//*[@id=\"message\"]"));
            message.SendKeys("Flocard Testing");

            //IWebElement robot = driver.FindElement(By.XPath("//*[@id=\"recaptcha-anchor\"]/div[1]"));
            //robot.Click();
            //driver.Navigate().Back();

            IWebElement submit = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div[2]/div[2]/div/div[2]/form/div/button"));
            submit.Click();

        }
        [Test]
        public void test5()
        {
            IWebElement aboutus = driver.FindElement(By.XPath("//*[@id=\"navBar\"]/div/ul/li[5]/a"));
            aboutus.Click();

            // IWebElement twitter = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/h2[1]/a"));
            //twitter.Click();
            //driver.Navigate().Back();

            IWebElement goal1 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div[3]/div/a/div"));
            goal1.Click();

            IWebElement goal2 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div[4]/div/a/div"));
            goal2.Click();

            IWebElement goal3 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div[5]/div/a/div"));
            goal3.Click();

            IWebElement goal4 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div[6]/div/a/div"));
            goal4.Click();

            IWebElement goal5 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div[7]/div/a/div"));
            goal5.Click();

            IWebElement goal6 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div[8]/div/a/div"));
            goal6.Click();

            IWebElement goal7 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div[9]/div/a/div"));
            goal7.Click();

            IWebElement goal8 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div[10]/div/a/div"));
            goal8.Click();

            IWebElement goal9 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div[11]/div/a/div"));
            goal9.Click();

            IWebElement goal10 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div[12]/div/a/div"));
            goal10.Click();

            IWebElement goal11 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div[13]/div/a/div"));
            goal11.Click();

            IWebElement goal12 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div[14]/div/a/div"));
            goal12.Click();

            IWebElement goal13 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div[15]/div/a/div"));
            goal13.Click();

            IWebElement goal14 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div[16]/div/a/div"));
            goal14.Click();

            IWebElement goal15 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div[17]/div/a/div"));
            goal15.Click();

            IWebElement goal16 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div[18]/div/a/div"));
            goal16.Click();

            IWebElement goal17 = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div[19]/div[1]/a/div"));
            goal17.Click();

        }

        [Test]
        public void test6()
        {
            IWebElement bap = driver.FindElement(By.XPath("//*[@id=\"navBar\"]/div/ul/li[6]/a"));
            bap.Click();
            driver.Navigate().Back();

            //IWebElement baplink = driver.FindElement(By.XPath("//*[@id=/html/body/section]/div[2]/div/div/a[2]"));
            //baplink.Click();
            //driver.Navigate().Back();

        }
        [Test] 
        public void test7()
        {
            IWebElement getStarted = driver.FindElement(By.XPath("//*[@id=\"logoAndNav\"]/nav/div/div[1]/a"));
            getStarted.Click();

            IWebElement signInWithGoogle = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[1]/span"));
            signInWithGoogle.Click();

            IWebElement gid = driver.FindElement(By.XPath("//*[@id=\"identifierId\"]"));
            gid.SendKeys("navneet.205.ns@gmail.com");

            IWebElement gpass = driver.FindElement(By.XPath("//*[@id=\"identifierId\"]"));
            gpass.SendKeys("Navneet");
            driver.Navigate().Back();

            IWebElement signInWithLinkedin = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[2]/div/div/div/div/form/div/a[2]/span"));
            signInWithLinkedin.Click();

            IWebElement LinkedinID = driver.FindElement(By.XPath("//*[@id=\"username\"]"));
            LinkedinID.SendKeys("Navneet.206.ns@gmail.com");

            IWebElement LinkedinPass = driver.FindElement(By.XPath("//*[@id=\"password\"]"));
            LinkedinPass.SendKeys("Navneet");

        }
        [Test]
        public void test8()
        {
            IWebElement createFlocard = driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div/div/a"));
            createFlocard.Click();

            //GOOGLE SIGN-IN
            /* IWebElement cfsignInWithGoogle = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[1]/span"));
             cfsignInWithGoogle.Click();
             IWebElement cfgid = driver.FindElement(By.XPath("//*[@id=\"identifierId\"]"));
             cfgid.SendKeys("navneet.205.ns@gmail.com");
             IWebElement nxt = driver.FindElement(By.XPath("//*[@id=\"identifierNext\"]/div/button/span"));
             nxt.Click();
             IWebElement cfgpass = driver.FindElement(By.XPath("//*[@id=\"password\"]/div[1]/div/div[1]/input"));
             cfgpass.SendKeys("Navneet123#");
             driver.Navigate().Back();*/

            //Linkedin SIGN-IN
            IWebElement SignInWithLinkedin = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[2]/div/div/div/div/form/div/a[2]/span"));
            SignInWithLinkedin.Click();

            IWebElement LinkedinID = driver.FindElement(By.XPath("//*[@id=\"username\"]"));
            LinkedinID.SendKeys("Navneet.206.ns@gmail.com");

            IWebElement LinkedinPass = driver.FindElement(By.XPath("//*[@id=\"password\"]"));
            LinkedinPass.SendKeys("WASDgamer206#");

            IWebElement SignIn = driver.FindElement(By.XPath("//*[@id=\"app__container\"]/main/div[2]/form/div[3]/button"));
            SignIn.Click();

            IWebElement dropDown = driver.FindElement(By.XPath("//*[@id=\"editIntro\"]"));
            dropDown.Click();

            IWebElement edit = driver.FindElement(By.XPath("//*[@id=\"connectionsDropdown1\"]/div/a"));
            edit.Click();

            IWebElement del = driver.FindElement(By.XPath("//*[@id=\"clearProfilePic\"]"));
            del.Click();

            IWebElement name = driver.FindElement(By.XPath("//*[@id=\"txtName\"]"));
            name.Clear();
            name.SendKeys("Navneet");

            IWebElement title = driver.FindElement(By.XPath("//*[@id=\"txtHeadline\"]"));
            title.Clear();
            title.SendKeys("Intern");

           /* IWebElement EmailId = driver.FindElement(By.XPath("//*[@id=\"txtEmail\"]"));
            EmailId.Click();
            EmailId.Clear();
            EmailId.SendKeys("Navneet.205.ns@gmail.com");
            Thread.Sleep(5000);*/

            IWebElement pno = driver.FindElement(By.XPath("//*[@id=\"txtPhone\"]"));
            pno.Click();
            pno.Clear();
            pno.SendKeys("7004673892");

            IWebElement website = driver.FindElement(By.XPath("//*[@id=\"txtWebsite\"]"));
            website.Clear();
            website.SendKeys("www.google.com");

            IWebElement fbLink = driver.FindElement(By.XPath("//*[@id=\"txtFacebook\"]"));
            fbLink.Clear();
            fbLink.SendKeys("profile.php?id=100004169014795&mibextid=ZbWKwL");

            IWebElement igLink = driver.FindElement(By.XPath("//*[@id=\"txtInstagram\"]"));
            igLink.Clear();
            igLink.SendKeys("__navneetsingh__?igshid=OTk0YzhjMDVlZA==");

            IWebElement tLink = driver.FindElement(By.XPath("//*[@id=\"txtTwitter\"]"));
            tLink.Clear();
            tLink.SendKeys("Navneets206?t=r5ccXYx8bQVd2bJNwxOwaw&s=09");

            IWebElement linLink = driver.FindElement(By.XPath("//*[@id=\"txtLinkedin\"]"));
            linLink.Clear();
            linLink.SendKeys("navneet-singh-2a78b7214");

            IWebElement addTag = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div/form/div[12]/div/tags/span"));
            addTag.Clear();
            addTag.SendKeys("intern");

            IWebElement company = driver.FindElement(By.XPath("//*[@id='content']/div[1]/section/div/div/div/div/form/div[11]/div/div/div[2]/div[2]"));
            company.Click();

            IWebElement individual = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div/form/div[11]/div/div/div[2]/div[1]"));
            individual.Click();

            IWebElement cancel = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div/form/div[13]/div/a"));
            cancel.Click();

            //IWebElement updateCard = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div/div/form/div[13]/div/input[2]"));
            //updateCard.Click();

            IWebElement DropDown = driver.FindElement(By.XPath("//*[@id=\"editIntro\"]"));
            DropDown.Click();

            //IWebElement shareCard = driver.FindElement(By.XPath("//*[@id=\"connectionsDropdown1\"]/a[3]"));
            //shareCard.Click();

            IWebElement CardVersion = driver.FindElement(By.XPath("//*[@id=\"connectionsDropdown1\"]/a[4]"));
            CardVersion.Click();
            driver.Navigate().Back();


            IWebElement t = driver.FindElement(By.XPath("//*[@id=\"editIntro\"]"));
            t.Click();

            IWebElement AttachToOrganization = driver.FindElement(By.XPath("//*[@id=\"connectionsDropdown1\"]/a[5]"));
            AttachToOrganization.Click();
            Thread.Sleep(5000);
            driver.Navigate().Back();

            IWebElement dd = driver.FindElement(By.XPath("//*[@id=\"editIntro\"]"));
            dd.Click();

            IWebElement AddBusinessCard = driver.FindElement(By.XPath("//*[@id=\"connectionsDropdown1\"]/a[6]"));
            AddBusinessCard.Click();
            driver.Navigate().Back();

            IWebElement Exchange = driver.FindElement(By.XPath("//*[@id=\"exchangemenu\"]/a"));
            Exchange.Click();

            IWebElement ExchangeCodes = driver.FindElement(By.XPath("//*[@id=\"lnkExchangeCodes\"]"));
            ExchangeCodes.Click();
            driver.Navigate().Back();

            IWebElement Exchange1 = driver.FindElement(By.XPath("//*[@id=\"exchangemenu\"]/a"));
            Exchange1.Click();

            /*IWebElement ReceiveExchangeCodes = driver.FindElement(By.XPath("//*[@id=\"lnkExchangeReceive\"]/span[2]"));
            ReceiveExchangeCodes.Click();

            IWebElement ExchangeUsingCodesButton = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div/div[2]/form/div[2]/div/input"));
            ExchangeUsingCodesButton.Click();
            Thread.Sleep(4000);*/

            IWebElement MyContacts = driver.FindElement(By.XPath("//*[@id=\"lnkContacts\"]/span"));
            MyContacts.Click();
            driver.Navigate().Back();

            IWebElement MyFloCardId = driver.FindElement(By.XPath("//*[@id=\"lnkAddress\"]/span"));
            MyFloCardId.Click();
            driver.Navigate().Back();

            IWebElement MyArchivedCards = driver.FindElement(By.XPath("//*[@id=\"lnkArchived\"]/span"));
            MyArchivedCards.Click();
            driver.Navigate().Back();

            //FAQS
            IWebElement faqs = driver.FindElement(By.XPath("//*[@id=\"lnkFAQ\"]/span"));
            faqs.Click();

           /* IWebElement gen = driver.FindElement(By.XPath("//*[@id=\"navbarSettings\"]/li/a"));
            gen.Click();
            IWebElement faqs1 = driver.FindElement(By.XPath("//*[@id=\"headingGeneral1\"]/h2/button"));
            faqs1.Click();
            faqs1.Click();

            IWebElement faqs2 = driver.FindElement(By.XPath("//*[@id=\"headingGeneral2\"]/h2/button"));
            faqs2.Click();
            faqs2.Click();

            IWebElement faqs3 = driver.FindElement(By.XPath("//*[@id=\"headingGeneral3\"]/h2/button"));
            faqs3.Click();
            faqs3.Click();

            IWebElement faqs4 = driver.FindElement(By.XPath("//*[@id=\"headingGeneral4\"]/h2/button"));
            faqs4.Click();
            faqs4.Click();

            IWebElement faqs5 = driver.FindElement(By.XPath("//*[@id=\"headingGeneral5\"]/h2/button"));
            faqs5.Click();
            faqs5.Click();
            IWebElement faqs6 = driver.FindElement(By.XPath("//*[@id=\"headingGeneral6\"]/h2/button"));
            faqs6.Click();
            faqs6.Click();
            IWebElement faqs7 = driver.FindElement(By.XPath("//*[@id=\"headingGeneral7\"]/h2/button"));
            faqs7.Click();
            faqs7.Click();
            IWebElement faqs8 = driver.FindElement(By.XPath("//*[@id=\"headingGeneral8\"]/h2/button"));
            faqs8.Click();
            faqs.Click();
            IWebElement faqs9 = driver.FindElement(By.XPath("//*[@id=\"headingGeneral9\"]/h2/button"));
            faqs9.Click();
            faqs9.Click();*/
            driver.Navigate().Back();



            //FloCardPolicies
            IWebElement fcp = driver.FindElement(By.XPath("//*[@id=\"lnkPolicies\"]/span"));
            fcp.Click();
            IWebElement Tc = driver.FindElement(By.XPath("//*[@id=\"navbarSettings\"]/li[2]/a"));
            Tc.Click();
            driver.Navigate().Back();

           /* IWebElement Support = driver.FindElement(By.XPath("//*[@id=\"lnkSupport\"]/span"));
            Support.Click();

            IWebElement SupportName = driver.FindElement(By.XPath("//*[@id=\"NameLabel\"]"));
            SupportName.SendKeys("Navneet");

            IWebElement SupportEmail = driver.FindElement(By.XPath("//*[@id=\"EmailLabel\"]"));
            SupportEmail.SendKeys("Navneet.206.ns@gamil.com");

            IWebElement SupportContact = driver.FindElement(By.XPath("//*[@id=\"ContactLabel\"]"));
            SupportContact.SendKeys("7004673892");

            IWebElement SupportDesc = driver.FindElement(By.XPath("//*[@id=\"message\"]"));
            SupportDesc.SendKeys("best app");

            IWebElement SupportSubmit = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/section/div/div[2]/div[1]/div/div[2]/form/div[4]/button"));
            SupportSubmit.Click();
            Thread.Sleep(5000);           
            driver.Navigate().Back();
            driver.Navigate().Back();*/

            IWebElement FlocardGuide = driver.FindElement(By.XPath("//*[@id=\"lnkGuide\"]/a/span"));
            FlocardGuide.Click();

            IWebElement CreateNewCard = driver.FindElement(By.XPath("//*[@id=\"newCardIntro\"]/span[2]"));
            CreateNewCard.Click();
            Thread.Sleep(5000);

            IWebElement EditCard = driver.FindElement(By.XPath("//*[@id=\"editCardIntro\"]/span[2]"));
            EditCard.Click();
            Thread.Sleep(5000);

            IWebElement xchangeflocard = driver.FindElement(By.XPath("//*[@id=\"exchangeIntro\"]/span[2]"));
            xchangeflocard.Click();
            Thread.Sleep(5000);

            IWebElement claimalias = driver.FindElement(By.XPath("//*[@id=\"aliasIntro\"]/span[2]"));
            claimalias.Click();
            Thread.Sleep(5000);

            IWebElement addtags = driver.FindElement(By.XPath("//*[@id=\"tagsIntro\"]/span[2]"));
            addtags.Click();
            Thread.Sleep(5000);





        }









        /*[TearDown]
        public void shutdown()
        {
            driver.Close();
        }*/

       

    }
}