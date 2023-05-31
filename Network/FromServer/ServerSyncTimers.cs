using OCEAdmin.Shared.Network.Attributes;
using OCEAdmin.Shared.Network.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCEAdmin.Shared.Network.FromServer
{
    [PacketId(10)]
    public class ServerSyncTimers : Packet
    {
        public new int packetId = 10;

        public int warmupTime;
        public int mapTime;
        public int roundTime;

        public ServerSyncTimers() { }

        public ServerSyncTimers(int warmupTime, int mapTime, int roundTime) 
        {
            this.warmupTime = warmupTime;
            this.mapTime = mapTime; 
            this.roundTime = roundTime;
        }
    }
}
