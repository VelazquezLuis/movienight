using ClassLibrary1.models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class ShowingTest
    {
        [Fact]
        public void test_ShowingId()
        {
            var expected = typeof(Guid);
            var sut = new Showing();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }
    }
}
