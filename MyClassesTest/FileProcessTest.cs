using MyClasses;
using NUnit.Framework;

namespace MyClassesTest
{
    public class FileProcessTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FileNameDoesExists()
        {
            // TODO;
            FileProcess fp = new FileProcess();
            bool fromCall;

            fromCall = fp.FileExists(@"C:\Windows\Regedit.exe");

            Assert.IsTrue(fromCall);
        }

        [Test]
        public void FileNameDoesNotExist()
        {
            // TODO;
            Assert.Inconclusive();
        }

        [Test]
        public void FileNameNullOrEmpty_throwsArgumentNullException()
        {
            // TODO;
            Assert.Inconclusive();
        }
    }
}