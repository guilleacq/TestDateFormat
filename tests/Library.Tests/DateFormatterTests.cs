using TestDateFormat;

namespace Library.Tests
{
    [TestFixture]
    public class DateFormatterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DateFormatTest()
        {
            var inputDate = "11/10/2000";
            var expectedDate = "2000-10-11";

            var finalDate = DateFormatter.ChangeFormat(inputDate);
            Assert.AreEqual(expectedDate, finalDate);
        }

        [Test]
        public void WrongDateTest()
        {
            var inputDate = "113/10//";
            var expectedDate = "";

            var finalDate = DateFormatter.ChangeFormat(inputDate);
            Assert.AreEqual(expectedDate, finalDate);
        }

        [Test]
        public void EmptyDateTest()
        {
            var inputDate = "";
            var expectedDate = "";

            var finalDate = DateFormatter.ChangeFormat(inputDate);
            Assert.AreEqual(expectedDate, finalDate);
        }
    }
}

