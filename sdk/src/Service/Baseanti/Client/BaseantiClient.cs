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
 * 京东云DDoS基础防护相关接口
 * 京东云DDoS基础防护相关接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Baseanti.Apis;
using JDCloudSDK.Baseanti.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Baseanti.Client
{
    /// <summary>
    ///  京东云DDoS基础防护相关接口
    ///  京东云DDoS基础防护相关接口
    ///  Baseanti Api 客户端
    ///</summary>
    public class BaseantiClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private BaseantiClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public BaseantiClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public BaseantiClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public BaseantiClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.0.9
        ///</summary>
        public const string ClientVersion = "1.0.9";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "baseanti.jdcloud-api.com";
        private const string serviceName = "baseanti";
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
        ///  设置公网Ip的清洗阈值
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public SetCleanThresholdResponse SetCleanThreshold(SetCleanThresholdRequest request) {
            return  new SetCleanThresholdExecutor().Client(this).Execute<SetCleanThresholdResponse, SetCleanThresholdResult, SetCleanThresholdRequest>(request);
        }
#else
        /// <summary>
        ///  设置公网Ip的清洗阈值
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<SetCleanThresholdResponse> SetCleanThreshold(SetCleanThresholdRequest request) {
            return await new SetCleanThresholdExecutor().Client(this).Execute<SetCleanThresholdResponse, SetCleanThresholdResult, SetCleanThresholdRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询区域下的公网Ip资源列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeIpResourcesResponse DescribeIpResources(DescribeIpResourcesRequest request) {
            return  new DescribeIpResourcesExecutor().Client(this).Execute<DescribeIpResourcesResponse, DescribeIpResourcesResult, DescribeIpResourcesRequest>(request);
        }
#else
        /// <summary>
        ///  查询区域下的公网Ip资源列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeIpResourcesResponse> DescribeIpResources(DescribeIpResourcesRequest request) {
            return await new DescribeIpResourcesExecutor().Client(this).Execute<DescribeIpResourcesResponse, DescribeIpResourcesResult, DescribeIpResourcesRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询公网Ip的监控流量
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeIpResourceFlowResponse DescribeIpResourceFlow(DescribeIpResourceFlowRequest request) {
            return  new DescribeIpResourceFlowExecutor().Client(this).Execute<DescribeIpResourceFlowResponse, DescribeIpResourceFlowResult, DescribeIpResourceFlowRequest>(request);
        }
#else
        /// <summary>
        ///  查询公网Ip的监控流量
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeIpResourceFlowResponse> DescribeIpResourceFlow(DescribeIpResourceFlowRequest request) {
            return await new DescribeIpResourceFlowExecutor().Client(this).Execute<DescribeIpResourceFlowResponse, DescribeIpResourceFlowResult, DescribeIpResourceFlowRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询公网Ip的防护明细
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeIpResourceProtectInfoResponse DescribeIpResourceProtectInfo(DescribeIpResourceProtectInfoRequest request) {
            return  new DescribeIpResourceProtectInfoExecutor().Client(this).Execute<DescribeIpResourceProtectInfoResponse, DescribeIpResourceProtectInfoResult, DescribeIpResourceProtectInfoRequest>(request);
        }
#else
        /// <summary>
        ///  查询公网Ip的防护明细
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeIpResourceProtectInfoResponse> DescribeIpResourceProtectInfo(DescribeIpResourceProtectInfoRequest request) {
            return await new DescribeIpResourceProtectInfoExecutor().Client(this).Execute<DescribeIpResourceProtectInfoResponse, DescribeIpResourceProtectInfoResult, DescribeIpResourceProtectInfoRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询公网Ip基本信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeIpResourceInfoResponse DescribeIpResourceInfo(DescribeIpResourceInfoRequest request) {
            return  new DescribeIpResourceInfoExecutor().Client(this).Execute<DescribeIpResourceInfoResponse, DescribeIpResourceInfoResult, DescribeIpResourceInfoRequest>(request);
        }
#else
        /// <summary>
        ///  查询公网Ip基本信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeIpResourceInfoResponse> DescribeIpResourceInfo(DescribeIpResourceInfoRequest request) {
            return await new DescribeIpResourceInfoExecutor().Client(this).Execute<DescribeIpResourceInfoResponse, DescribeIpResourceInfoResult, DescribeIpResourceInfoRequest>(request);
        }
#endif

            /// <summary>
            ///  默认BaseantiClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>baseantiClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>baseantiClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>baseantiClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造BaseantiClient 对象
                ///</summary>
                BaseantiClient Build();
            }

            /// <summary>
            ///  默认BaseantiClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  BaseantiClient service client
                /// </summary>
                private  BaseantiClient baseantiClient;

                /// <summary>
                ///  默认BaseantiClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    baseantiClient = new BaseantiClient();
                }

                /// <summary>
                ///  构造BaseantiClient 对象
                ///</summary>
                public BaseantiClient Build()
                {
                    if (baseantiClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        baseantiClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (baseantiClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("BaseantiClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (baseantiClient.HttpRequestConfig == null)
                    {
                        baseantiClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (baseantiClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("BaseantiClient build error: http request config not set");
                        }
                    }
                    return baseantiClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>baseantiClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    baseantiClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>baseantiClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    baseantiClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>baseantiClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    baseantiClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
