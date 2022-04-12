using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Infrastructure.Utilities
{
    public class CatchIP
    {
        public static string GetIpAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "Local ip address has not found..!";
        }

        //Yukarıdaki fonksiyonun sonucunu bize çıkaracak property

        public static string IpAddress
        {
            get
            {
                return GetIpAddress();
            }
        }
    }
}
