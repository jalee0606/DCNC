using System;
using System.IO;
using Shared.Util;

namespace Shared.Network.GameServer
{
    public class UpgradeCarAnswer : OutPacket
    {
        public UpgradeCarAnswer()
        {
        }

        public override Packet CreatePacket()
        {
            return base.CreatePacket(Packets.UpgradeCarAck);
        }

        public override int ExpectedSize()
        {
            return base.ExpectedSize();
        }

        public override byte[] GetBytes()
        {
            using(var ms = new MemoryStream())
            {
                using (var bs = new BinaryWriterExt(ms))
                {
                }
                return ms.ToArray();
            }
        }
    }
}
