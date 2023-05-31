using Newtonsoft.Json;
using OCEAdmin.Shared.Network.Attributes;
using System.Net.Http;
using System.Threading.Tasks;

namespace OCEAdmin.Shared.Network.FromClient
{
    [PacketId(1)]
    public class ClientRequestAuth : Packet
    {
        public string gameID { get; set;}
        public string steamID { get; set;}
        public string steamTicket { get; set;}
        public new int packetId = 1;

        public ClientRequestAuth() { }
        public ClientRequestAuth(string gameID, string steamID, string steamTicket)
        {
            this.gameID = gameID;
            this.steamID = steamID;
            this.steamTicket = steamTicket;
        }
    }
}
