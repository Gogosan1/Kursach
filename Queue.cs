using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMainForm
{
    static public class Queue
    {
        private static List<ClientsRequest> clientsRequests;

        static Queue ()
        {
            clientsRequests = new List<ClientsRequest> ();
        }

        public static void AddAnRequest(ClientsRequest request)
        {
            clientsRequests.Add(request);
         }
        public static void RemoveRequest (ClientsRequest request)
        {
            clientsRequests.Remove(request);
        }

        public static List<ClientsRequest> ClientsRequests()
        {
            return clientsRequests;
        }
    }
}
