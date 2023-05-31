using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCEAdmin.Shared.Network.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class PacketIdAttribute : Attribute
    {
        public int PacketId { get; }

        public PacketIdAttribute(int packetId)
        {
            PacketId = packetId;
        }
    }
}
