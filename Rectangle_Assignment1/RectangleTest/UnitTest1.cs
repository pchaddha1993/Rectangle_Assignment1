using NUnit.Framework;
using Rectangle_Assignment1;

namespace RectangleTest
{
    [TestFixture]
    public class Tests
    {

        Rectangle Rec = new Rectangle();

        [Test]
        public void TC01_Get_Length_of_Rectangle()
        {
            int result = Rec.GetLength(); //act
            Assert.AreEqual(result, 1); //assert
        }

        [Test]
        public void TC02_Set_Length_ofthe_rectangle()
        {
            int len = 10;//arrange
            int result = Rec.SetLength(len); //act
            Assert.AreEqual(result, len); //assert
        }

        [Test]
        public void TC03_Get_Width_of_the_Rectangle()
        {
            int result = Rec.GetWidth(); //act
            Assert.AreEqual(result, 1); //assert
        }

        [Test]
        public void TC04_Set_Width_of_the_rectangle()
        {
            int Wid = 5;//arrange
            int result = Rec.SetLength(Wid); //act
            Assert.AreEqual(result, Wid); //assert
        }


        [Test]
        public void TC05_Get_Perimeter_of_10_5()
        {

            int len = 10, Wid = 5;//arrange
            Rec.SetLength(len);//arrange
            Rec.SetWidth(Wid); //arrange
            int result = Rec.GetPerimeter(); //act
            Assert.AreEqual(result, 30); //assert
        }

        [Test]
        public void TC06_Get_Area_of_10_5()
        {
            int len = 10, Wid = 5;//arrange
            Rec.SetLength(len);//arrange
            Rec.SetWidth(Wid);//arrange
            int result = Rec.GetArea(); //act
            Assert.AreEqual(result, 50); //assert
        }

        [Test]
        public void TC07_Get_Length_of_Rectangle()
        {
            int result = Rec.GetLength(); //act
            Assert.AreEqual(result, 10); //assert
        }

        [Test]
        public void TC08_Set_Length_ofthe_rectangle()
        {
            int len = 6;//arrange
            int result = Rec.SetLength(len); //act
            Assert.AreEqual(result, len); //assert
        }

        [Test]
        public void TC09_Get_Width_of_the_Rectangle()
        {
            int result = Rec.GetWidth(); //act
            Assert.AreEqual(result, 5); //assert
        }

        [Test]
        public void TC10_Set_Width_of_the_rectangle()
        {
            int Wid = 10;//arrange
            int result = Rec.SetLength(Wid); //act
            Assert.AreEqual(result, Wid); //assert
        }

        [Test]
        public void TC11_Get_Perimeter_of_6_10()
        {
            int len = 6, Wid = 6;//arrange
            Rec.SetLength(len);//arrange
            Rec.SetWidth(Wid);//arrange
            int result = Rec.GetPerimeter(); //act
            Assert.AreEqual(result, 24); //assert
        }

        [Test]
        public void Tc12_Get_Area_of_6_10()
        {
            int len = 6, Wid = 10;//arrange
            Rec.SetLength(len);//arrange
            Rec.SetWidth(Wid);//arrange
            int result = Rec.GetArea(); //act
            Assert.AreEqual(result, 60); //assert
        }

        [Test]
        public void TC13_Get_Length_of_Rectangle()
        {
            int result = Rec.GetLength(); //act
            Assert.AreEqual(result, 6); //assert
        }

        [Test]
        public void TC14_Set_Length_ofthe_rectangle()
        {
            int len = 20;//arrange
            int result = Rec.SetLength(len); //act
            Assert.AreEqual(result, len); //assert
        }

        [Test]
        public void TC15_Get_Width_of_the_Rectangle()
        {
            int result = Rec.GetWidth(); //act
            Assert.AreEqual(result, 10); //assert
        }

        [Test]
        public void TC16_Set_Width_of_the_rectangle()
        {
            int Wid = 20;//arrange
            int result = Rec.SetLength(Wid); //act
            Assert.AreEqual(result, Wid); //assert
        }

        [Test]
        public void TC17_Get_Perimeter_of_20_20()
        {
            int len = 20, Wid = 20;//arrange
            Rec.SetLength(len);//arrange
            Rec.SetWidth(Wid);//arrange
            int result = Rec.GetPerimeter(); //act
            Assert.AreEqual(result, 80); //assert
        }

        [Test]
        public void TC18_Get_Area_of_20_20()
        {
            int len = 20, Wid = 20;//arrange
            Rec.SetLength(len);//arrange
            Rec.SetWidth(Wid);//arrange
            int result = Rec.GetArea(); //act
            Assert.AreEqual(result, 400); //assert
        }
    }
}

