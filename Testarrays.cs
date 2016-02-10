using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Talang2015
{
    [TestFixture]
    public class TestArrays
    {
        private int[] arr = { 1 , 0};
        private int[,] arr2 = {{1, 2}, {3, 4}};
        private int[,,] arr3 = new int[0, 1, 2];
        int[][] arr4 = new int[][]
        {
            new int[] {1,2,5,7,9},
            new int[] {3,4,5,6},
            new int[] {11,22}
        };

        [Test]
        public void should_be_one_dimensional()
        {
            
            Assert.AreEqual(arr[0], 1);
        }

        [Test]
        public void should_be_two_dimensional()
        {
            //kod här

            Assert.That(arr2[0, 0], Is.EqualTo(1));
            Assert.That(arr2[0, 1], Is.EqualTo(2));
            Assert.That(arr2[1, 0], Is.EqualTo(3));
            Assert.That(arr2[1, 1], Is.EqualTo(4));
        }

        [Test]
        public void should_be_three_dimensional()
        {
            //kod här

            Assert.That(arr3[1, 1, 1], Is.EqualTo(0));
            Assert.That(arr3[52, 153, 77], Is.EqualTo(1));
            Assert.That(arr3[33, 141, 20], Is.EqualTo(2));
        }

        [Test]
        public void should_be_jagged()
        {
            //kod här

            Assert.That(arr4[0][0], Is.EqualTo(1));
            Assert.That(arr4[0][1], Is.EqualTo(2));
            Assert.That(arr4[1][0], Is.EqualTo(3));
            Assert.That(arr4[1][1], Is.EqualTo(4));
            Assert.That(arr4[1][2], Is.EqualTo(5));
        }

    }


}
