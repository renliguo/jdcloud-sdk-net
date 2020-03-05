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
 * 云鼎虎符 openapi
 * 云鼎虎符 openapi
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Hufu.Apis;
using JDCloudSDK.Hufu.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Hufu.Client
{
    /// <summary>
    ///  云鼎虎符 openapi
    ///  云鼎虎符 openapi
    ///  Hufu Api 客户端
    ///</summary>
    public class HufuClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private HufuClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public HufuClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public HufuClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public HufuClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.2.0
        ///</summary>
        public const string ClientVersion = "1.2.0";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "hufu.jdcloud-api.com";
        private const string serviceName = "hufu";
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
        ///  customerId校验
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CustomerIdVerifyResponse CustomerIdVerify(CustomerIdVerifyRequest request) {
            return  new CustomerIdVerifyExecutor().Client(this).Execute<CustomerIdVerifyResponse, CustomerIdVerifyResult, CustomerIdVerifyRequest>(request);
        }
#else
        /// <summary>
        ///  customerId校验
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CustomerIdVerifyResponse> CustomerIdVerify(CustomerIdVerifyRequest request) {
            return await new CustomerIdVerifyExecutor().Client(this).Execute<CustomerIdVerifyResponse, CustomerIdVerifyResult, CustomerIdVerifyRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询修订版本列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeRevisionsResponse DescribeRevisions(DescribeRevisionsRequest request) {
            return  new DescribeRevisionsExecutor().Client(this).Execute<DescribeRevisionsResponse, DescribeRevisionsResult, DescribeRevisionsRequest>(request);
        }
#else
        /// <summary>
        ///  查询修订版本列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeRevisionsResponse> DescribeRevisions(DescribeRevisionsRequest request) {
            return await new DescribeRevisionsExecutor().Client(this).Execute<DescribeRevisionsResponse, DescribeRevisionsResult, DescribeRevisionsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改api
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public UpdateApisResponse UpdateApis(UpdateApisRequest request) {
            return  new UpdateApisExecutor().Client(this).Execute<UpdateApisResponse, UpdateApisResult, UpdateApisRequest>(request);
        }
#else
        /// <summary>
        ///  修改api
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<UpdateApisResponse> UpdateApis(UpdateApisRequest request) {
            return await new UpdateApisExecutor().Client(this).Execute<UpdateApisResponse, UpdateApisResult, UpdateApisRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询sdk、文档的生成结果
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QuerySdkAndDocumentResponse QuerySdkAndDocument(QuerySdkAndDocumentRequest request) {
            return  new QuerySdkAndDocumentExecutor().Client(this).Execute<QuerySdkAndDocumentResponse, QuerySdkAndDocumentResult, QuerySdkAndDocumentRequest>(request);
        }
#else
        /// <summary>
        ///  查询sdk、文档的生成结果
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QuerySdkAndDocumentResponse> QuerySdkAndDocument(QuerySdkAndDocumentRequest request) {
            return await new QuerySdkAndDocumentExecutor().Client(this).Execute<QuerySdkAndDocumentResponse, QuerySdkAndDocumentResult, QuerySdkAndDocumentRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  下载sdk、文档的生成结果
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DownloadSdkResponse DownloadSdk(DownloadSdkRequest request) {
            return  new DownloadSdkExecutor().Client(this).Execute<DownloadSdkResponse, DownloadSdkResult, DownloadSdkRequest>(request);
        }
#else
        /// <summary>
        ///  下载sdk、文档的生成结果
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DownloadSdkResponse> DownloadSdk(DownloadSdkRequest request) {
            return await new DownloadSdkExecutor().Client(this).Execute<DownloadSdkResponse, DownloadSdkResult, DownloadSdkRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询部署列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeDeploymentsResponse DescribeDeployments(DescribeDeploymentsRequest request) {
            return  new DescribeDeploymentsExecutor().Client(this).Execute<DescribeDeploymentsResponse, DescribeDeploymentsResult, DescribeDeploymentsRequest>(request);
        }
#else
        /// <summary>
        ///  查询部署列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeDeploymentsResponse> DescribeDeployments(DescribeDeploymentsRequest request) {
            return await new DescribeDeploymentsExecutor().Client(this).Execute<DescribeDeploymentsResponse, DescribeDeploymentsResult, DescribeDeploymentsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  下游更新路由信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyRouterByLowerResponse ModifyRouterByLower(ModifyRouterByLowerRequest request) {
            return  new ModifyRouterByLowerExecutor().Client(this).Execute<ModifyRouterByLowerResponse, ModifyRouterByLowerResult, ModifyRouterByLowerRequest>(request);
        }
#else
        /// <summary>
        ///  下游更新路由信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyRouterByLowerResponse> ModifyRouterByLower(ModifyRouterByLowerRequest request) {
            return await new ModifyRouterByLowerExecutor().Client(this).Execute<ModifyRouterByLowerResponse, ModifyRouterByLowerResult, ModifyRouterByLowerRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  批量导入api
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ImportApiResponse ImportApi(ImportApiRequest request) {
            return  new ImportApiExecutor().Client(this).Execute<ImportApiResponse, ImportApiResult, ImportApiRequest>(request);
        }
#else
        /// <summary>
        ///  批量导入api
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ImportApiResponse> ImportApi(ImportApiRequest request) {
            return await new ImportApiExecutor().Client(this).Execute<ImportApiResponse, ImportApiResult, ImportApiRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询api列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QueryApisResponse QueryApis(QueryApisRequest request) {
            return  new QueryApisExecutor().Client(this).Execute<QueryApisResponse, QueryApisResult, QueryApisRequest>(request);
        }
#else
        /// <summary>
        ///  查询api列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QueryApisResponse> QueryApis(QueryApisRequest request) {
            return await new QueryApisExecutor().Client(this).Execute<QueryApisResponse, QueryApisResult, QueryApisRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  生成sdk、文档
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GenerateSdkAndDocumentResponse GenerateSdkAndDocument(GenerateSdkAndDocumentRequest request) {
            return  new GenerateSdkAndDocumentExecutor().Client(this).Execute<GenerateSdkAndDocumentResponse, GenerateSdkAndDocumentResult, GenerateSdkAndDocumentRequest>(request);
        }
#else
        /// <summary>
        ///  生成sdk、文档
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GenerateSdkAndDocumentResponse> GenerateSdkAndDocument(GenerateSdkAndDocumentRequest request) {
            return await new GenerateSdkAndDocumentExecutor().Client(this).Execute<GenerateSdkAndDocumentResponse, GenerateSdkAndDocumentResult, GenerateSdkAndDocumentRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  加密
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public EncryptResponse Encrypt(EncryptRequest request) {
            return  new EncryptExecutor().Client(this).Execute<EncryptResponse, EncryptResult, EncryptRequest>(request);
        }
#else
        /// <summary>
        ///  加密
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<EncryptResponse> Encrypt(EncryptRequest request) {
            return await new EncryptExecutor().Client(this).Execute<EncryptResponse, EncryptResult, EncryptRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  wms接入确认
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AccessConfirmResponse AccessConfirm(AccessConfirmRequest request) {
            return  new AccessConfirmExecutor().Client(this).Execute<AccessConfirmResponse, AccessConfirmResult, AccessConfirmRequest>(request);
        }
#else
        /// <summary>
        ///  wms接入确认
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AccessConfirmResponse> AccessConfirm(AccessConfirmRequest request) {
            return await new AccessConfirmExecutor().Client(this).Execute<AccessConfirmResponse, AccessConfirmResult, AccessConfirmRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建修订版本
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateRevisionResponse CreateRevision(CreateRevisionRequest request) {
            return  new CreateRevisionExecutor().Client(this).Execute<CreateRevisionResponse, CreateRevisionResult, CreateRevisionRequest>(request);
        }
#else
        /// <summary>
        ///  创建修订版本
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateRevisionResponse> CreateRevision(CreateRevisionRequest request) {
            return await new CreateRevisionExecutor().Client(this).Execute<CreateRevisionResponse, CreateRevisionResult, CreateRevisionRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建api
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateApisResponse CreateApis(CreateApisRequest request) {
            return  new CreateApisExecutor().Client(this).Execute<CreateApisResponse, CreateApisResult, CreateApisRequest>(request);
        }
#else
        /// <summary>
        ///  创建api
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateApisResponse> CreateApis(CreateApisRequest request) {
            return await new CreateApisExecutor().Client(this).Execute<CreateApisResponse, CreateApisResult, CreateApisRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  驳回接入申请
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AccessRejectResponse AccessReject(AccessRejectRequest request) {
            return  new AccessRejectExecutor().Client(this).Execute<AccessRejectResponse, AccessRejectResult, AccessRejectRequest>(request);
        }
#else
        /// <summary>
        ///  驳回接入申请
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AccessRejectResponse> AccessReject(AccessRejectRequest request) {
            return await new AccessRejectExecutor().Client(this).Execute<AccessRejectResponse, AccessRejectResult, AccessRejectRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认HufuClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>hufuClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>hufuClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>hufuClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造HufuClient 对象
                ///</summary>
                HufuClient Build();
            }

            /// <summary>
            ///  默认HufuClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  HufuClient service client
                /// </summary>
                private  HufuClient hufuClient;

                /// <summary>
                ///  默认HufuClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    hufuClient = new HufuClient();
                }

                /// <summary>
                ///  构造HufuClient 对象
                ///</summary>
                public HufuClient Build()
                {
                    if (hufuClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        hufuClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (hufuClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("HufuClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (hufuClient.HttpRequestConfig == null)
                    {
                        hufuClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (hufuClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("HufuClient build error: http request config not set");
                        }
                    }
                    return hufuClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>hufuClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    hufuClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>hufuClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    hufuClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>hufuClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    hufuClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}