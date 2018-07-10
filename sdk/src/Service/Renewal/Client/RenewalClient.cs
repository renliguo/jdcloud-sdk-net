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
 * JDCLOUD Renewal API
 * API related to Renewal
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Renewal.Apis;
using JDCloudSDK.Renewal.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Renewal.Client
{
    /// <summary>
    /// JDCLOUD Renewal API
    /// API related to Renewal
    /// Renewal Api 客户端
    ///</summary>
    public class RenewalClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private RenewalClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public RenewalClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public RenewalClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public RenewalClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.0.1
        ///</summary>
        public const string ClientVersion = "1.0.1";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "renewal.jcloud.com";
        private const string serviceName = "renewal";
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
        /// 查询续费资源列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ResourceListResponse ResourceList(ResourceListRequest request) {
            return  new ResourceListExecutor().Client(this).Execute<ResourceListResponse, ResourceListResult, ResourceListRequest>(request);
        }
#else
        /// <summary>
        /// 查询续费资源列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ResourceListResponse> ResourceList(ResourceListRequest request) {
            return await new ResourceListExecutor().Client(this).Execute<ResourceListResponse, ResourceListResult, ResourceListRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询用户过期即将到期资源总数
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public InstanceCountResponse InstanceCount(InstanceCountRequest request) {
            return  new InstanceCountExecutor().Client(this).Execute<InstanceCountResponse, InstanceCountResult, InstanceCountRequest>(request);
        }
