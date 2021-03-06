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
 * 数据计算服务API
 * 数据计算服务相关API
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Xdata.Apis;
using JDCloudSDK.Xdata.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Xdata.Client
{
    /// <summary>
    ///  数据计算服务API
    ///  数据计算服务相关API
    ///  Xdata Api 客户端
    ///</summary>
    public class XdataClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private XdataClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public XdataClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public XdataClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public XdataClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.0.9
        ///</summary>
        public const string ClientVersion = "1.0.9";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "xdata.jdcloud-api.com";
        private const string serviceName = "xdata";
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
        ///  创建属于用户实例的数据库
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateDatabaseResponse CreateDatabase(CreateDatabaseRequest request) {
            return  new CreateDatabaseExecutor().Client(this).Execute<CreateDatabaseResponse, CreateDatabaseResult, CreateDatabaseRequest>(request);
        }
#else
        /// <summary>
        ///  创建属于用户实例的数据库
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateDatabaseResponse> CreateDatabase(CreateDatabaseRequest request) {
            return await new CreateDatabaseExecutor().Client(this).Execute<CreateDatabaseResponse, CreateDatabaseResult, CreateDatabaseRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  终止用户Spark SQL脚本查询
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CancelRasQueryResponse CancelRasQuery(CancelRasQueryRequest request) {
            return  new CancelRasQueryExecutor().Client(this).Execute<CancelRasQueryResponse, CancelRasQueryResult, CancelRasQueryRequest>(request);
        }
#else
        /// <summary>
        ///  终止用户Spark SQL脚本查询
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CancelRasQueryResponse> CancelRasQuery(CancelRasQueryRequest request) {
            return await new CancelRasQueryExecutor().Client(this).Execute<CancelRasQueryResponse, CancelRasQueryResult, CancelRasQueryRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询用户实例的所有数据库信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ListDatabaseInfoResponse ListDatabaseInfo(ListDatabaseInfoRequest request) {
            return  new ListDatabaseInfoExecutor().Client(this).Execute<ListDatabaseInfoResponse, ListDatabaseInfoResult, ListDatabaseInfoRequest>(request);
        }
#else
        /// <summary>
        ///  查询用户实例的所有数据库信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ListDatabaseInfoResponse> ListDatabaseInfo(ListDatabaseInfoRequest request) {
            return await new ListDatabaseInfoExecutor().Client(this).Execute<ListDatabaseInfoResponse, ListDatabaseInfoResult, ListDatabaseInfoRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取用户PySpark脚本的执行状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetPySparkExecuteStateResponse GetPySparkExecuteState(GetPySparkExecuteStateRequest request) {
            return  new GetPySparkExecuteStateExecutor().Client(this).Execute<GetPySparkExecuteStateResponse, GetPySparkExecuteStateResult, GetPySparkExecuteStateRequest>(request);
        }
#else
        /// <summary>
        ///  获取用户PySpark脚本的执行状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetPySparkExecuteStateResponse> GetPySparkExecuteState(GetPySparkExecuteStateRequest request) {
            return await new GetPySparkExecuteStateExecutor().Client(this).Execute<GetPySparkExecuteStateResponse, GetPySparkExecuteStateResult, GetPySparkExecuteStateRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询用户实例的指定数据库信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetDatabaseInfoResponse GetDatabaseInfo(GetDatabaseInfoRequest request) {
            return  new GetDatabaseInfoExecutor().Client(this).Execute<GetDatabaseInfoResponse, GetDatabaseInfoResult, GetDatabaseInfoRequest>(request);
        }
#else
        /// <summary>
        ///  查询用户实例的指定数据库信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetDatabaseInfoResponse> GetDatabaseInfo(GetDatabaseInfoRequest request) {
            return await new GetDatabaseInfoExecutor().Client(this).Execute<GetDatabaseInfoResponse, GetDatabaseInfoResult, GetDatabaseInfoRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询用户实例指定数据库下的所有数据表信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ListTableInfoResponse ListTableInfo(ListTableInfoRequest request) {
            return  new ListTableInfoExecutor().Client(this).Execute<ListTableInfoResponse, ListTableInfoResult, ListTableInfoRequest>(request);
        }
#else
        /// <summary>
        ///  查询用户实例指定数据库下的所有数据表信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ListTableInfoResponse> ListTableInfo(ListTableInfoRequest request) {
            return await new ListTableInfoExecutor().Client(this).Execute<ListTableInfoResponse, ListTableInfoResult, ListTableInfoRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取用户Spark SQL脚本的查询状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetRasQueryStateResponse GetRasQueryState(GetRasQueryStateRequest request) {
            return  new GetRasQueryStateExecutor().Client(this).Execute<GetRasQueryStateResponse, GetRasQueryStateResult, GetRasQueryStateRequest>(request);
        }
#else
        /// <summary>
        ///  获取用户Spark SQL脚本的查询状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetRasQueryStateResponse> GetRasQueryState(GetRasQueryStateRequest request) {
            return await new GetRasQueryStateExecutor().Client(this).Execute<GetRasQueryStateResponse, GetRasQueryStateResult, GetRasQueryStateRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  执行用户编写的Spark SQL脚本
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ExecuteRasQueryResponse ExecuteRasQuery(ExecuteRasQueryRequest request) {
            return  new ExecuteRasQueryExecutor().Client(this).Execute<ExecuteRasQueryResponse, ExecuteRasQueryResult, ExecuteRasQueryRequest>(request);
        }
#else
        /// <summary>
        ///  执行用户编写的Spark SQL脚本
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ExecuteRasQueryResponse> ExecuteRasQuery(ExecuteRasQueryRequest request) {
            return await new ExecuteRasQueryExecutor().Client(this).Execute<ExecuteRasQueryResponse, ExecuteRasQueryResult, ExecuteRasQueryRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  终止用户PySpark脚本任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CancelPySparkJobResponse CancelPySparkJob(CancelPySparkJobRequest request) {
            return  new CancelPySparkJobExecutor().Client(this).Execute<CancelPySparkJobResponse, CancelPySparkJobResult, CancelPySparkJobRequest>(request);
        }
#else
        /// <summary>
        ///  终止用户PySpark脚本任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CancelPySparkJobResponse> CancelPySparkJob(CancelPySparkJobRequest request) {
            return await new CancelPySparkJobExecutor().Client(this).Execute<CancelPySparkJobResponse, CancelPySparkJobResult, CancelPySparkJobRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取用户PySpark脚本的执行结果
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetPySparkExecuteResultResponse GetPySparkExecuteResult(GetPySparkExecuteResultRequest request) {
            return  new GetPySparkExecuteResultExecutor().Client(this).Execute<GetPySparkExecuteResultResponse, GetPySparkExecuteResultResult, GetPySparkExecuteResultRequest>(request);
        }
#else
        /// <summary>
        ///  获取用户PySpark脚本的执行结果
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetPySparkExecuteResultResponse> GetPySparkExecuteResult(GetPySparkExecuteResultRequest request) {
            return await new GetPySparkExecuteResultExecutor().Client(this).Execute<GetPySparkExecuteResultResponse, GetPySparkExecuteResultResult, GetPySparkExecuteResultRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询用户所属的实例信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ListInstanceInfoResponse ListInstanceInfo(ListInstanceInfoRequest request) {
            return  new ListInstanceInfoExecutor().Client(this).Execute<ListInstanceInfoResponse, ListInstanceInfoResult, ListInstanceInfoRequest>(request);
        }
#else
        /// <summary>
        ///  查询用户所属的实例信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ListInstanceInfoResponse> ListInstanceInfo(ListInstanceInfoRequest request) {
            return await new ListInstanceInfoExecutor().Client(this).Execute<ListInstanceInfoResponse, ListInstanceInfoResult, ListInstanceInfoRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除用户实例的指定数据库
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteDatabaseResponse DeleteDatabase(DeleteDatabaseRequest request) {
            return  new DeleteDatabaseExecutor().Client(this).Execute<DeleteDatabaseResponse, DeleteDatabaseResult, DeleteDatabaseRequest>(request);
        }
#else
        /// <summary>
        ///  删除用户实例的指定数据库
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteDatabaseResponse> DeleteDatabase(DeleteDatabaseRequest request) {
            return await new DeleteDatabaseExecutor().Client(this).Execute<DeleteDatabaseResponse, DeleteDatabaseResult, DeleteDatabaseRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询用户实例的指定数据表信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetTableInfoResponse GetTableInfo(GetTableInfoRequest request) {
            return  new GetTableInfoExecutor().Client(this).Execute<GetTableInfoResponse, GetTableInfoResult, GetTableInfoRequest>(request);
        }
#else
        /// <summary>
        ///  查询用户实例的指定数据表信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetTableInfoResponse> GetTableInfo(GetTableInfoRequest request) {
            return await new GetTableInfoExecutor().Client(this).Execute<GetTableInfoResponse, GetTableInfoResult, GetTableInfoRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  执行用户编写的PySpark脚本
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ExecutePySparkQueryResponse ExecutePySparkQuery(ExecutePySparkQueryRequest request) {
            return  new ExecutePySparkQueryExecutor().Client(this).Execute<ExecutePySparkQueryResponse, ExecutePySparkQueryResult, ExecutePySparkQueryRequest>(request);
        }
#else
        /// <summary>
        ///  执行用户编写的PySpark脚本
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ExecutePySparkQueryResponse> ExecutePySparkQuery(ExecutePySparkQueryRequest request) {
            return await new ExecutePySparkQueryExecutor().Client(this).Execute<ExecutePySparkQueryResponse, ExecutePySparkQueryResult, ExecutePySparkQueryRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取用户Spark SQL脚本的查询结果
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetRasQueryResultResponse GetRasQueryResult(GetRasQueryResultRequest request) {
            return  new GetRasQueryResultExecutor().Client(this).Execute<GetRasQueryResultResponse, GetRasQueryResultResult, GetRasQueryResultRequest>(request);
        }
#else
        /// <summary>
        ///  获取用户Spark SQL脚本的查询结果
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetRasQueryResultResponse> GetRasQueryResult(GetRasQueryResultRequest request) {
            return await new GetRasQueryResultExecutor().Client(this).Execute<GetRasQueryResultResponse, GetRasQueryResultResult, GetRasQueryResultRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建用户实例的数据表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateTableResponse CreateTable(CreateTableRequest request) {
            return  new CreateTableExecutor().Client(this).Execute<CreateTableResponse, CreateTableResult, CreateTableRequest>(request);
        }
#else
        /// <summary>
        ///  创建用户实例的数据表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateTableResponse> CreateTable(CreateTableRequest request) {
            return await new CreateTableExecutor().Client(this).Execute<CreateTableResponse, CreateTableResult, CreateTableRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取用户Spark SQL脚本的查询日志
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetRasQueryLogResponse GetRasQueryLog(GetRasQueryLogRequest request) {
            return  new GetRasQueryLogExecutor().Client(this).Execute<GetRasQueryLogResponse, GetRasQueryLogResult, GetRasQueryLogRequest>(request);
        }
#else
        /// <summary>
        ///  获取用户Spark SQL脚本的查询日志
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetRasQueryLogResponse> GetRasQueryLog(GetRasQueryLogRequest request) {
            return await new GetRasQueryLogExecutor().Client(this).Execute<GetRasQueryLogResponse, GetRasQueryLogResult, GetRasQueryLogRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除用户实例的指定数据表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteTableResponse DeleteTable(DeleteTableRequest request) {
            return  new DeleteTableExecutor().Client(this).Execute<DeleteTableResponse, DeleteTableResult, DeleteTableRequest>(request);
        }
#else
        /// <summary>
        ///  删除用户实例的指定数据表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteTableResponse> DeleteTable(DeleteTableRequest request) {
            return await new DeleteTableExecutor().Client(this).Execute<DeleteTableResponse, DeleteTableResult, DeleteTableRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认XdataClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>xdataClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>xdataClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>xdataClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造XdataClient 对象
                ///</summary>
                XdataClient Build();
            }

            /// <summary>
            ///  默认XdataClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  XdataClient service client
                /// </summary>
                private  XdataClient xdataClient;

                /// <summary>
                ///  默认XdataClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    xdataClient = new XdataClient();
                }

                /// <summary>
                ///  构造XdataClient 对象
                ///</summary>
                public XdataClient Build()
                {
                    if (xdataClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        xdataClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (xdataClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("XdataClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (xdataClient.HttpRequestConfig == null)
                    {
                        xdataClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (xdataClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("XdataClient build error: http request config not set");
                        }
                    }
                    return xdataClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>xdataClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    xdataClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>xdataClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    xdataClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>xdataClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    xdataClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
