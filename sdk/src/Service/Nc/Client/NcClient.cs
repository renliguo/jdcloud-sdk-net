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
 * 容器服务
 * 容器服务相关接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Nc.Apis;
using JDCloudSDK.Nc.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Nc.Client
{
    /// <summary>
    /// 容器服务
    /// 容器服务相关接口
    /// Nc Api 客户端
    ///</summary>
    public class NcClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private NcClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public NcClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public NcClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public NcClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.0.1
        ///</summary>
        public const string ClientVersion = "1.0.1";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "nc.jdcloud-api.com";
        private const string serviceName = "nc";
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
        /// 查询容器列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeContainersResponse DescribeContainers(DescribeContainersRequest request) {
            return  new DescribeContainersExecutor().Client(this).Execute<DescribeContainersResponse, DescribeContainersResult, DescribeContainersRequest>(request);
        }
#else
        /// <summary>
        /// 查询容器列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeContainersResponse> DescribeContainers(DescribeContainersRequest request) {
            return await new DescribeContainersExecutor().Client(this).Execute<DescribeContainersResponse, DescribeContainersResult, DescribeContainersRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 创建一台或多台指定配置的实例
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateContainersResponse CreateContainers(CreateContainersRequest request) {
            return  new CreateContainersExecutor().Client(this).Execute<CreateContainersResponse, CreateContainersResult, CreateContainersRequest>(request);
        }
