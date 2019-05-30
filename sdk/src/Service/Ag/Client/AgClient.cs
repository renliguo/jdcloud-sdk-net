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
 * 高可用组
 * 高可用组相关接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Ag.Apis;
using JDCloudSDK.Ag.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Ag.Client
{
    /// <summary>
    ///  高可用组
    ///  高可用组相关接口
    ///  Ag Api 客户端
    ///</summary>
    public class AgClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private AgClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public AgClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public AgClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public AgClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.1.0
        ///</summary>
        public const string ClientVersion = "1.1.0";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "ag.jdcloud-api.com";
        private const string serviceName = "ag";
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
        ///  修改一个高可用组的信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public UpdateAgResponse UpdateAg(UpdateAgRequest request) {
            return  new UpdateAgExecutor().Client(this).Execute<UpdateAgResponse, UpdateAgResult, UpdateAgRequest>(request);
        }
#else
        /// <summary>
        ///  修改一个高可用组的信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<UpdateAgResponse> UpdateAg(UpdateAgRequest request) {
            return await new UpdateAgExecutor().Client(this).Execute<UpdateAgResponse, UpdateAgResult, UpdateAgRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  根据 id 删除高可用组，需确保 AG 中云主机实例已全部删除
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteAgResponse DeleteAg(DeleteAgRequest request) {
            return  new DeleteAgExecutor().Client(this).Execute<DeleteAgResponse, DeleteAgResult, DeleteAgRequest>(request);
        }
#else
        /// <summary>
        ///  根据 id 删除高可用组，需确保 AG 中云主机实例已全部删除
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteAgResponse> DeleteAg(DeleteAgRequest request) {
            return await new DeleteAgExecutor().Client(this).Execute<DeleteAgResponse, DeleteAgResult, DeleteAgRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改高可用组的实例模板
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public SetInstanceTemplateResponse SetInstanceTemplate(SetInstanceTemplateRequest request) {
            return  new SetInstanceTemplateExecutor().Client(this).Execute<SetInstanceTemplateResponse, SetInstanceTemplateResult, SetInstanceTemplateRequest>(request);
        }
#else
        /// <summary>
        ///  修改高可用组的实例模板
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<SetInstanceTemplateResponse> SetInstanceTemplate(SetInstanceTemplateRequest request) {
            return await new SetInstanceTemplateExecutor().Client(this).Execute<SetInstanceTemplateResponse, SetInstanceTemplateResult, SetInstanceTemplateRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询(ag)配额
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeQuotasResponse DescribeQuotas(DescribeQuotasRequest request) {
            return  new DescribeQuotasExecutor().Client(this).Execute<DescribeQuotasResponse, DescribeQuotasResult, DescribeQuotasRequest>(request);
        }
#else
        /// <summary>
        ///  查询(ag)配额
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeQuotasResponse> DescribeQuotas(DescribeQuotasRequest request) {
            return await new DescribeQuotasExecutor().Client(this).Execute<DescribeQuotasResponse, DescribeQuotasResult, DescribeQuotasRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  从高可用组中剔除实例
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AbandonInstancesResponse AbandonInstances(AbandonInstancesRequest request) {
            return  new AbandonInstancesExecutor().Client(this).Execute<AbandonInstancesResponse, AbandonInstancesResult, AbandonInstancesRequest>(request);
        }
#else
        /// <summary>
        ///  从高可用组中剔除实例
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AbandonInstancesResponse> AbandonInstances(AbandonInstancesRequest request) {
            return await new AbandonInstancesExecutor().Client(this).Execute<AbandonInstancesResponse, AbandonInstancesResult, AbandonInstancesRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建一个高可用组
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateAgResponse CreateAg(CreateAgRequest request) {
            return  new CreateAgExecutor().Client(this).Execute<CreateAgResponse, CreateAgResult, CreateAgRequest>(request);
        }
#else
        /// <summary>
        ///  创建一个高可用组
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateAgResponse> CreateAg(CreateAgRequest request) {
            return await new CreateAgExecutor().Client(this).Execute<CreateAgResponse, CreateAgResult, CreateAgRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  根据 id 查询高可用组详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeAgResponse DescribeAg(DescribeAgRequest request) {
            return  new DescribeAgExecutor().Client(this).Execute<DescribeAgResponse, DescribeAgResult, DescribeAgRequest>(request);
        }
#else
        /// <summary>
        ///  根据 id 查询高可用组详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeAgResponse> DescribeAg(DescribeAgRequest request) {
            return await new DescribeAgExecutor().Client(this).Execute<DescribeAgResponse, DescribeAgResult, DescribeAgRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  使用过滤条件查询一个或多个高可用组
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeAgsResponse DescribeAgs(DescribeAgsRequest request) {
            return  new DescribeAgsExecutor().Client(this).Execute<DescribeAgsResponse, DescribeAgsResult, DescribeAgsRequest>(request);
        }
#else
        /// <summary>
        ///  使用过滤条件查询一个或多个高可用组
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeAgsResponse> DescribeAgs(DescribeAgsRequest request) {
            return await new DescribeAgsExecutor().Client(this).Execute<DescribeAgsResponse, DescribeAgsResult, DescribeAgsRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认AgClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>agClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>agClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>agClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造AgClient 对象
                ///</summary>
                AgClient Build();
            }

            /// <summary>
            ///  默认AgClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  AgClient service client
                /// </summary>
                private  AgClient agClient;

                /// <summary>
                ///  默认AgClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    agClient = new AgClient();
                }

                /// <summary>
                ///  构造AgClient 对象
                ///</summary>
                public AgClient Build()
                {
                    if (agClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        agClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (agClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("AgClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (agClient.HttpRequestConfig == null)
                    {
                        agClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (agClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("AgClient build error: http request config not set");
                        }
                    }
                    return agClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>agClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    agClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>agClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    agClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>agClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    agClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
