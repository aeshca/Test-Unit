using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Включения;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // исходные данные
            string str = "там за морями за лесами";
            char i = 'а';
            int expected = 4;
            Program g = new Program();
            int rezult = g.vxod(str,i);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);

        }

        [TestMethod]
        public void TestMethod2()
        {
            // исходные данные
            string str = "how do you do";
            char i = 'o';
            int expected = 4;
            Program g = new Program();
            int rezult = g.vxod(str, i);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);

        }

        [TestMethod]
        public void TestMethod3()
        {
            // исходные данные
            string str = "4n0934ftn45385897n";
            char i = 'g';
            int expected = 0;
            Program g = new Program();
            int rezult = g.vxod(str, i);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);

        }

        [TestMethod]
        public void TestMethod4()
        {
            // исходные данные
            string str = "";
            char i = '5';
            int expected = 0;
            Program g = new Program();
            int rezult = g.vxod(str, i);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);

        }


        [TestMethod]
        public void TestMethod5()
        {
            // исходные данные
            string str = "!@#$#$#$@#$$%^#$@#$!#@%*/*+/*/";
            char i = '@';
            int expected = 4;
            Program g = new Program();
            int rezult = g.vxod(str, i);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);
        }

        [TestMethod]
        public void TestMethod6()
        {
            // исходные данные
            string str = "45304264620787766767844574878777979";
            char i = '9';
            int expected = 2;
            Program g = new Program();
            int rezult = g.vxod(str, i);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);
        }
    }
}
