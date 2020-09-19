using NUnit.Framework;
using Cipher;
using System;

namespace CipherTests
{
    [TestFixture()]
    public class AsciiGeneratorTest
    {
        [Test()]
        public void TestCase()
        {
            string actual = AsciiGenerator.convertToAscii("Hello");

            assert.Equal(actual, "072 101 108 108 111");
        }
    }
}
