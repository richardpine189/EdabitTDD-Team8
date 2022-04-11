using NUnit.Framework;
using EdabitTDD;

namespace TDD
{
    [TestFixture]
    public class Tests
    {
        TDDAction tddAction;
        [SetUp]
        public void Setup()
        {
            tddAction = new TDDAction();
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
            string finalString = tddAction.Stuttering(inputWord);
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
            int[] finalArray = tddAction.CountHashesAndPluses(inputString);
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
            int vowelCount = tddAction.HowManyVowel(inputString);
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
            int? resultNumber = tddAction.NextMultipleOfB(firstNumber, secondNumber);
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
    }


}