using System;
using UpsRestApi;
using UpsQVResponseLib;

namespace UpsApp
{
    class UpsTestApp
    {
        static void Main(string[] args)
        {
            string url = "https://wwwcie.ups.com/rest/QVEvents";
            string response = "";

            QvRoot qvRoot = UpsApi.GetQuantumView(url);
            Console.Write(response);
        }
    }
}
