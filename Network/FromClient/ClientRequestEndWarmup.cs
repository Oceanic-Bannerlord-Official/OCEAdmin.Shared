using OCEAdmin.Shared.Network.Attributes;
using OCEAdmin.Shared.Network.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCEAdmin.Shared.Network.FromClient
{
    [PacketId(9)]
    public class ClientRequestEndWarmup : Packet
    {
        public new int packetId = 9;

        public ClientRequestEndWarmup() { }
    }
}
