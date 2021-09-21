using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseString;

namespace ReverseStringTest
{
    [TestClass]
    public class ReverseStringTestUn
    {
        [TestMethod]
        public void Reverse_String_Verify_String_Is_Correct()
        {
            //Arrange
            var sut = new ReverseStringInput();
            //var input = "guy";
            var expected = "yug";

            //Act
            var output = sut.GetInput();

            //Assert
            Assert.AreEqual(expected, output);
        }
    }
}
