using NUnit.Framework;
using EdabitTDD;

namespace TDD
{
    [TestFixture]
    public class Tests
    {
        Methods _methods;
        [SetUp]
        public void Setup()
        {
            _methods = new Methods();
            ActionClass actionClass = new ActionClass(); // Refactorizar
        }

        [TestCase(1, 60)]
        [TestCase(2, 120)]
        [TestCase(3, 180)]
        [TestCase(4, 240)]
        [TestCase(5, 300)]
        public void Test_ConvertToSeconds_IntSeconds(int minutes, int resultSeconds)
        {
            Assert.AreEqual(Methods.Convert(minutes), resultSeconds);
        }

        //Stuttering Function
        /*Write a function that stutters a word as if someone is struggling to read it. 
         * The first two letters are repeated twice with an ellipsis ... 
         * and space after each, and then the word is pronounced with a question mark ?.
        */

        [TestCase("incredible", "in... in... incredible?")]
        [TestCase("struggling", "st... st... struggling?")]
        [TestCase("pronounced", "pr... pr... pronounced?")]
        public void Test_GivenAString_ReturnStutteredString(string inputWord, string expectedString)
        {

            //Act
            string finalString = _methods.Stuttering(inputWord);
            //Assert
            Assert.AreEqual(finalString, expectedString);
        }

        // Hashes and Pluses
        // Create a function that returns the number of hashes and pluses in a string.

        [Test]
        [TestCase("##+#+", new int[]{3, 2})]
        [TestCase("", new int[]{0, 0})]
        public void Test_GivenAStringWithHashAndPlus_ReturnAmount(string inputString, int[] expectedArray)
        {
            int[] finalArray = _methods.CountHashesAndPluses(inputString);
            Assert.AreEqual(expectedArray, finalArray);
        }

        //How Many Vowels?
        //Create a function that takes a string and returns the number (count) of vowels contained within it.

        [Test]
        [TestCase("Hola", 2)]
        [TestCase("Return", 2)]
        [TestCase("Function", 3)]
        [TestCase("", 0)]
        [TestCase("LRQ", 0)]
        [TestCase("Asistencia", 5)]
        public void Test_GivenAWord_RetournVowelCount(string inputString, int expectedCount)
        {
            int vowelCount = _methods.HowManyVowel(inputString);
            Assert.AreEqual(expectedCount, vowelCount);
        }

        //Next Number Greater Than A and B and Divisible by B
        //You are given two numbers a and b. Create a function that returns the next number greater than a and b and divisible by b.

        [Test]
        [TestCase(11, 5, 15)]
        [TestCase(2, 23, 23)]
        [TestCase(7, -2, 8)]
        [TestCase(-9, -6, -6)]
        public void Test_GivenTwoNumbers_GetNextMultipleOfB(int firstNumber, int secondNumber, int expectedNumber)
        {
            int? resultNumber = _methods.NextMultipleOfB(firstNumber, secondNumber);
            Assert.AreEqual(resultNumber, expectedNumber);
        }
        [TestCase(4,24)]
        public void Test_GivenAnNumber_ReturnFactorial(int number, int expectedFactorial)
        {
            int factorial = Methods.RecursiveFactorial(number);
            Assert.AreEqual(factorial, expectedFactorial);
        }

        /*

        Find the Vertex of a Quadratic

        Every quadratic curve y = a x² + b x + c has a vertex point: the turning point where the curve stops heading down and starts going up.

        Given the values a, b and c, you need to return the coordinates of the vertex. Return your answers rounded to 2 decimal places.

        vertex x = -b / 2a

        */

        [TestCase(4, -8, 6, new float[] { 1, 2 })]

        public void Test_GivenParametersForQuadraticFunction_ReturnVertex(float a, float b, float c, float[] expectedResult)
        {

            Assert.AreEqual(Methods.GetQuadraticVertex(a, b, c), expectedResult);
        }

        [TestCase(2, 3, 6, new float[] { -0.75f, 4.88f })]
        public void Test_GivenParametersForQuadraticFunction_ReturnValuesApproched(float a, float b, float c, float[] expectedApprochedResult)
        {
            float[] result = Methods.GetQuadraticVertex(a, b, c);
            float[] resultApproched = Methods.ApprochResult(result);
            Assert.AreEqual(expectedApprochedResult, resultApproched);
        }

        /*

        Generate All String Character Permutations

        Create a function to generate all string character permutations.

        */

        [TestCase("AB", new string[] { "AB", "BA" })]
        [TestCase("NOT", new string[] { "NOT", "NTO", "ONT", "OTN", "TNO", "TON" })]
        public void Test_GivenStringInput_ReturnPermutations(string inputString, string[] expectedPermutations)
        {
            Assert.AreEqual(Methods.GetStringPermutationsArray(inputString), expectedPermutations);
        }

