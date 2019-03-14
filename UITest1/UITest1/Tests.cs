using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;
using System.Threading;
using System.Diagnostics;




namespace UITest1
{ 
    [TestFixture]
    public class Tests
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            // TODO: If the Android app being tested is included in the solution then open
            // the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            app = ConfigureApp
                .Android
                // TODO: Update this path to point to your Android app and uncomment the
                // code if the app is not included in the solution.
                .ApkFile ("../../../Android/bin/Debug/app-envJp-sit.apk")
                .StartApp();
        }

        
        [Test]
        public void NewTest()
        {
            //need assertion to break the test into parts
            Thread.Sleep(6000);
            app.SwipeRightToLeft();
            app.SwipeRightToLeft();
            app.SwipeRightToLeft();
            app.Tap(x => x.Id("alreadyHaveAccountButton"));
            app.Tap("Email");
            app.EnterText("customer@customername.com");
            app.Tap("Password");
            app.EnterText("Ggyum4baby");
            app.ScrollDownTo("Sign me in!", strategy: ScrollStrategy.Gesture, timeout: new TimeSpan(0, 1, 0));
            app.Tap(x => x.Id("signInButton"));
            Thread.Sleep(10000);
            app.Tap(x => x.Id("action_hamburger"));
            Thread.Sleep(10000);
            app.Tap("Pampers Account");
            //app.Query(c => c.Marked("Pampers Account").Parent().Class("AlertDialogLayout"));
            app.Tap("My Baby");
            app.Tap("Edit");
            app.Tap("Child's First Name");
            //app.Query(c => c.Marked("Male").Parent().Class("AlertDialogLayout"));
            //app.Tap("First Name");
            app.EnterText("Baby Name");
            app.Tap("My baby's birthday");
            //app.Tap("Khan");
            //app.Tap("Birthday");
            app.Query(c => c.Marked("OK").Parent().Class("AlertDialogLayout"));
            app.Tap("Save");

            

            //Thread.Sleep(10000);
            //app.SwipeRightToLeft();
            //app.SwipeRightToLeft();
            //app.SwipeRightToLeft();
            //Thread.Sleep(15000);
            //app.Tap(x => x.Id("alreadyHaveAccountButton"));
            //app.Tap("Email");
            //app.EnterText("customer@customername.com");
            //app.Tap("Password");
            //app.EnterText("Ggyum4baby");
            //app.ScrollDownTo("Sign me in!", strategy: ScrollStrategy.Gesture, timeout: new TimeSpan(0, 1, 0));
            //app.Tap(x => x.Id("signInButton"));
            //Thread.Sleep(10000);
            ////id for below
            //app.Tap(x => x.Id("action_hamburger"));
            //app.Tap(x => x.Id("navAccountItem"));
            ////app.Tap("Pampers Account");
            //app.ScrollDownTo("Let's sign out", strategy: ScrollStrategy.Gesture, timeout: new TimeSpan(0, 1, 0));

            //app.Tap(x => x.Id("logOutText"));

            // Thread.Sleep(10000);
            // app.SwipeRightToLeft();
            // app.SwipeRightToLeft();
            // app.SwipeRightToLeft();

            // //ive already got an account elemetn
            // app.Tap(x => x.Id("joinNowButton"));







            // //System.Configuration.ConfigurationSettings.AppSettings["Key1"];


            // Thread.Sleep(10000);
            // app.SwipeRightToLeft();
            // app.SwipeRightToLeft();
            // app.SwipeRightToLeft();

            // app.Tap(x => x.Id("joinNowButton"));


            // Thread.Sleep(4000);
            // app.EnterText(System.Configuration.ConfigurationSettings.AppSettings["Key2"]);
            // //app.Tap("First Name");
            // app.Tap(x => x.Id("firstNameEditText"));

            // app.EnterText(System.Configuration.ConfigurationSettings.AppSettings["Key1"]);

            // //needs to be changed to the calender element
            // app.ScrollDownTo(x => x.Id("firstNameEditText"), strategy: ScrollStrategy.Auto);

            // Thread.Sleep(3000);




            // app.Tap("Child's Birth / Due Date");
            // app.Query(c => c.Class("AlertDialogLayout"));
            // app.Tap("OK");





            // app.ScrollDownTo("Email", strategy: ScrollStrategy.Gesture, timeout: new TimeSpan(0, 1, 0));


            // app.Tap("Email");


            // Process cmd = new Process();
            // Random random = new Random();
            // // Generate 10 random email addresses.

            // //string address = string.Format("qa{0:0000}@test.com", random.Next(10000));
            // app.Tap("Email"); 
            // app.EnterText(System.Configuration.ConfigurationSettings.AppSettings["Key3"]);
            // // String Input1 = Convert.ToString(("app.EnterText(address.ToString())"));
            // // cmd.StandardInput.WriteLine(Input1);

            // //System.Configuration.ConfigurationManager.AppSettings;









            // //app.Tap("ZIP Code");
            ////app.EnterText("34265");


            // //app.ScrollDown("Password");
            // app.Tap("Password");
            // app.EnterText(System.Configuration.ConfigurationSettings.AppSettings["Key4"]);
            // app.ScrollDownTo("I'd love to join!", strategy: ScrollStrategy.Gesture, timeout: new TimeSpan(0, 1, 0));
            // app.Tap("I'd love to join!");

            //app.Query(c => c.Marked("OK").Parent().Class("AlertDialogLayout"));



        }
       
        public void Login()
        {
            //Thread.Sleep(6000);
            //app.SwipeRightToLeft();
            //app.SwipeRightToLeft();
            //app.SwipeRightToLeft();
            //app.Tap(x => x.Id("alreadyHaveAccountButton"));
            //app.Tap("Email");
            //app.EnterText("customer@customername.com");
            //app.Tap("Password");
            //app.EnterText("Ggyum4baby");
            //app.ScrollDownTo("Sign me in!", strategy: ScrollStrategy.Gesture, timeout: new TimeSpan(0, 1, 0));
            //app.Tap(x => x.Id("signInButton"));
            //Thread.Sleep(3000);
            //app.Tap(x => x.Id("action_hamburger"));
            //app.Tap("Pampers Account");
            //app.Tap(x => x.Id("logOutText"));



            Thread.Sleep(6000);
            app.SwipeRightToLeft();
            app.SwipeRightToLeft();
            app.SwipeRightToLeft();
            app.Tap(x => x.Id("alreadyHaveAccountButton"));
            app.Tap("Email");
            app.EnterText("customer@customername.com");
            app.Tap("Password");
            app.EnterText("Ggyum4baby");
            app.ScrollDownTo("Sign me in!", strategy: ScrollStrategy.Gesture, timeout: new TimeSpan(0, 1, 0));
            app.Tap(x => x.Id("signInButton"));
            Thread.Sleep(3000);
            app.Tap(x => x.Id("action_hamburger"));
            app.Tap("Pampers Account");
            app.Tap("My Details");
            app.Tap("Edit");



        }
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }
    }
}
