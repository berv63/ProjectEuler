using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Problem78_CoinPartitions_Test
{
    public static class JobExtensions
    {
        public static void PrintMultiples(int multiple, int startRange, int endRange)
        {
            if (startRange < 0 || endRange < 0)
                return;

            if(startRange > endRange)
            {
                var temp = endRange;
                endRange = startRange;
                startRange = temp;
            }

            for (var i = endRange; i >= startRange; i = i-multiple)
            {
                Console.WriteLine(i);
            }
        }

        public static bool AreAnagrams(string string1, string string2)
        {
            var sortedString1 = string.Concat(string1.ToUpper().OrderBy(c => c));
            var sortedString2 = string.Concat(string2.ToUpper().OrderBy(c => c));

            var result = sortedString1 == sortedString2;
            return result;
        }

        public static bool IsComposite(int number)
        {
            if (number <= 3)
                return false;

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0) 
                    return true;
            }

            return false;
        }

        public static bool ContainsNubmer(string text)
        {
            int parseResult;
            return text.Any(x => int.TryParse(x.ToString(), out parseResult));
        }
    }


    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestMethod()
        {
            JobExtensions.PrintMultiples(3, 1, 99);
            JobExtensions.PrintMultiples(3, 99, 1);
        }

        [TestMethod]
        public void TestMethod1()
        {
            var result = JobExtensions.AreAnagrams("Boj", "Job");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result1 = JobExtensions.IsComposite(2);
            Assert.AreEqual(false, result1);

            var result2 = JobExtensions.IsComposite(4);
            Assert.AreEqual(true, result2);

            var result3 = JobExtensions.IsComposite(13);
            Assert.AreEqual(false, result3);

            var result4 = JobExtensions.IsComposite(20);
            Assert.AreEqual(true, result4);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = JobExtensions.ContainsNubmer("");
            Assert.AreEqual(false, result);

            var result1 = JobExtensions.ContainsNubmer("ASDF");
            Assert.AreEqual(false, result1);

            var result2 = JobExtensions.ContainsNubmer("QWER1");
            Assert.AreEqual(true, result2);

            var result3 = JobExtensions.ContainsNubmer("ASDFAQ!WSQERq1asdf");
            Assert.AreEqual(true, result3);

            var result4 = JobExtensions.ContainsNubmer("0ASDF23");
            Assert.AreEqual(true, result4);
        }
    }



}
