using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataArgs;


[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void CaseWithoutArgsLoginReturnsFalse()
    {
        string argument = "";
        ARGS a = new ARGS();

        a.main(argument.Split(' '));

        Assert.AreEqual(false, a.hasLogin);
    }
    [TestMethod]
    public void CaseWithLoginReturnsTrue()
    {
        string argument = "-l";
        ARGS a = new ARGS();

        a.main(argument.Split(' '));

        Assert.AreEqual(true, a.hasLogin);
    }

    [TestMethod]
    public void CaseWithoutAnyArgumentsReturnsFalse()
    {
        string argument = "ñlakjsdfñlkjasdf";
        ARGS a = new ARGS();

        a.main(argument.Split(' '));

        Assert.AreEqual(false, a.hasLogin);
        Assert.AreEqual(false, a.hasPort);
        Assert.AreEqual(false, a.hasDirectory);
    }
    [TestMethod]
    public void CaseWithPortReturnsTrue()
    {
        string arguments = "-p 8080";
        ARGS a = new ARGS();

        a.main(arguments.Split(' '));

        Assert.AreEqual(true, a.hasPort);
    }

    [TestMethod]
    public void CaseWithLoginAndPortReturnBothTrue()
    {
        string arguments = "-l -p 5657";
        ARGS a = new ARGS();

        a.main(arguments.Split(' '));

        Assert.AreEqual(true, a.hasLogin);
        Assert.AreEqual(true, a.hasPort);
    }

    [TestMethod]
    public void CaseWithLoginAndPortReturnsLoginTruePortFalse()
    {
        string arguments = "-l -p ";
        ARGS a = new ARGS();

        a.main(arguments.Split(' '));

        Assert.AreEqual(true, a.hasLogin);
        Assert.AreEqual(false, a.hasPort);
    }
    [TestMethod]
    public void CaseWithDirectoryReturnsTrue()
    {
        string arguments = "-l -p 232 -d /logs";
        ARGS a = new ARGS();

        a.main(arguments.Split(' '));

        Assert.AreEqual(true, a.hasDirectory);
    }
    [TestMethod]
    public void CaseWithDirectoryArgWithoutDirectoryReturnsFalse()
    {
        string arguments = "-l -p 232 -d";
        ARGS a = new ARGS();

        a.main(arguments.Split(' '));

        Assert.AreEqual(false, a.hasDirectory);

    }
    [TestMethod]
    public void CaseWithoutLoginWithDirectoryArgAndPortReturnsBothTrue()
    {
        string arguments = "-p 232 -d /logs";
        ARGS a = new ARGS();

        a.main(arguments.Split(' '));

        Assert.AreEqual(true, a.hasDirectory);
        Assert.AreEqual(true, a.hasPort);
        Assert.AreEqual(false, a.hasLogin);

    }
    [TestMethod]
    public void CaseWithoutPortWithDirectoryArgAndLoginReturnsBothTrue()
    {
        string arguments = "-l -d /logs";
        ARGS a = new ARGS();

        a.main(arguments.Split(' '));

        Assert.AreEqual(true, a.hasDirectory);
        Assert.AreEqual(false, a.hasPort);
        Assert.AreEqual(true, a.hasLogin);

    }

}