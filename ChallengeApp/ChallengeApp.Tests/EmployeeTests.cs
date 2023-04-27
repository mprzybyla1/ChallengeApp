namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectTwoScores_ShouldReturnCorrectResult()
        {
            // arrange - przygotowanie
            var employee = new Employee("Adam", "Zorro", 25);
            employee.AddScore(5);
            employee.AddScore(-10);

            // act - uruchomienie
            var result = employee.Result;

            // assert - sprawdzenie warunk�w
            Assert.AreEqual(-5, result);
        }

        [Test]
        public void WhenEmployeesCollectScores_ThenMaxResultWins()
        {
            // arrange - przygotowanie
            var employee1 = new Employee("Micha�", "Zorro", 26);
            employee1.AddScore(10);
            employee1.AddScore(-10);

            var employee2 = new Employee("Karol", "Zorro", 27);
            employee2.AddScore(9);
            employee2.AddScore(-10);

            // act - uruchomienie
            var result1 = employee1.Result;
            var result2 = employee2.Result;

            bool maxResult = result1 < result2;

            // assert - sprawdzenie warunk�w
            Assert.AreEqual(false, maxResult);
        }
    }
}

// Testy jednostkowe (unitowe) s�u�� do tego, aby testowa� nasz kod.Weryfikacja programu po zmianach.
// Narz�dzia do test�w: NUnit, MSTest, xUnit. 
// 3 elementy dobrego testu: Arrange (przygotowanie), Act (uruchomienie), Assert (sprawdzenie warunk�w). 