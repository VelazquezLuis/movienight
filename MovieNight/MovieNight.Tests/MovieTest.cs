using ClassLibrary1.models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class MovieTest
    {
        [Fact]
        public void test_MovieId()
        {
            var expected = typeof(Guid);
            var sut = new Movie();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }
    }
}
