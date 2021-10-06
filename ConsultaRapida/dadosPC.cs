using System;
using System.Net;
using System.Net.Sockets;

namespace ConsultaRapida
{
    class dadosPC
    {
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Nenhum adaptador de rede com um endereço IPv4 no sistema!");

        }

    }
}