#else
        /// <summary>
        /// 查询用户过期即将到期资源总数
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<InstanceCountResponse> InstanceCount(InstanceCountRequest request) {
            return await new InstanceCountExecutor().Client(this).Execute<InstanceCountResponse, InstanceCountResult, InstanceCountRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询服务条款
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ServiceTermResponse ServiceTerm(ServiceTermRequest request) {
            return  new ServiceTermExecutor().Client(this).Execute<ServiceTermResponse, ServiceTermResult, ServiceTermRequest>(request);
        }
#else
        /// <summary>
        /// 查询服务条款
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ServiceTermResponse> ServiceTerm(ServiceTermRequest request) {
            return await new ServiceTermExecutor().Client(this).Execute<ServiceTermResponse, ServiceTermResult, ServiceTermRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询临时订单
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public TempOrderResponse TempOrder(TempOrderRequest request) {
            return  new TempOrderExecutor().Client(this).Execute<TempOrderResponse, TempOrderResult, TempOrderRequest>(request);
        }
#else
        /// <summary>
        /// 查询临时订单
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<TempOrderResponse> TempOrder(TempOrderRequest request) {
            return await new TempOrderExecutor().Client(this).Execute<TempOrderResponse, TempOrderResult, TempOrderRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 提交临时订单
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public SubmitTempOrderResponse SubmitTempOrder(SubmitTempOrderRequest request) {
            return  new SubmitTempOrderExecutor().Client(this).Execute<SubmitTempOrderResponse, SubmitTempOrderResult, SubmitTempOrderRequest>(request);
        }
#else
        /// <summary>
        /// 提交临时订单
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<SubmitTempOrderResponse> SubmitTempOrder(SubmitTempOrderRequest request) {
            return await new SubmitTempOrderExecutor().Client(this).Execute<SubmitTempOrderResponse, SubmitTempOrderResult, SubmitTempOrderRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 提交续费订单
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public RenewResponse Renew(RenewRequest request) {
            return  new RenewExecutor().Client(this).Execute<RenewResponse, RenewResult, RenewRequest>(request);
        }
#else
        /// <summary>
        /// 提交续费订单
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<RenewResponse> Renew(RenewRequest request) {
            return await new RenewExecutor().Client(this).Execute<RenewResponse, RenewResult, RenewRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 开通修改自动续费周期
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public HandleAutoPayResponse HandleAutoPay(HandleAutoPayRequest request) {
            return  new HandleAutoPayExecutor().Client(this).Execute<HandleAutoPayResponse, HandleAutoPayResult, HandleAutoPayRequest>(request);
        }
#else
        /// <summary>
        /// 开通修改自动续费周期
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<HandleAutoPayResponse> HandleAutoPay(HandleAutoPayRequest request) {
            return await new HandleAutoPayExecutor().Client(this).Execute<HandleAutoPayResponse, HandleAutoPayResult, HandleAutoPayRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询资源续费价格
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public RenewPriceResponse RenewPrice(RenewPriceRequest request) {
            return  new RenewPriceExecutor().Client(this).Execute<RenewPriceResponse, RenewPriceResult, RenewPriceRequest>(request);
        }
#else
        /// <summary>
        /// 查询资源续费价格
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<RenewPriceResponse> RenewPrice(RenewPriceRequest request) {
            return await new RenewPriceExecutor().Client(this).Execute<RenewPriceResponse, RenewPriceResult, RenewPriceRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询资源详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ResourceRelationResponse ResourceRelation(ResourceRelationRequest request) {
            return  new ResourceRelationExecutor().Client(this).Execute<ResourceRelationResponse, ResourceRelationResult, ResourceRelationRequest>(request);
        }
#else
        /// <summary>
        /// 查询资源详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ResourceRelationResponse> ResourceRelation(ResourceRelationRequest request) {
            return await new ResourceRelationExecutor().Client(this).Execute<ResourceRelationResponse, ResourceRelationResult, ResourceRelationRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 取消自动续费
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteAutoPayResponse DeleteAutoPay(DeleteAutoPayRequest request) {
            return  new DeleteAutoPayExecutor().Client(this).Execute<DeleteAutoPayResponse, DeleteAutoPayResult, DeleteAutoPayRequest>(request);
        }
#else
        /// <summary>
        /// 取消自动续费
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteAutoPayResponse> DeleteAutoPay(DeleteAutoPayRequest request) {
            return await new DeleteAutoPayExecutor().Client(this).Execute<DeleteAutoPayResponse, DeleteAutoPayResult, DeleteAutoPayRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询资源订单支付状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public RenewPaymentStatusResponse RenewPaymentStatus(RenewPaymentStatusRequest request) {
            return  new RenewPaymentStatusExecutor().Client(this).Execute<RenewPaymentStatusResponse, RenewPaymentStatusResult, RenewPaymentStatusRequest>(request);
        }
#else
        /// <summary>
        /// 查询资源订单支付状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<RenewPaymentStatusResponse> RenewPaymentStatus(RenewPaymentStatusRequest request) {
            return await new RenewPaymentStatusExecutor().Client(this).Execute<RenewPaymentStatusResponse, RenewPaymentStatusResult, RenewPaymentStatusRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询即将到期资源类型
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ExpireResourcesResponse ExpireResources(ExpireResourcesRequest request) {
            return  new ExpireResourcesExecutor().Client(this).Execute<ExpireResourcesResponse, ExpireResourcesResult, ExpireResourcesRequest>(request);
        }
#else
        /// <summary>
        /// 查询即将到期资源类型
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ExpireResourcesResponse> ExpireResources(ExpireResourcesRequest request) {
            return await new ExpireResourcesExecutor().Client(this).Execute<ExpireResourcesResponse, ExpireResourcesResult, ExpireResourcesRequest>(request);
        }
#endif

            /// <summary>
            ///  默认RenewalClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>renewalClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>renewalClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>renewalClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造RenewalClient 对象
                ///</summary>
                RenewalClient Build();
            }

            /// <summary>
            ///  默认RenewalClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                /// RenewalClient service client
                /// </summary>
                private  RenewalClient renewalClient;

                /// <summary>
                ///  默认RenewalClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    renewalClient = new RenewalClient();
                }

                /// <summary>
                ///  构造RenewalClient 对象
                ///</summary>
                public RenewalClient Build()
                {
                    if (renewalClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        renewalClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (renewalClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("RenewalClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (renewalClient.HttpRequestConfig == null)
                    {
                        renewalClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (renewalClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("RenewalClient build error: http request config not set");
                        }
                    }
                    return renewalClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>renewalClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    renewalClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>renewalClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    renewalClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>renewalClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    renewalClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
