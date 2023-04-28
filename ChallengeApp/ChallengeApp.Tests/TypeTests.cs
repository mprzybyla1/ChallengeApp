namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestValueType()
        {
            // arrange
            int number1 = 1;
            int number2 = 1;

            // act

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void TestReferenceType()
        {
            // arrange
            var employee1 = GetEmployee ("Adam", "Nowak", 22);
            var employee2 = GetEmployee ("Adam", "Nowak", 22);

            // act

            //assert
            Assert.AreEqual(employee1.Name, employee2.Name);
        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }

        [Test]
        public void TestString()
        {
            // arrange
            string name1 = "Adam";
            string name2 = "Adam";

            // act

            //assert
            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void TestFloat()
        {
            // arrange
            float number1 = 1.5254F;
            float number2 = 1.5254F;

            // act

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void TestDouble()
        {
            // arrange
            double number1 = 1.525455555;
            double number2 = 1.525455555;

            // act

            //assert
            Assert.AreEqual(number1, number2);
        }
    }
}
