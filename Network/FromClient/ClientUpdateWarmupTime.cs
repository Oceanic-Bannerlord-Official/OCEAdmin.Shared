using OCEAdmin.Shared.Network.Attributes;
using OCEAdmin.Shared.Network.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCEAdmin.Shared.Network.FromClient
{
    [PacketId(7)]
    public class ClientUpdateWarmupTime : Packet
    {
        public int warmupTime;

        public new int packetId = 7;

        public ClientUpdateWarmupTime() { }

        public ClientUpdateWarmupTime(int warmupTime)
        {
            this.warmupTime = warmupTime;
        }
    }
}