        [TestCase("hola que tal", "tal", true)]
        [TestCase("hola mundo", "hola", false)]
        [TestCase("hey", "*********", true)]
        [TestCase("hey", "que tal h*y", true)]
        public void Test_GivenTwoStringInput_ReturnTrueIfOneContainsTheOther(string firstArg, string secondArg, bool expectedResult)
        {
            bool result = Methods.ContainsEachOther(firstArg, secondArg);

            Assert.AreEqual(expectedResult, result);
        }

        /*
         
        Track the Robot (Part 2)

        This robot roams around a 2D grid. It starts at (0, 0) facing North. After each time it moves,
        the robot rotates 90 degrees clockwise.
        Given the amount the robot has moved each time, you have to calculate the robot's final position.

        */

        [TestCase(new int[] { 30, 20, 15, 10 }, new int[] { 10, 15 })]
        public void Test_GivenAnArrayOfMovement_CalculateFinalPosition(int[] movements, int[] expectedFinalPosition)
        {
            int[] finalPosition = Methods.GetFinalPosition(movements);
            Assert.AreEqual(expectedFinalPosition, finalPosition);
        }

        [TestCase(1, 60)]
        [TestCase(2, 120)]
        [TestCase(3, 180)]
        [TestCase(4, 240)]

        public void Test_ConvertMinutesIntoSeconds_IntSeconds(int minutes, int secondsResult)
        {
            //Arrange - Given

            //Act - When

            //Assert - Then
            Assert.AreEqual(ActionClass.MinutesToSeconds(minutes), secondsResult);
        }

        //Given two numbers, return true if the sum of both numbers is less than 100. Otherwise return false.

        [Test]
        public void Test_GivenTwoNumbersAndSumThem_ReturnTrueLessThan100()
        {
            int firstNumber = 5;
            int secondNumber = 7;
            bool isTrue = false;
            isTrue = ActionClass.LessThan100(firstNumber, secondNumber);
            Assert.IsTrue(isTrue);
        }
        [Test]
        public void Test_GivenTwoNumbersAndSumThem_ReturnFalseMoreThan100()
        {

            int firstNumber = 95;
            int secondNumber = 7;
            bool isFalse = ActionClass.LessThan100(firstNumber, secondNumber);
            Assert.IsFalse(isFalse);
        }

        // Create a function that reverses a boolean value.

        [Test]
        public void Test_GivenAFalseBoolean_ReturnTrue()
        {
            bool myBool = false;
            Assert.IsTrue(ActionClass.FlipTheBoolean(myBool));
        }
        [Test]
        public void Test_GivenATrueBoolean_ReturnFalse()
        {
            bool myBool = true;
            Assert.IsFalse(ActionClass.FlipTheBoolean(myBool));
        }

        //Write a function that returns the string "something" joined with a space " " and the given argument a.

        [TestCase("papa", "something papa")]
        [TestCase("yesica", "something yesica")]
        [TestCase("tomas", "something tomas")]
        [TestCase("genaro", "something genaro")]

        public void TestString_GivenAnString_ReturnSomethingSpaceString(string inputValue, string expectedValue)
        {

            string resultString = ActionClass.ReturnSomethingToMe(inputValue);

            Assert.AreEqual(expectedValue, resultString);
        }

        //Create a function that takes the age in years and returns the age in days.

        [TestCase(1, 365)]
        [TestCase(10, 3650)]
        [TestCase(30, 10950)]
        [TestCase(50, 18250)]
        public void TestAge_GivenAmountOfAge_ReturnAmountOfDays(int inputAgeValue, int daysResultExpected)
        {

            int days = ActionClass.AgeToDaysIn365EachYear(inputAgeValue);

            Assert.AreEqual(daysResultExpected, days);
        }

        /*Given an n-sided regular polygon n, return the total sum of internal angles (in degrees).
         *
         * n will always be greater than 2.
         * The formula(n - 2) x 180 gives the sum of all the measures of the angles of an n-sided polygon.
        */

        /*
         * Create a function that takes an integer and returns the factorial of that integer.
         * That is, the integer multiplied by all positive lower integers.
         */

        /*Multiply by Length
         * Create a function to multiply all of the values in an array by the amount of values in the given array.
         * All of the values given are numbers.
         * All arrays will have at least one element.
         * Don't forget to return the result.
        */

        /*Shuffle the Name
         * Create a function that accepts a string (of a person's first and last name)
         * and returns a string with the first and last name swapped.
         *
         *There will be exactly one space between the first and last name.
         */


    }


}