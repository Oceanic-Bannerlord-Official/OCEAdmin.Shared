using OCEAdmin.Shared.Network.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OCEAdmin.Shared.Network.FromClient
{
    [PacketId(3)]
    public class ClientRequestSync : Packet
    {
        public new int packetId = 3;

        public ClientRequestSync() { }
    }
}
