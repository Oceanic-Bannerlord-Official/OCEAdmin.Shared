using OCEAdmin.Shared.Network.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCEAdmin.Shared.Network.FromClient
{
    [PacketId(15)]
    public class ClientRequestSwapSides : Packet
    {
        public new int packetId = 15;

        public ClientRequestSwapSides() { }
    }
}
