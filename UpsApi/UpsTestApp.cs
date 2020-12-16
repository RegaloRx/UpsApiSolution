using System;
using UpsRestApi;
using UpsQVResponseLib;

namespace UpsApp
{
    class UpsTestApp
    {
        static void Main(string[] args)
        {
            string url = "https://onlinetools.ups.com/rest/QVEvents";
            string response = "";


            QvRoot qvRoot = UpsApi.GetQuantumView("RegaloRxIT", "R3g@L0rx$$", "6D8E7C615F055692", url);
            Console.Write(response);
        }
    }
}
