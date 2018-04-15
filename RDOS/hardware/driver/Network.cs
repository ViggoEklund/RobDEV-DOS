using System;
using System.Collections.Generic;
using System.Text;
using sn = Cosmos.System.Network;
using hn = Cosmos.HAL.Network;
using Cosmos.HAL;
using Cosmos.HAL.Drivers.PCI.Network;

namespace RDOS
{
    class Network
    {

        public static string GetMACAddress()
        {
            return Cosmos.HAL.Network.MACAddress.Broadcast + "";
        }

        public static void init()
        {
            
        }

        public static void sss()
        {
            var udp = new Cosmos.System.Network.UdpClient();
           
        }

        public static bool NetworkCardAvailable()
        {
            PCIDevice device;
            device = PCI.GetDevice(VendorID.AMD, DeviceID.PCNETII);
            if (device != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
