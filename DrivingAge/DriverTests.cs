using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

[TestFixture]
public class DriverTests
{
    // Test for age less than the minimum driving age.
    [Test]
    public void CanDrive_AgeLessThan16_ReturnsFalse()
    {
        var result = Program.CanDrive(15);
        Assert.IsFalse(result, "Expected false because age is less than 16.");
    }

    // Test for the exact minimum driving age.
    [Test]
    public void CanDrive_Age16_ReturnsTrue()
    {
        var result = Program.CanDrive(16);
        Assert.IsTrue(result, "Expected true because age is exactly 16.");
    }

    // Test for age greater than the minimum driving age.
    [Test]
    public void CanDrive_AgeMoreThan16_ReturnsTrue()
    {
        var result = Program.CanDrive(17);
        Assert.IsTrue(result, "Expected true because age is greater than 16.");
    }

    // Test for age just below the minimum driving age.
    [Test]
    public void CanDrive_AgeJustBelowDrivingAge_ReturnsFalse()
    {
        var result = Program.CanDrive(15);
        Assert.IsFalse(result, "Expected false because age is just below 16.");
    }

    // Test for age just above the minimum driving age.
    [Test]
    public void CanDrive_AgeJustAboveDrivingAge_ReturnsTrue()
    {
        var result = Program.CanDrive(17);
        Assert.IsTrue(result, "Expected true because age is just above 16.");
    }

    // Test for age zero.
    [Test]
    public void CanDrive_AgeZero_ReturnsFalse()
    {
        var result = Program.CanDrive(0);
        Assert.IsFalse(result, "Expected false because age is 0, which is less than 16.");
    }

    // Test for negative age.
    [Test]
    public void CanDrive_NegativeAge_ReturnsFalse()
    {
        var result = Program.CanDrive(-1);
        Assert.IsFalse(result, "Expected false because negative age is invalid and less than 16.");
    }

    // Test for an unusually high age.
    [Test]
    public void CanDrive_AgeOneHundred_ReturnsTrue()
    {
        var result = Program.CanDrive(100);
        Assert.IsTrue(result, "Expected true because age is much greater than 16.");
    }

    // Deliberately failing test to demonstrate assertion failure message.
    [Test]
    public void CanDrive_AgeTwenty_ReturnsFalse_FailingTest()
    {
        var result = Program.CanDrive(20);
        Assert.IsFalse(result, "Expected false because this is a failing test example where age is 20, which should actually return true.");
    }
}
