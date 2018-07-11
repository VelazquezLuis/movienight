using ClassLibrary1.models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class HistoryTest
    {
        [Fact]
        public void test_HistoryId()
        {
            var expected = typeof(Guid);
            var sut= new History();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }
        
    }
}
