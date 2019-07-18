﻿using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Extensions;
using System;
using System.Net.Http;

namespace SDKTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            HttpClientWrapper httpClientWrapper = httpClient.DoSign(new JDCloudSDK.Core.Auth.Credentials("ak", "sk"), "xohk7ybhwien");
            HttpResponseMessage httpResponseMessage = httpClientWrapper.GetAsync("http://xohk7ybhwien.cn-north-1.jdcloud-api.net:8000/todo/api/v1/tasks/getAllOrUniqueTask").Result;
            if (httpResponseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = httpResponseMessage.Content.ReadAsStringAsync().Result;
                Console.WriteLine(result);
            }
            //Credentials credentials = new Credentials("ak", "ak");
            //HttpResponseMessage httpResponseMessage = httpClient.DoSign(credentials, "vm", null, new DateTime(2019, 7, 18, 2, 22, 22)).GetAsync("http://apigw-internal.cn-north-1.jcloudcs.com/v1/regions/cn-north-1/instances").Result;
            //if (httpResponseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            //{
            //    var result = httpResponseMessage.Content.ReadAsStringAsync().Result;
            //    Console.WriteLine(result);
            //}
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
