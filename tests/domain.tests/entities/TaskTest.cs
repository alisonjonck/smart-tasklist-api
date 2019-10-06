using NUnit.Framework;
using domain.entities;

namespace domain.tests
{
    public class TaskTest
    {
        private Task _task;
        
        [SetUp]
        public void Setup()
        {
            _task = new Task();
        }

        [Test]
        public void Test1()
        {
            Assert.NotNull(_task);
        }
    }
}