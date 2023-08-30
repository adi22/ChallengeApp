namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenCompareObject_ShouldReturnDifferentObject()
        {
            // arrange
            var emp1 = GetEmployee("Adam", "Kowal");
            var emp2 = GetEmployee("Adam", "Kowal");

            // act

            // assert
            Assert.AreNotEqual(emp1, emp2);
        }

        [Test]
        public void WhenCompareInt_ShouldReturnSameValue()
        {
            // arrange
            int number1 = 1;
            int number2 = 1;

            // act

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void WhenCompareString_ShouldReturnSameValue()
        {
            // arrange
            string string1 = "x";
            string string2 = "x";

            // act

            // assert
            Assert.AreEqual(string1, string2);
        }

        [Test]
        public void WhenCompareFloat_ShouldReturnSameValue()
        {
            // arrange
            float float1 = 5;
            float float2 = 5;

            // act

            // assert
            Assert.AreEqual(float1, float2);
        }
    }
}
