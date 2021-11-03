using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using GrpcServices.Azure;
using GrpcServices.Yapi;
using Wathet.Grpc.Azure;

using Google.Protobuf;

namespace GrpcClient
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}

        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            //var t = Google.Protobuf.WellKnownTypes.BoolValue.Descriptor;
            //using var channel = GrpcChannel.ForAddress("https://localhost:4451");
            //var client = new ApisService.ApisServiceClient(channel);
            //var updateRequest = new UpdateApisParameter
            //{
            //    ApiId = "e5fdcd4a9c384f75bc67dea9a443ab1a",
            //    RequestBody = new UpdateApisRequest
            //    {
            //        Properties = new UpdateApis()
            //        {
            //            DisplayName = "测试新的API显示名称",
            //            Description = "00000",
            //            ApiRevision = "ApiRevision",
            //            Protocols = { "312", "4" },
            //            AuthenticationSettings = new AuthenticationSettingsContract
            //            {
            //                OAuth2 = new OAuth2AuthenticationSettingsContract
            //                {
            //                    AuthorizationServerId = "1"
            //                },
            //                Openid = new OpenIdAuthenticationSettingsContract
            //                {
            //                    BearerTokenSendingMethods = { "ff", "dd" }
            //                }
            //            }
            //        }
            //    }
            //};

            //var reply = await client.UpdateAsync(updateRequest);



            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new InterfaceService.InterfaceServiceClient(channel);
            var newApi = new InterfaceParameter()
            {
                Method = "GET",
                Catid = "226",
                Title = "gRPC测试",
                Path = "23123ds",
                ResBodyType = "json"
            };
            //{ "method":"GET","catid":"226","title":"大小写测试","path":"/3333331df","project_id":"389"}
            var reply = await client.AddAsync(newApi);





            Thread.Sleep(5000);
            Console.ReadKey();
        }
    }
}
