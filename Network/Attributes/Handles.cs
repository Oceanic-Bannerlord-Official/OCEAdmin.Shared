using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCEAdmin.Shared.Network.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class Handles : Attribute
    {
        public Type Packet { get; }

        public Handles(Type packet)
        {
            Packet = packet;
        }
    }
}
