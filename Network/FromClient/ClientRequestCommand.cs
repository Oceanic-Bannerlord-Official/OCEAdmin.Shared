using OCEAdmin.Shared.Network.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCEAdmin.Shared.Network.FromClient
{
    [PacketId(14)]
    public class ClientRequestCommand : Packet
    {
        public string command;
        public string[] args;

        public new int packetId = 14;

        public ClientRequestCommand() { }

        public ClientRequestCommand(string command)
        {
            this.command = command;
        }
    }
}
