using System.Collections.Generic;
using System.IO;
using AntShares.Cryptography.ECC;

namespace AntShares.Core
{
    public interface IAccountState
    {
        Dictionary<UInt256, Fixed8> Balances { get; set; }
        bool IsFrozen { get; set; }
        UInt160 ScriptHash { get; set; }        
        ECPoint[] Votes { get; set; }
        int Size { get; }

        void Deserialize(BinaryReader reader);
        void Serialize(BinaryWriter writer);
    }
}