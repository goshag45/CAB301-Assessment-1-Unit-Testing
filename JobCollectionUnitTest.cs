using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class JobCollectionUnitTest
    {
        [TestMethod]
        public void TestJobCollection()
        {
            //Add Tests
            [TestMethod]
            public void NULLAdd()
            {
                IJob testJob = null;
                IJobCollection testJobCollection = new JobCollection(3);
                Assert.IsFalse(testJobCollection.Add(testJob));
            }

            [TestMethod]
            public void FULLAdd()
            {
                IJob testJob1 = null;
                IJob testJob2 = null;
                IJobCollection testJobCollection = new JobCollection(1);
                testJobCollection.Add(testJob1);
                Assert.IsFalse(testJobCollection.Add(testJob2));
            }

            [TestMethod]
            public void DUPEAdd()
            {
                IJob testJob1 = new Job(543, 92, 27, 7);
                IJob testJob2 = new Job(543, 92, 27, 7);
                IJobCollection testJobCollection = new JobCollection(2);
                testJobCollection.Add(testJob1);
                Assert.IsFalse(testJobCollection.Add(testJob2));
            }
        }
    }
}