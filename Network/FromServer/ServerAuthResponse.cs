using Newtonsoft.Json;
using OCEAdmin.Shared.Network.Attributes;
using System.Net.Http;
using System.Threading.Tasks;

namespace OCEAdmin.Shared.Network.FromServer
{
    [PacketId(2)]
    public class ServerAuthResponse : Packet
    {
        public new int packetId = 2;

        public bool isAuthed;

        public ServerAuthResponse() { }

        public ServerAuthResponse(bool authed) 
        {
            isAuthed = authed;
        }
    }
}
