using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using Domen;

namespace Server
{
    public class Server
    {
        Socket soket;
        public static List<NetworkStream> listaTokova = new List<NetworkStream>();

        public bool PokreniServer()
        {
            try
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                EndPoint ep = new IPEndPoint(IPAddress.Any, 20000);
                soket.Bind(ep);

                ThreadStart ts = Osluskuj;
                Thread nit = new Thread(ts);
                nit.Start();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Osluskuj()
        {
            try
            {
                soket.Listen(6);
                while (true)
                {
                    Socket klijent = soket.Accept();
                    NetworkStream tok = new NetworkStream(klijent);
                    listaTokova.Add(tok);
                    new Obrada(tok);
                }
            }
            catch (Exception)
            {
                //throw;
            }
        }
        public bool ZaustaviServer()
        {
            try
            {
                soket.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
