using System;
using Xunit;

namespace GradeBook.tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            Book book = new Book("");
            book.AddGrade(1.0);
            book.AddGrade(2.0);
            book.AddGrade(3.0);
            var result = book.GetStatistics();
            Assert.Equal(1.0, result.Low);
            Assert.Equal(2.0, result.Average);
            Assert.Equal(3.0, result.High);
        }
    }
}
