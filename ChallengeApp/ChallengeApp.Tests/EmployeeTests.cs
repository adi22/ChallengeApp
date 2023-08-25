namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnMinimalValue()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski");
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
            var employee = new Employee("Jan", "Kowalski");
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
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrade(7);
            employee.AddGrade(4);
            employee.AddGrade(2);
            employee.AddGrade(8);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(5.25, statistics.Average);
        }
        [Test]
        public void WhenEmployeeCollectA_ShouldGet100Points()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrade('A');

            // act
            var lastGrade = employee.ReturnLastGrade();

            // assert
            Assert.AreEqual(100, lastGrade);
        }
        [Test]
        public void WhenEmployeeCollectB_ShouldGet80Points()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrade('B');

            // act
            var lastGrade = employee.ReturnLastGrade();

            // assert
            Assert.AreEqual(80, lastGrade);
        }
        [Test]
        public void WhenEmployeeCollectC_ShouldGet60Points()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrade('C');

            // act
            var lastGrade = employee.ReturnLastGrade();

            // assert
            Assert.AreEqual(60, lastGrade);
        }
        [Test]
        public void WhenEmployeeCollectD_ShouldGet40Points()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrade('D');

            // act
            var lastGrade = employee.ReturnLastGrade();

            // assert
            Assert.AreEqual(40, lastGrade);
        }
        [Test]
        public void WhenEmployeeCollectE_ShouldGet20Points()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrade('E');

            // act
            var lastGrade = employee.ReturnLastGrade();

            // assert
            Assert.AreEqual(20, lastGrade);
        }

    } 
}