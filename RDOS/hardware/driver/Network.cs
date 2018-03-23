using System;
using System.Collections.Generic;
using System.Text;
using sn = Cosmos.System.Network;
using hn = Cosmos.HAL.Network;

namespace RDOS
{
    class Network
    {
        
        public static void init()
        {
            Cosmos.System.Network.NetworkStack.Init();
        }
        public static string getip()
        {
            return "error not done yet ";
        }
    }
}
