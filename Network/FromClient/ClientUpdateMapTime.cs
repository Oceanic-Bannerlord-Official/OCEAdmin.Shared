using OCEAdmin.Shared.Network.Attributes;
using OCEAdmin.Shared.Network.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCEAdmin.Shared.Network.FromClient
{
    [PacketId(8)]
    public class ClientUpdateMapTime : Packet
    {
        public int mapTime;

        public new int packetId = 8;

        public ClientUpdateMapTime() { }

        public ClientUpdateMapTime(int mapTime)
        {
            this.mapTime = mapTime;
        }
    }
}
