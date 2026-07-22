using System;
using ZowieCrestron;
using ZowieCrestron.Models;
using ZowieCrestron.Models.Ndi;

namespace ZowieConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ZowieApiConfig("http://10.2.254.25", "1");

            using (var client = new ZowieApiClient(config))
            {
                Console.WriteLine("Starting NDI stream 'MyStream' on 10.2.254.25...");

                var request = new NdiRecvRequest
                {
                    Data = new NdiRecvRequest.NdiRecvData
                    {
                        NdiName = "MyStream"
                    }
                };

                var response = client.PostStreamplay<NdiRecvRequest, SuccessResponse>(request);

                if (response.IsSuccess)
                    Console.WriteLine("NDI stream started successfully.");
                else
                    Console.WriteLine("Failed. Status: {0}, Response: {1}", response.Status, response.Rsp);
            }
        }
    }
}
