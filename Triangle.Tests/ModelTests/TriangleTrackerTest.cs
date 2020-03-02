using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
    public void Tracker_IsANumber_True()
    {
      TriangleTracker triangleTrackerTests = new TriangleTracker();
      Assert.AreEqual(true, triangleTrackerTests.SideCheck("5"));
    }

    [TestMethod]
    public void Tracker_IsANumber_False()
    {
      TriangleTracker triangleTrackerTests = new TriangleTracker();
      Assert.AreEqual(false, triangleTrackerTests.SideCheck("w"));
    }

    [TestMethod]
    public void Tracker_IsTriangle_False()
    {
      TriangleTracker triangleTrackerTests = new TriangleTracker();
      Assert.AreEqual(false, triangleTrackerTests.IsTri(9, 2, 2));
    }

    [TestMethod]
    public void Tracker_IsEqualateralTriangle_True()
    {
      TriangleTracker triangleTrackerTests = new TriangleTracker();
      Assert.AreEqual(true, triangleTrackerTests.IsTri(3,3,3));
    }

    [TestMethod]
    public void Tracker_IsIsoscelesTriangle_True()
    {
      TriangleTracker triangleTrackerTests = new TriangleTracker();
      Assert.AreEqual(true, triangleTrackerTests.IsTri(4, 4, 3));
    }

    [TestMethod]
    public void Tracker_IsScalene_True()
    {
      TriangleTracker triangleTrackerTests = new TriangleTracker();
      Assert.AreEqual(true, triangleTrackerTests.IsTri(3,4,5));
    }
  }
}