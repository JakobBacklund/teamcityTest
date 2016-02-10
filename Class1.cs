using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ExtensionMethods
{
    
    public static class MyExtensions
    {
        [TestCase("I like deep fried chalupas")]
        public static void word_count_of_string(string s)
        {
            Assert.That(s.WordCount(), Is.EqualTo(5));
        }
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}