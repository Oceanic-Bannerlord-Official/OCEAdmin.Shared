using OCEAdmin.Shared.Network.Attributes;
using OCEAdmin.Shared.Network.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCEAdmin.Shared.Network.FromClient
{
    [PacketId(6)]
    public class ClientUpdateRoundTime : Packet
    {
        public int roundTime;

        public new int packetId = 6;

        public ClientUpdateRoundTime() { }

        public ClientUpdateRoundTime(int roundTime)
        {
            this.roundTime = roundTime;
        }
    }
}
