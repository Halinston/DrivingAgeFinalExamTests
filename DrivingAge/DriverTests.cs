
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

public class DriverTests
{
    [Test]
    public void CanDrive_AgeLessThan16_ReturnsFalse()
    {
        var result = Program.CanDrive(15);
        Assert.IsFalse(result);
    }

    [Test]
    public void CanDrive_Age16_ReturnsTrue()
    {
        var result = Program.CanDrive(16);
        Assert.IsTrue(result);
    }

    [Test]
    public void CanDrive_AgeMoreThan16_ReturnsTrue()
    {
        var result = Program.CanDrive(17);
        Assert.IsTrue(result);
    }
}