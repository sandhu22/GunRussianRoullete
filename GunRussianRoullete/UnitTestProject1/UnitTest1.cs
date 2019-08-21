using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GunRussianRoullete;
namespace UnitTestProject1
{
    
    [TestClass]
    public class UnitTest1
    {
        gameclass unitTestobj = new gameclass();
        //coding for equal testing
        [TestMethod]
        public void TestAwaybulleteMissed()
        {
            var act = unitTestobj.AwaybulleteMissed(5);
            Assert.AreEqual(expected: 6, act);
        }

        // coding for not equal testing
        public void TestAwaybulletMissed()
        {
            var act = unitTestobj.AwaybulleteMissed(5);
            Assert.AreNotEqual(notExpected: 6, act);
        }
    }
}
