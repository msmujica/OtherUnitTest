using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.TestDateFormat;

namespace Library2.Tests;

[TestClass]
[TestSubject(typeof(DateFormatter))]
public class DateFormatterTest
{

    [TestMethod]
    public void METHOD()
    {
    }

    [TestMethod]
    public void TestCorrectFormat()
    {
        string date = "06/01/2005";
        string expected = "2005-01-06";
        string result = DateFormatter.ChangeFormat(date);
        
        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestIncorrectFormat()
    {
        string date = "61-01-2005";
        string result = DateFormatter.ChangeFormat(date);
        
        Assert.AreEqual(result, "x");
    }
    

    [TestMethod]
    public void TestEmptySpace()
    {
        string date = "";
        string result = DateFormatter.ChangeFormat(date);
        
        Assert.IsNull(result);
    }
}