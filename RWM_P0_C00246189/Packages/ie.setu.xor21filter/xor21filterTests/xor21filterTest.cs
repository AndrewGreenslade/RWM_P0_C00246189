using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class xor21filterTest
    {
        [Test]
        public void xorFilterSimple()
        {
            int[] input = { 4,2,8,3,9,4,10 };
            int[] output = xor21filter.xors(input);
            int[] expected = { 17,23,29,22,28,17,31 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
