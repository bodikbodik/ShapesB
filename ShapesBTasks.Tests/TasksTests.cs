using NUnit.Framework;
using System;
using System.IO;

namespace ShapesBTasks.Tests
{
    [TestFixture]
    public class TasksTests
    {
        private StringWriter writer;

        [SetUp]
        public void SetUp()
        {
            this.writer = new StringWriter();
            Console.SetOut(this.writer);
        }

        [TearDown]
        public void Cleanup()
        {
            this.writer.Close();
        }

        [TestCase(1, "S = 1")]
        [TestCase(3, "S = 9")]
        [TestCase(5, "S = 25")]
        public void Task1_ReturnsCorrectValue(int a, string expected)
        {
            Tasks.Task1(a);
            var actual = this.writer.GetStringBuilder().ToString().Trim();
            Assert.AreEqual(expected, actual, "Task1 returns incorrect value.");
        }

        [TestCase(3, 18.84, 28.26)]
        [TestCase(7, 43.96, 153.86)]
        [TestCase(5, 31.4, 78.5)]
        public void Task2_ReturnsCorrectValue(int r, double expected1, double expected2)
        {
            Tasks.Task2(r);
            var data = this.writer.GetStringBuilder().ToString().Trim().Substring(4).Split(new[] { ", S = " }, StringSplitOptions.None);
            double.TryParse(data[0], out double actual1);
            double.TryParse(data[1], out double actual2);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected1, actual1, 0.01, "Task2 returns incorrect 'circumference'.");
                Assert.AreEqual(expected2, actual2, 0.01, "Task2 returns incorrect 'area'.");
            });
        }

        [TestCase(3, 2, 4, "V = 24, S = 52")]
        [TestCase(7, 1, 1, "V = 7, S = 30")]
        [TestCase(5, 2, 8, "V = 80, S = 132")]
        public void Task3_ReturnsCorrectValue(int a, int b, int c, string expected)
        {
            Tasks.Task3(a, b, c);
            var actual = this.writer.GetStringBuilder().ToString().Trim();
            Assert.AreEqual(expected, actual, "Task3 returns incorrect value.");
        }
    }
}