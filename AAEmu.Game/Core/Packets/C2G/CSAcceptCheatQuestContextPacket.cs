using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSAcceptCheatQuestContextPacket : GamePacket
    {
        public CSAcceptCheatQuestContextPacket() : base(0x0d5, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var questId = stream.ReadUInt32();
            _log.Debug("AcceptCheatQuestContext, Id: {0}", questId);
        }
    }
}