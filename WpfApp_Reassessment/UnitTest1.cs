using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfApp_Reassesent;

namespace WpfApp_Reassessment
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
        /// <summary>
        /// This testCase is for moveto command
        /// </summary>
        [TestMethod]
        public void TestCheckMoveTo()
        {
            CommandParser cmdParser1 = new CommandParser();
            bool retval1 = cmdParser1.checkmoveto("moveto 10 10");
            Assert.AreEqual(retval1, true);

            CommandParser cmdParser2 = new CommandParser();
            bool retval2 = cmdParser2.checkmoveto("moveto 10");
            Assert.AreEqual(retval2, false);

        }

        /// <summary>
        /// This testCase is for drawto command
        /// </summary>
        [TestMethod]
        public void TestCheckDrawTo()
        {
            CommandParser cmdParser1 = new CommandParser();
            bool retval1 = cmdParser1.checkdrawto("drawto 10 10");
            Assert.AreEqual(retval1, true);

            CommandParser cmdParser2 = new CommandParser();
            bool retval2 = cmdParser2.checkdrawto("drawto 10");
            Assert.AreEqual(retval2, false);

        }

        /// <summary>
        /// This testCase is for clear command
        /// </summary>
        [TestMethod]
        public void TestCheckClear()
        {
            CommandParser cmdParser1 = new CommandParser();
            bool retval1 = cmdParser1.checkclear("clear");
            Assert.AreEqual(retval1, true);

            CommandParser cmdParser2 = new CommandParser();
            bool retval2 = cmdParser2.checkclear("clear clear");
            Assert.AreEqual(retval2, false);

        }

        /// <summary>
        /// This testCase is for reset command
        /// </summary>
        [TestMethod]
        public void TestCheckReset()
        {
            CommandParser cmdParser1 = new CommandParser();
            bool retval1 = cmdParser1.checkreset("reset");
            Assert.AreEqual(retval1, true);

            CommandParser cmdParser2 = new CommandParser();
            bool retval2 = cmdParser2.checkreset("RESET");
            Assert.AreEqual(retval2, false);

        }

        /// <summary>
        /// This testCase is for rectangle command
        /// </summary>
        [TestMethod]
        public void TestCheckRectangle()
        {
            CommandParser cmdParser1 = new CommandParser();
            bool retval1 = cmdParser1.checkrectangle("rectangle 10 10");
            Assert.AreEqual(retval1, true);

            CommandParser cmdParser2 = new CommandParser();
            bool retval2 = cmdParser2.checkrectangle("rectangle 10");
            Assert.AreEqual(retval2, false);

        }

        /// <summary>
        /// This testCase is for circle command
        /// </summary>
        [TestMethod]
        public void TestCheckCircle()
        {
            CommandParser cmdParser1 = new CommandParser();
            bool retval1 = cmdParser1.checkcircle("circle 10");
            Assert.AreEqual(retval1, true);

            CommandParser cmdParser2 = new CommandParser();
            bool retval2 = cmdParser2.checkcircle("circle 10 10");
            Assert.AreEqual(retval2, false);

        }

        /// <summary>
        /// This testCase is for Triangle command
        /// </summary>
        [TestMethod]
        public void TestCheckTriangle()
        {
            CommandParser cmdParser1 = new CommandParser();
            bool retval1 = cmdParser1.checktriangle("triangle 20 10 10 10");
            Assert.AreEqual(retval1, true);

            CommandParser cmdParser2 = new CommandParser();
            bool retval2 = cmdParser2.checktriangle("triangle 0 10 10 20 0 10");
            Assert.AreEqual(retval2, false);
        }

        /// <summary>
        /// This testCase is for Pen Color
        /// </summary>
        [TestMethod]
        public void TestCheckPen()
        {
            CommandParser cmdParser1 = new CommandParser();
            bool retval1 = cmdParser1.checkpen("pen red");
            Assert.AreEqual(retval1, true);

            CommandParser cmdParser2 = new CommandParser();
            bool retval2 = cmdParser2.checkpen("pen purple");
            Assert.AreEqual(retval2, false);

        }

        /// <summary>
        /// This testCase is for fill command
        /// </summary>
        [TestMethod]
        public void TestCheckFill()
        {
            CommandParser cmdParser1 = new CommandParser();
            bool retval1 = cmdParser1.checkfill("fill on");
            Assert.AreEqual(retval1, true);

            CommandParser cmdParser2 = new CommandParser();
            bool retval2 = cmdParser2.checkfill("fill purple");
            Assert.AreEqual(retval2, false);

        }
        /// <summary>
        /// This function will always fail because the test environment is not having access
        /// to draw graphics on the WPF form
        /// </summary>
        [TestMethod]
        public void TestDrawTriangle()
        {
            try
            {
                CommandParser cmdParser1 = new CommandParser();
                cmdParser1.drawTriangle(10, 0, 20, 30);
                Assert.Fail("");

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
