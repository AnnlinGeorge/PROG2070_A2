using Assignment_2;

namespace Assignment2.Tests
{
    [TestFixture]
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

    [TestFixture]
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
    [TestFixture]
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

    [TestFixture]
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


}