using OCEAdmin.Shared.Network.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OCEAdmin.Shared.Network
{
    public static class PacketRegistry
    {
        public static Dictionary<int, Type> storage = new Dictionary<int, Type>();

        public static void LoadNetworkPackets()
        {
            foreach (Type networkPacketType in Assembly.GetExecutingAssembly().GetTypes().Where(myType => myType.IsSubclassOf(typeof(Packet))))
            {
                Packet packet = Activator.CreateInstance(networkPacketType) as Packet;

                PacketIdAttribute packetIdAttribute = networkPacketType.GetCustomAttribute<PacketIdAttribute>();

                if (packetIdAttribute != null)
                {
                    int packetId = packetIdAttribute.PacketId;
                    storage[packetId] = networkPacketType;
                }
            }
        }
    }
}
