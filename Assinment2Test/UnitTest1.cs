using Assignment_2;

namespace Assignment2.Tests
{
    [TestFixture] //Annlin Padammatturmel George 
    public class TestingGetLength
    {
        [Test]
        public void TestGetLength_MinLength_1()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();
            int expected = 1;
            // ACT
            int actual = rectangle.GetLength();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TestGetLength_JustAboveMAXLenth_3501()
        {
            // Arrange
            int length = 3501;
            int width = 10;
            Rectangle rectangle = new Rectangle(length, width);
            int expected = 1;
            // ACT
            int actual = rectangle.GetLength();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestGetLength_ValidInput_700()
        {
            // Arrange
            int length = 700;
            int width = 10;
            Rectangle rectangle = new Rectangle(length, width);
            int expected = 700;
            // ACT
            int actual = rectangle.GetLength();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }


    }

    [TestFixture] //Annlin Padammatturmel George
    public class TestingSetLength
    {
        [Test]
        public void TestSetLength_MinLength_0()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();
            int length = 0;
            int expected = -1;
            // ACT
            int actual = rectangle.SetLength(length);
            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TestSetLength_JustAboveMAXLength_3501()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();
            int length = 3501;
            int expected = -1;
            // ACT
            int actual = rectangle.SetLength(length);
            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TestSetLength_ValidInput_700()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();
            int length = 700;
            int expected = 700;
            // ACT
            int actual = rectangle.SetLength(length);
            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
    [TestFixture] //Marcelo Rivera 
    public class TestingGetWidth
    {
        [Test]
        public void TestGetWidth_MinWidth_1()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();
            int expected = 1;
            // ACT
            int actual = rectangle.GetWidth();
            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TestGetWidth_JustAboveMAXWidth_3501()
        {
            // Arrange
            int length = 10;
            int width = 3501;
            Rectangle rectangle = new Rectangle(length, width);
            int expected = 1;
            // ACT
            int actual = rectangle.GetWidth();
            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TestGetWidth_ValidInput_700()
        {
            // Arrange
            int length = 10;
            int width = 700;
            Rectangle rectangle = new Rectangle(length, width);
            int expected = 700;
            // ACT
            int actual = rectangle.GetWidth();
            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    [TestFixture] //Marcelo Rivera 
    public class TestingSetWidth
    {
        [Test]
        public void TestSetWidth_MinWidth_0()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();
            int width = 0;
            int expected = -1;
            // ACT
            int actual = rectangle.SetWidth(width);
            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TestSetWidth_JustAboveMAXWidth_3501()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();
            int width = 3501;
            int expected = -1;
            // ACT
            int actual = rectangle.SetWidth(width);
            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TestSetWidth_ValidInput_700()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();
            int width = 700;
            int expected = 700;
            // ACT
            int actual = rectangle.SetWidth(width);
            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }

    [TestFixture] //Nohelis Rangel
    public class TestingGetPerimeter
    {
        [Test]
        public void TestGetPerimeter_MinLength_1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            int expected = 4;

            //Act

            int actual = rectangle.GetPerimeter();

            //Assert

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestGetPerimeter_JustAboveMAXWidth_3501()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(3501, 3501);
            int expected = 4;

            //Act
            int actual = rectangle.GetPerimeter();

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestGetPerimeter_ValidInput_700()
        {

            //Arrange
            Rectangle rectangle = new Rectangle(700, 700);
            int expected = 2800;
            //Act
            int actual = rectangle.GetPerimeter();

            //Assert

            Assert.That(actual, Is.EqualTo(expected));

        }


    }

    [TestFixture] //Nohelis Rangel
    public class TestingGetArea
    {
        [Test]

        public void TestGetArea_MinLength_1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            int expected = 1;

            //Act

            int actual = rectangle.GetArea();

            //Assert

            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void TestGetArea_JustAboveMAXWidth_3501()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(3501, 3501);
            int expected = 1;

            // Act
            int actual = rectangle.GetArea();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test]
        public void TestGetArea_ValidInput_700()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(700, 700);
            int expected = 490000;

            // Act
            int actual = rectangle.GetArea();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }


}