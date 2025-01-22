using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Растояние__ПМ_.UnitTest1;

namespace Растояние__ПМ_
{
    [TestClass]
    public class UnitTest1
    {


        public class lonl
        {
            
            public double value { get; set;} // растояние в метрах


            public double Kilm()
            {
                if (value < 0)
                {
                    return 0;
                }
                return value * 1000;
            }

            public double Santim()
            {

                if (value < 0)
                {
                    return 0;
                }
                return value / 100;

            }

           

            public double Arshin()
            {
                if (value < 0)
                {
                    return 0;
                }
                return value * 0.71;

            }
            public double Sajin()
            {
                if (value < 0)
                {
                    return 0;
                }
                return value * 0.46;
            }


        }

        [TestMethod] // тест километр
        public void TestMethod1Kilm()
        {
            lonl lonl = new lonl();
            lonl.value = 4;
            Assert.AreEqual(4000,lonl.Kilm());
        }
        [TestMethod] // тест километр
        public void TestMethod1OtriKilm()
        {
            lonl lonl = new lonl();
            lonl.value = -4;                                
            Assert.AreEqual(0,lonl.Kilm());
        }
        

        [TestMethod] // тест сантиметры
        public void TestMethod1Sam()
        {
            lonl lonl = new lonl();
            lonl.value = 90;
            Assert.AreEqual(0.9,lonl.Santim());
        }

        [TestMethod] // тест сантиметры
        public void TestMethod1otriSam()
        {
            lonl lonl = new lonl();
            lonl.value = -3;
            Assert.AreEqual(0,lonl.Santim());
        }


        [TestMethod] // тест Аршин
        public void TestMethodArshin()
        {
            lonl lonl = new lonl();
            lonl.value = 56;
            Assert.AreEqual(39.76,lonl.Arshin());
        }

        [TestMethod] // тест Аршин
        public void TestMethodArshinOtri()
        {
            lonl lonl = new lonl();
            lonl.value = -56;
            Assert.AreEqual(0, lonl.Arshin());
        }

        [TestMethod] // тест Сажени
        public void TestMethodSajin()
        {
            lonl lonl = new lonl();
            lonl.value = 3;   
            Assert.AreEqual(1.38, lonl.Sajin(), 0.01);
        }                     
        [TestMethod] // тест Сажени
        public void TestMethodSajinOtri()
        {                     
            lonl lonl = new lonl();
            lonl.value = -2;
            Assert.AreEqual(0,lonl.Sajin());
        }








    }
}

