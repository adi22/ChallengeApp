namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnMinimalValue()
        {
            // arrange
            var employee = new EmployeeInMemory("Jan", "Kowalski");
            employee.AddGrade(7);
            employee.AddGrade(4);
            employee.AddGrade(2);
            employee.AddGrade(8);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(2, statistics.Min);
        }
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnMaximumValue()
        {
            // arrange
            var employee = new EmployeeInMemory("Jan", "Kowalski");
            employee.AddGrade(7);
            employee.AddGrade(4);
            employee.AddGrade(2);
            employee.AddGrade(8);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(8, statistics.Max);
        }
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnAverageValue()
        {
            // arrange
            var employee = new EmployeeInMemory("Jan", "Kowalski");
            employee.AddGrade(7);
            employee.AddGrade(4);
            employee.AddGrade(2);
            employee.AddGrade(8);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(5.25, statistics.Average);
        }
    } 
}