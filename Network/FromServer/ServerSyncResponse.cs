using OCEAdmin.Shared.Network.Attributes;
using OCEAdmin.Shared.Network.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCEAdmin.Shared.Network.FromServer
{
    [PacketId(4)]
    public class ServerSyncResponse : Packet
    {
        public new int packetId = 4;

        public Dictionary<string, List<string>> Maps;

        public MissionData missionData;

        public ServerSyncResponse() { }
    }
}
