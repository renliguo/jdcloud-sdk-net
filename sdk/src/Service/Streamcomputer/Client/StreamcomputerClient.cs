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
 * JDCLOUD流计算API
 * 提供流计算操作的相关接口。
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Streamcomputer.Apis;
using JDCloudSDK.Streamcomputer.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Streamcomputer.Client
{
    /// <summary>
    ///  JDCLOUD流计算API
    ///  提供流计算操作的相关接口。
    ///  Streamcomputer Api 客户端
    ///</summary>
    public class StreamcomputerClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private StreamcomputerClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public StreamcomputerClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public StreamcomputerClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public StreamcomputerClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.0.7
        ///</summary>
        public const string ClientVersion = "1.0.7";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "streamcompute.jdcloud-api.com";
        private const string serviceName = "streamcomputer";
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
        ///  删除namespace,如果旗下关联有其他资源，不允许删除
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request) {
            return  new DeleteNamespaceExecutor().Client(this).Execute<DeleteNamespaceResponse, DeleteNamespaceResult, DeleteNamespaceRequest>(request);
        }
#else
        /// <summary>
        ///  删除namespace,如果旗下关联有其他资源，不允许删除
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteNamespaceResponse> DeleteNamespace(DeleteNamespaceRequest request) {
            return await new DeleteNamespaceExecutor().Client(this).Execute<DeleteNamespaceResponse, DeleteNamespaceResult, DeleteNamespaceRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询指定作业详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeJobResponse DescribeJob(DescribeJobRequest request) {
            return  new DescribeJobExecutor().Client(this).Execute<DescribeJobResponse, DescribeJobResult, DescribeJobRequest>(request);
        }
#else
        /// <summary>
        ///  查询指定作业详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeJobResponse> DescribeJob(DescribeJobRequest request) {
            return await new DescribeJobExecutor().Client(this).Execute<DescribeJobResponse, DescribeJobResult, DescribeJobRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  停止作业运行job
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public StopJobResponse StopJob(StopJobRequest request) {
            return  new StopJobExecutor().Client(this).Execute<StopJobResponse, StopJobResult, StopJobRequest>(request);
        }
#else
        /// <summary>
        ///  停止作业运行job
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<StopJobResponse> StopJob(StopJobRequest request) {
            return await new StopJobExecutor().Client(this).Execute<StopJobResponse, StopJobResult, StopJobRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询租户下的应用列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QueryNamespacesResponse QueryNamespaces(QueryNamespacesRequest request) {
            return  new QueryNamespacesExecutor().Client(this).Execute<QueryNamespacesResponse, QueryNamespacesResult, QueryNamespacesRequest>(request);
        }
#else
        /// <summary>
        ///  查询租户下的应用列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QueryNamespacesResponse> QueryNamespaces(QueryNamespacesRequest request) {
            return await new QueryNamespacesExecutor().Client(this).Execute<QueryNamespacesResponse, QueryNamespacesResult, QueryNamespacesRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询指定应用下的所有job
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetJobListResponse GetJobList(GetJobListRequest request) {
            return  new GetJobListExecutor().Client(this).Execute<GetJobListResponse, GetJobListResult, GetJobListRequest>(request);
        }
#else
        /// <summary>
        ///  查询指定应用下的所有job
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetJobListResponse> GetJobList(GetJobListRequest request) {
            return await new GetJobListExecutor().Client(this).Execute<GetJobListResponse, GetJobListResult, GetJobListRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除指定输入
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteStorageResponse DeleteStorage(DeleteStorageRequest request) {
            return  new DeleteStorageExecutor().Client(this).Execute<DeleteStorageResponse, DeleteStorageResult, DeleteStorageRequest>(request);
        }
#else
        /// <summary>
        ///  删除指定输入
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteStorageResponse> DeleteStorage(DeleteStorageRequest request) {
            return await new DeleteStorageExecutor().Client(this).Execute<DeleteStorageResponse, DeleteStorageResult, DeleteStorageRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  运行job
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public StartJobResponse StartJob(StartJobRequest request) {
            return  new StartJobExecutor().Client(this).Execute<StartJobResponse, StartJobResult, StartJobRequest>(request);
        }
#else
        /// <summary>
        ///  运行job
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<StartJobResponse> StartJob(StartJobRequest request) {
            return await new StartJobExecutor().Client(this).Execute<StartJobResponse, StartJobResult, StartJobRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建或者更新storage
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetStorageListResponse GetStorageList(GetStorageListRequest request) {
            return  new GetStorageListExecutor().Client(this).Execute<GetStorageListResponse, GetStorageListResult, GetStorageListRequest>(request);
        }
#else
        /// <summary>
        ///  创建或者更新storage
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetStorageListResponse> GetStorageList(GetStorageListRequest request) {
            return await new GetStorageListExecutor().Client(this).Execute<GetStorageListResponse, GetStorageListResult, GetStorageListRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建namespace
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request) {
            return  new CreateNamespaceExecutor().Client(this).Execute<CreateNamespaceResponse, CreateNamespaceResult, CreateNamespaceRequest>(request);
        }
#else
        /// <summary>
        ///  创建namespace
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateNamespaceResponse> CreateNamespace(CreateNamespaceRequest request) {
            return await new CreateNamespaceExecutor().Client(this).Execute<CreateNamespaceResponse, CreateNamespaceResult, CreateNamespaceRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建或者更新storage
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AddOrUpdateStorageResponse AddOrUpdateStorage(AddOrUpdateStorageRequest request) {
            return  new AddOrUpdateStorageExecutor().Client(this).Execute<AddOrUpdateStorageResponse, AddOrUpdateStorageResult, AddOrUpdateStorageRequest>(request);
        }
#else
        /// <summary>
        ///  创建或者更新storage
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AddOrUpdateStorageResponse> AddOrUpdateStorage(AddOrUpdateStorageRequest request) {
            return await new AddOrUpdateStorageExecutor().Client(this).Execute<AddOrUpdateStorageResponse, AddOrUpdateStorageResult, AddOrUpdateStorageRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  添加或者更新job
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AddOrUpdateJobResponse AddOrUpdateJob(AddOrUpdateJobRequest request) {
            return  new AddOrUpdateJobExecutor().Client(this).Execute<AddOrUpdateJobResponse, AddOrUpdateJobResult, AddOrUpdateJobRequest>(request);
        }
#else
        /// <summary>
        ///  添加或者更新job
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AddOrUpdateJobResponse> AddOrUpdateJob(AddOrUpdateJobRequest request) {
            return await new AddOrUpdateJobExecutor().Client(this).Execute<AddOrUpdateJobResponse, AddOrUpdateJobResult, AddOrUpdateJobRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询某个应用详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QueryNamespaceDetailResponse QueryNamespaceDetail(QueryNamespaceDetailRequest request) {
            return  new QueryNamespaceDetailExecutor().Client(this).Execute<QueryNamespaceDetailResponse, QueryNamespaceDetailResult, QueryNamespaceDetailRequest>(request);
        }
#else
        /// <summary>
        ///  查询某个应用详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QueryNamespaceDetailResponse> QueryNamespaceDetail(QueryNamespaceDetailRequest request) {
            return await new QueryNamespaceDetailExecutor().Client(this).Execute<QueryNamespaceDetailResponse, QueryNamespaceDetailResult, QueryNamespaceDetailRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  更新namespace
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public UpdateNamespaceResponse UpdateNamespace(UpdateNamespaceRequest request) {
            return  new UpdateNamespaceExecutor().Client(this).Execute<UpdateNamespaceResponse, UpdateNamespaceResult, UpdateNamespaceRequest>(request);
        }
#else
        /// <summary>
        ///  更新namespace
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<UpdateNamespaceResponse> UpdateNamespace(UpdateNamespaceRequest request) {
            return await new UpdateNamespaceExecutor().Client(this).Execute<UpdateNamespaceResponse, UpdateNamespaceResult, UpdateNamespaceRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除作业
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteJobResponse DeleteJob(DeleteJobRequest request) {
            return  new DeleteJobExecutor().Client(this).Execute<DeleteJobResponse, DeleteJobResult, DeleteJobRequest>(request);
        }
#else
        /// <summary>
        ///  删除作业
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteJobResponse> DeleteJob(DeleteJobRequest request) {
            return await new DeleteJobExecutor().Client(this).Execute<DeleteJobResponse, DeleteJobResult, DeleteJobRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询指定输入
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeStorageResponse DescribeStorage(DescribeStorageRequest request) {
            return  new DescribeStorageExecutor().Client(this).Execute<DescribeStorageResponse, DescribeStorageResult, DescribeStorageRequest>(request);
        }
#else
        /// <summary>
        ///  查询指定输入
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeStorageResponse> DescribeStorage(DescribeStorageRequest request) {
            return await new DescribeStorageExecutor().Client(this).Execute<DescribeStorageResponse, DescribeStorageResult, DescribeStorageRequest>(request);
        }
#endif

            /// <summary>
            ///  默认StreamcomputerClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>streamcomputerClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>streamcomputerClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>streamcomputerClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造StreamcomputerClient 对象
                ///</summary>
                StreamcomputerClient Build();
            }

            /// <summary>
            ///  默认StreamcomputerClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  StreamcomputerClient service client
                /// </summary>
                private  StreamcomputerClient streamcomputerClient;

                /// <summary>
                ///  默认StreamcomputerClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    streamcomputerClient = new StreamcomputerClient();
                }

                /// <summary>
                ///  构造StreamcomputerClient 对象
                ///</summary>
                public StreamcomputerClient Build()
                {
                    if (streamcomputerClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        streamcomputerClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (streamcomputerClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("StreamcomputerClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (streamcomputerClient.HttpRequestConfig == null)
                    {
                        streamcomputerClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (streamcomputerClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("StreamcomputerClient build error: http request config not set");
                        }
                    }
                    return streamcomputerClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>streamcomputerClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    streamcomputerClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>streamcomputerClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    streamcomputerClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>streamcomputerClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    streamcomputerClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
