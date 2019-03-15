using DemoLibrary;
using System;
using Xunit;

namespace DemoLibrary_Tests
{
    public class ExamplesTests
    {
        [Fact]
        public void ExampleLoadTextFile_Test()
        {
            var actual = Examples.ExampleLoadTextFile("Teste de nome válido");

            Assert.True(actual.Length > 0);
        }

        [Fact]
        public void ExampleLoadTextFile_TestInvalidName()
        {
            Assert.Throws<ArgumentException>("file", () => Examples.ExampleLoadTextFile(""));
        }
    }
}
