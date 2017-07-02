using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AntShares.Core;
using FluentAssertions;

namespace AntShares.UnitTests
{
    [TestClass]
    public class UT_AccountState
    {
        AccountState uut;

        [TestInitialize]
        public void TestSetup()
        {
            uut = new AccountState();
        }

        [TestMethod]
        public void ScriptHash_Get()
        {
            uut.ScriptHash.Should().BeNull();
        }

        [TestMethod]
        public void ScriptHash_Set()
        {
            UInt160 val = new UInt160();
            uut.ScriptHash = val;

            uut.ScriptHash.Should().Be(val);
        }
    }
}
