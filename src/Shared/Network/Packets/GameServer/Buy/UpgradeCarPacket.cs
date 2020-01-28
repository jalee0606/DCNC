using System;
namespace Shared.Network.GameServer
{
    public class UpgradeCarPacket
    {
        public readonly uint CarId;
        public readonly ulong Cash;
        public readonly bool UseMileage;

        public UpgradeCarPacket(Packet packet)
        {
            CarId = packet.Reader.ReadUInt32();
            Cash = packet.Reader.ReadUInt64();
            UseMileage = packet.Reader.ReadBoolean();
        }
    }
}
