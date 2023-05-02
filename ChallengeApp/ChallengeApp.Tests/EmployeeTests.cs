namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void GetStatisticsShouldReturnMinValue()
        {
            // arrange - przygotowanie
            var employee = new Employee("Mateusz", "Przyby³a");
            employee.AddGrade(0);
            employee.AddGrade(-3);
            employee.AddGrade(-7);

            // act - uruchomienie
            var statistics = employee.GetStatistics();

            // assert - sprawdzenie warunków
            Assert.That(statistics.Min, Is.EqualTo(-7));
        }

        [Test]
        public void GetStatisticsShouldReturnMaxValue()
        {
            // arrange - przygotowanie
            var employee = new Employee("Mateusz", "Przyby³a");
            employee.AddGrade(0);
            employee.AddGrade(-3);
            employee.AddGrade(-7);

            // act - uruchomienie
            var statistics = employee.GetStatistics();

            // assert - sprawdzenie warunków
            Assert.That(statistics.Max, Is.EqualTo(0));
        }

        [Test]
        public void GetStatisticsShouldReturnAverageValue()
        {
            // arrange - przygotowanie
            var employee = new Employee("Mateusz", "Przyby³a");
            employee.AddGrade(0);
            employee.AddGrade(-3);
            employee.AddGrade(-7);

            // act - uruchomienie
            var statistics = employee.GetStatistics();

            // assert - sprawdzenie warunków
            Assert.That(Math.Round(statistics.Average, 2), Is.EqualTo(Math.Round(-3.33, 2)));
        }
    }
}