#else
        /// <summary>
        /// 创建一台或多台指定配置的实例
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateContainersResponse> CreateContainers(CreateContainersRequest request) {
            return await new CreateContainersExecutor().Client(this).Execute<CreateContainersResponse, CreateContainersResult, CreateContainersRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询容器日志
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetLogsResponse GetLogs(GetLogsRequest request) {
            return  new GetLogsExecutor().Client(this).Execute<GetLogsResponse, GetLogsResult, GetLogsRequest>(request);
        }
#else
        /// <summary>
        /// 查询容器日志
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetLogsResponse> GetLogs(GetLogsRequest request) {
            return await new GetLogsExecutor().Client(this).Execute<GetLogsResponse, GetLogsResult, GetLogsRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询 secret 详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSecretResponse DescribeSecret(DescribeSecretRequest request) {
            return  new DescribeSecretExecutor().Client(this).Execute<DescribeSecretResponse, DescribeSecretResult, DescribeSecretRequest>(request);
        }
#else
        /// <summary>
        /// 查询 secret 详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSecretResponse> DescribeSecret(DescribeSecretRequest request) {
            return await new DescribeSecretExecutor().Client(this).Execute<DescribeSecretResponse, DescribeSecretResult, DescribeSecretRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 修改容器属性
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyContainerAttributeResponse ModifyContainerAttribute(ModifyContainerAttributeRequest request) {
            return  new ModifyContainerAttributeExecutor().Client(this).Execute<ModifyContainerAttributeResponse, ModifyContainerAttributeResult, ModifyContainerAttributeRequest>(request);
        }
#else
        /// <summary>
        /// 修改容器属性
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyContainerAttributeResponse> ModifyContainerAttribute(ModifyContainerAttributeRequest request) {
            return await new ModifyContainerAttributeExecutor().Client(this).Execute<ModifyContainerAttributeResponse, ModifyContainerAttributeResult, ModifyContainerAttributeRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 删除单个实例
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteContainerResponse DeleteContainer(DeleteContainerRequest request) {
            return  new DeleteContainerExecutor().Client(this).Execute<DeleteContainerResponse, DeleteContainerResult, DeleteContainerRequest>(request);
        }
#else
        /// <summary>
        /// 删除单个实例
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteContainerResponse> DeleteContainer(DeleteContainerRequest request) {
            return await new DeleteContainerExecutor().Client(this).Execute<DeleteContainerResponse, DeleteContainerResult, DeleteContainerRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 停止单个实例
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public StopContainerResponse StopContainer(StopContainerRequest request) {
            return  new StopContainerExecutor().Client(this).Execute<StopContainerResponse, StopContainerResult, StopContainerRequest>(request);
        }
#else
        /// <summary>
        /// 停止单个实例
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<StopContainerResponse> StopContainer(StopContainerRequest request) {
            return await new StopContainerExecutor().Client(this).Execute<StopContainerResponse, StopContainerResult, StopContainerRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 启动单个实例
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public StartContainerResponse StartContainer(StartContainerRequest request) {
            return  new StartContainerExecutor().Client(this).Execute<StartContainerResponse, StartContainerResult, StartContainerRequest>(request);
        }
#else
        /// <summary>
        /// 启动单个实例
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<StartContainerResponse> StartContainer(StartContainerRequest request) {
            return await new StartContainerExecutor().Client(this).Execute<StartContainerResponse, StartContainerResult, StartContainerRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 容器解绑公网IP 解绑的是主网卡、主内网IP对应的弹性IP
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DisassociateElasticIpResponse DisassociateElasticIp(DisassociateElasticIpRequest request) {
            return  new DisassociateElasticIpExecutor().Client(this).Execute<DisassociateElasticIpResponse, DisassociateElasticIpResult, DisassociateElasticIpRequest>(request);
        }
#else
        /// <summary>
        /// 容器解绑公网IP 解绑的是主网卡、主内网IP对应的弹性IP
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DisassociateElasticIpResponse> DisassociateElasticIp(DisassociateElasticIpRequest request) {
            return await new DisassociateElasticIpExecutor().Client(this).Execute<DisassociateElasticIpResponse, DisassociateElasticIpResult, DisassociateElasticIpRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询secret列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSecretsResponse DescribeSecrets(DescribeSecretsRequest request) {
            return  new DescribeSecretsExecutor().Client(this).Execute<DescribeSecretsResponse, DescribeSecretsResult, DescribeSecretsRequest>(request);
        }
#else
        /// <summary>
        /// 查询secret列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSecretsResponse> DescribeSecrets(DescribeSecretsRequest request) {
            return await new DescribeSecretsExecutor().Client(this).Execute<DescribeSecretsResponse, DescribeSecretsResult, DescribeSecretsRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询资源的配额
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeQuotaResponse DescribeQuota(DescribeQuotaRequest request) {
            return  new DescribeQuotaExecutor().Client(this).Execute<DescribeQuotaResponse, DescribeQuotaResult, DescribeQuotaRequest>(request);
        }
#else
        /// <summary>
        /// 查询资源的配额
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeQuotaResponse> DescribeQuota(DescribeQuotaRequest request) {
            return await new DescribeQuotaExecutor().Client(this).Execute<DescribeQuotaResponse, DescribeQuotaResult, DescribeQuotaRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询容器详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeContainerResponse DescribeContainer(DescribeContainerRequest request) {
            return  new DescribeContainerExecutor().Client(this).Execute<DescribeContainerResponse, DescribeContainerResult, DescribeContainerRequest>(request);
        }
#else
        /// <summary>
        /// 查询容器详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeContainerResponse> DescribeContainer(DescribeContainerRequest request) {
            return await new DescribeContainerExecutor().Client(this).Execute<DescribeContainerResponse, DescribeContainerResult, DescribeContainerRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 修改资源的配额
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyQuotaResponse ModifyQuota(ModifyQuotaRequest request) {
            return  new ModifyQuotaExecutor().Client(this).Execute<ModifyQuotaResponse, ModifyQuotaResult, ModifyQuotaRequest>(request);
        }
#else
        /// <summary>
        /// 修改资源的配额
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyQuotaResponse> ModifyQuota(ModifyQuotaRequest request) {
            return await new ModifyQuotaExecutor().Client(this).Execute<ModifyQuotaResponse, ModifyQuotaResult, ModifyQuotaRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 删除 secret
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteSecretResponse DeleteSecret(DeleteSecretRequest request) {
            return  new DeleteSecretExecutor().Client(this).Execute<DeleteSecretResponse, DeleteSecretResult, DeleteSecretRequest>(request);
        }
#else
        /// <summary>
        /// 删除 secret
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteSecretResponse> DeleteSecret(DeleteSecretRequest request) {
            return await new DeleteSecretExecutor().Client(this).Execute<DeleteSecretResponse, DeleteSecretResult, DeleteSecretRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 创建 secret
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateSecretResponse CreateSecret(CreateSecretRequest request) {
            return  new CreateSecretExecutor().Client(this).Execute<CreateSecretResponse, CreateSecretResult, CreateSecretRequest>(request);
        }
#else
        /// <summary>
        /// 创建 secret
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateSecretResponse> CreateSecret(CreateSecretRequest request) {
            return await new CreateSecretExecutor().Client(this).Execute<CreateSecretResponse, CreateSecretResult, CreateSecretRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 容器绑定公网IP 绑定的是主网卡、主内网IP对应的弹性IP
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AssociateElasticIpResponse AssociateElasticIp(AssociateElasticIpRequest request) {
            return  new AssociateElasticIpExecutor().Client(this).Execute<AssociateElasticIpResponse, AssociateElasticIpResult, AssociateElasticIpRequest>(request);
        }
#else
        /// <summary>
        /// 容器绑定公网IP 绑定的是主网卡、主内网IP对应的弹性IP
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AssociateElasticIpResponse> AssociateElasticIp(AssociateElasticIpRequest request) {
            return await new AssociateElasticIpExecutor().Client(this).Execute<AssociateElasticIpResponse, AssociateElasticIpResult, AssociateElasticIpRequest>(request);
        }
#endif

            /// <summary>
            ///  默认NcClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>ncClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>ncClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>ncClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造NcClient 对象
                ///</summary>
                NcClient Build();
            }

            /// <summary>
            ///  默认NcClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                /// NcClient service client
                /// </summary>
                private  NcClient ncClient;

                /// <summary>
                ///  默认NcClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    ncClient = new NcClient();
                }

                /// <summary>
                ///  构造NcClient 对象
                ///</summary>
                public NcClient Build()
                {
                    if (ncClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        ncClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (ncClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("NcClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (ncClient.HttpRequestConfig == null)
                    {
                        ncClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (ncClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("NcClient build error: http request config not set");
                        }
                    }
                    return ncClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>ncClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    ncClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>ncClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    ncClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>ncClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    ncClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
