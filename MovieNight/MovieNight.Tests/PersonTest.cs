using ClassLibrary1.models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class PersonTest
    {
        [Fact]
        public void test_PersonId()
        {
            var expected = typeof(Guid);
            var sut = new Movie();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }
    }
}
