using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using NSubstitute;
using AutoFixture;
using AutoFixture.AutoNSubstitute;
using CalculatorSolution;



namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            Fixture fixture = new Fixture();
            //var value1 = fixture.Create<int>();
            //var value2 = fixture.Create<int>();



            var sut = fixture.Create<Calculator>();
            //act
            var result = sut.Sum(4, 5);
            //assert
            Assert.AreEqual(result, 9);
        }
    }
}