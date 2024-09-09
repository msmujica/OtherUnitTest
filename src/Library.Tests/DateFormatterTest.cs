using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.TestDateFormat;

namespace Library.Tests;

[TestClass]
[TestSubject(typeof(DateFormatter))]
public class DateFormatterTest
{

    [TestMethod]
    public void METHOD()
    {
    }
    
    [TestMethod]
    public void TestChangeFormate()
    {
        string date = "06-01-2005";
        string correctDate = "2005-01-06";
        
        Assert.AreEqual(DateFormatter.ChangeFormat(date), correctDate);
    }

}