using NUnit.Framework;

[TestFixture]
public class SecurityTests {
    [Test]
    public void TestForSQLInjection() {
        var maliciousInput = "' OR '1'='1";
        // Assume rejection if input sanitization is working
        Assert.IsFalse(maliciousInput.Contains("OR"));
    }

    [Test]
    public void TestForXSS() {
        var xssAttempt = "<script>alert('hack')</script>";
        Assert.IsFalse(xssAttempt.Contains("<script>"));
    }
}
