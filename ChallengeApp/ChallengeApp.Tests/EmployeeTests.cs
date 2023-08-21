namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectScores_ShouldReturnCorrectResult()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski", 25);
            employee.AddScore(3);
            employee.AddScore(4);
            employee.AddScore(2);

            // act
            int result = employee.GetScore;

            // assert
            Assert.AreEqual(9, result);
        }
        [Test]
        public void WhenEmployeeCollectNegativeScore_ShouldReturnCorrectResult()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski", 25);
            employee.AddScore(5);
            employee.AddScore(-5);

            // act
            int result = employee.GetScore;

            // assert
            Assert.AreEqual(0, result);
        }
    }
}