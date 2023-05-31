using OCEAdmin.Shared.Network.Attributes;
using OCEAdmin.Shared.Network.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCEAdmin.Shared.Network.FromClient
{
    [PacketId(5)]
    public class ClientRequestMission : Packet
    {
        public MissionData missionData;

        public new int packetId = 5;

        public ClientRequestMission() { }

        public ClientRequestMission(MissionData missionData) 
        { 
            this.missionData = missionData;
        }
    }
}
