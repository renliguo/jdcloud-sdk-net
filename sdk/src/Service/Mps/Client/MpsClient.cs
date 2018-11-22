/*
 * Copyright 2018 JDCLOUD.COM
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http:#www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * 媒体处理 API
 * 媒体处理相关接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Mps.Apis;
using JDCloudSDK.Mps.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Mps.Client
{
    /// <summary>
    ///  媒体处理 API
    ///  媒体处理相关接口
    ///  Mps Api 客户端
    ///</summary>
    public class MpsClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private MpsClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public MpsClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
            this.environment = environment;
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="credentialsProvider">认证信息</param>
        public MpsClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public MpsClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.0.7
        ///</summary>
        public const string ClientVersion = "1.0.7";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "mps.jdcloud-api.com";
        private const string serviceName = "mps";
        private const string userAgent = userAgentPrefix + "/" + ClientVersion + " " + serviceName + "/" + apiVersion;


        private SDKEnvironment environment = new SDKEnvironment(defaultEndpoint);
        private CredentialsProvider credentialsProvider;
        private HttpRequestConfig httpRequestConfig;

        /// <summary>
        ///  获取证书信息
        ///</summary>
        public override CredentialsProvider CredentialsProvider   { get { return credentialsProvider; } }

        /// <summary>
        ///  获取http 客户端配置信息
        ///</summary>
        public override HttpRequestConfig HttpRequestConfig { get { return httpRequestConfig; } }

        /// <summary>
        ///  获取sdk环境配置信息
        ///</summary>
        public override SDKEnvironment SDKEnvironment { get { return environment; } }

        /// <summary>
        ///  获取用户自定义浏览器识别字符串
        ///</summary>
        public override string UserAgent { get { return userAgent; } }

        /// <summary>
        ///  获取服务名称
        ///</summary>
        public override string ServiceName { get { return serviceName; } }

        /// <summary>
        ///  获取版本号
        ///</summary>
        public override string Version { get { return apiVersion; } }



#if NET40||NET35
        /// <summary>
        ///  设置媒体处理通知, 在设置Notification时会对endpoint进行校验, 设置时会对endpoint发一条SubscriptionConfirmation(x-jdcloud-message-type头)的通知, 要求把Message内容进行base64编码返回给系统(body)进行校验
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public SetNotificationResponse SetNotification(SetNotificationRequest request) {
            return  new SetNotificationExecutor().Client(this).Execute<SetNotificationResponse, SetNotificationResult, SetNotificationRequest>(request);
        }
#else
        /// <summary>
        ///  设置媒体处理通知, 在设置Notification时会对endpoint进行校验, 设置时会对endpoint发一条SubscriptionConfirmation(x-jdcloud-message-type头)的通知, 要求把Message内容进行base64编码返回给系统(body)进行校验
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<SetNotificationResponse> SetNotification(SetNotificationRequest request) {
            return await new SetNotificationExecutor().Client(this).Execute<SetNotificationResponse, SetNotificationResult, SetNotificationRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取截图通知
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetNotificationResponse GetNotification(GetNotificationRequest request) {
            return  new GetNotificationExecutor().Client(this).Execute<GetNotificationResponse, GetNotificationResult, GetNotificationRequest>(request);
        }
#else
        /// <summary>
        ///  获取截图通知
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetNotificationResponse> GetNotification(GetNotificationRequest request) {
            return await new GetNotificationExecutor().Client(this).Execute<GetNotificationResponse, GetNotificationResult, GetNotificationRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建截图任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateThumbnailTaskResponse CreateThumbnailTask(CreateThumbnailTaskRequest request) {
            return  new CreateThumbnailTaskExecutor().Client(this).Execute<CreateThumbnailTaskResponse, CreateThumbnailTaskResult, CreateThumbnailTaskRequest>(request);
        }
#else
        /// <summary>
        ///  创建截图任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateThumbnailTaskResponse> CreateThumbnailTask(CreateThumbnailTaskRequest request) {
            return await new CreateThumbnailTaskExecutor().Client(this).Execute<CreateThumbnailTaskResponse, CreateThumbnailTaskResult, CreateThumbnailTaskRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取截图任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetThumbnailTaskResponse GetThumbnailTask(GetThumbnailTaskRequest request) {
            return  new GetThumbnailTaskExecutor().Client(this).Execute<GetThumbnailTaskResponse, GetThumbnailTaskResult, GetThumbnailTaskRequest>(request);
        }
#else
        /// <summary>
        ///  获取截图任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetThumbnailTaskResponse> GetThumbnailTask(GetThumbnailTaskRequest request) {
            return await new GetThumbnailTaskExecutor().Client(this).Execute<GetThumbnailTaskResponse, GetThumbnailTaskResult, GetThumbnailTaskRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询截图任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ListThumbnailTaskResponse ListThumbnailTask(ListThumbnailTaskRequest request) {
            return  new ListThumbnailTaskExecutor().Client(this).Execute<ListThumbnailTaskResponse, ListThumbnailTaskResult, ListThumbnailTaskRequest>(request);
        }
#else
        /// <summary>
        ///  查询截图任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ListThumbnailTaskResponse> ListThumbnailTask(ListThumbnailTaskRequest request) {
            return await new ListThumbnailTaskExecutor().Client(this).Execute<ListThumbnailTaskResponse, ListThumbnailTaskResult, ListThumbnailTaskRequest>(request);
        }
#endif

            /// <summary>
            ///  默认MpsClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>mpsClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>mpsClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>mpsClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造MpsClient 对象
                ///</summary>
                MpsClient Build();
            }

            /// <summary>
            ///  默认MpsClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  MpsClient service client
                /// </summary>
                private  MpsClient mpsClient;

                /// <summary>
                ///  默认MpsClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    mpsClient = new MpsClient();
                }

                /// <summary>
                ///  构造MpsClient 对象
                ///</summary>
                public MpsClient Build()
                {
                    if (mpsClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        mpsClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (mpsClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("MpsClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (mpsClient.HttpRequestConfig == null)
                    {
                        mpsClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (mpsClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("MpsClient build error: http request config not set");
                        }
                    }
                    return mpsClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>mpsClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    mpsClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>mpsClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    mpsClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>mpsClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    mpsClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
