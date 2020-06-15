using System;
using Xunit;


namespace GradeBook.tests
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            var book1 = new Book("Book 1");
            var book2 = new Book("Book 2");
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

    }
}