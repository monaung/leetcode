using LeetCode.Code;
using System.Runtime.CompilerServices;

namespace LeetCode.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5,120)]
        public void FindFactorialIterative(int number, int expected)
        {

            Factorial f = new Factorial();
            
            Assert.Equal(expected, f.FindFactorialIterative(number));
        }

        [Theory]
        [InlineData(5, 120)]
        public void FindFactorialRecursive(int number, int expected)
        {

            Factorial f = new Factorial();

            Assert.Equal(expected, f.FindFactorialRecursive(number));
        }

        public UnitTest1()
        {

        }
        [Theory]
        [InlineData(1, true)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(97, true)]
        public void Test1(int number, bool expected)
        {
            CheckPrimeNumber primeNumber = new CheckPrimeNumber();



            bool result = primeNumber.IsPrimeNumber(number);

            Assert.Equal(expected, result);

        }



        public static IEnumerable<object[]> DurationTestData()
        {
            yield return new object[] {
                new DurationTest{
                    Measurement = new List<Measure>
                    {
                        new Measure { Time = new DateTime(2019, 10, 01, 10, 14, 11), Value = 0 },
                        new Measure { Time = new DateTime(2019, 10, 01, 10, 55, 00), Value = 1 },
                        new Measure { Time = new DateTime(2019, 10, 01, 12, 21, 00), Value = 0 },
                        new Measure { Time = new DateTime(2019, 10, 01, 13, 14, 12), Value = 1 },
                        new Measure { Time = new DateTime(2019, 10, 01, 14, 45, 14), Value = 0 }
                    },
                    Start = new DateTime(2019, 10, 01, 10, 15, 00),
                    End = new DateTime(2019, 10, 01, 11, 00, 00),
                }
                , new TimeSpan(0,5,0)
                , "Test Case 1: to turn 5 mins"
           };


            yield return new object[] {
                new DurationTest{
                    Measurement = new List<Measure>
                    {
                        new Measure { Time = new DateTime(2025, 3, 01, 0, 0, 0), Value = 0 },
                        new Measure { Time = new DateTime(2025, 3, 03, 0, 0, 0), Value = 1 },
                        new Measure { Time = new DateTime(2025, 3, 05, 0, 0, 0), Value = 0 },
                        new Measure { Time = new DateTime(2025, 3, 07, 0, 0, 0), Value = 0 },
                        new Measure { Time = new DateTime(2025, 3, 9, 0, 0, 0), Value = 1 },
                        new Measure { Time = new DateTime(2025, 3, 11, 0, 0, 0), Value = 0 },
                        new Measure { Time = new DateTime(2025, 3, 14, 0, 0, 0), Value = 0 }                    },
                    Start = new DateTime(2025, 3, 7),
                    End = new DateTime(2025, 3, 11),
                }, new TimeSpan(2,0, 0, 0)
                , "Test Case 2: to return 2 days"
           };


        }


    }
}
