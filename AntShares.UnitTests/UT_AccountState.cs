using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AntShares.Core;
using FluentAssertions;
using AntShares.Cryptography.ECC;
using System.Collections.Generic;

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

        [TestMethod]
        public void IsFrozen_Get()
        {
            uut.IsFrozen.Should().Be(false);
        }

        [TestMethod]
        public void IsFrozen_Set()
        {            
            uut.IsFrozen = true;
            uut.IsFrozen.Should().Be(true);
        }

        [TestMethod]
        public void Votes_Get()
        {
            uut.Votes.Should().BeNull();
        }

        [TestMethod]
        public void Votes_Set()
        {
            ECPoint val = new ECPoint();
            ECPoint[] array = new ECPoint[] { val };
            uut.Votes = array;
            uut.Votes[0].Should().Be(val);
        }

        [TestMethod]
        public void Balances_Get()
        {
            uut.Balances.Should().BeNull();
        }

        [TestMethod]
        public void Balances_Set()
        {
            UInt256 key = new UInt256();
            Fixed8 val = new Fixed8();
            Dictionary<UInt256, Fixed8> dict = new Dictionary<UInt256, Fixed8>();
            dict.Add(key, val);
            uut.Balances = dict;
            uut.Balances[key].Should().Be(val);
        }

        [TestMethod]
        public void Size_Get_0_Votes_0_Balances()
        {
            UInt160 val = new UInt160();        
            ECPoint[] array = new ECPoint[0];
            Dictionary<UInt256, Fixed8> dict = new Dictionary<UInt256, Fixed8>();

            uut.ScriptHash = val;
            uut.Votes = array;
            uut.Balances = dict;

            uut.Size.Should().Be(24); // 1 + 20 + 1 + 1 + 1 + 0 * (32 + 8)
        }
    }
}
