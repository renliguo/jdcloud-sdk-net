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
 * 云存储API
 * 云存储API，主要包含查询Bucket列表，创建Bucket, 删除Bucket，查询Bucket是否存在, 更多API见：https://www.jdcloud.com/help/detail/1901/isCatalog/1
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Oss.Apis;
using JDCloudSDK.Oss.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Oss.Client
{
    /// <summary>
    ///  云存储API
    ///  云存储API，主要包含查询Bucket列表，创建Bucket, 删除Bucket，查询Bucket是否存在, 更多API见：https://www.jdcloud.com/help/detail/1901/isCatalog/1
    ///  Oss Api 客户端
    ///</summary>
    public class OssClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private OssClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public OssClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public OssClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public OssClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.0.6
        ///</summary>
        public const string ClientVersion = "1.0.6";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "oss.jdcloud-api.com";
        private const string serviceName = "oss";
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
        ///  创建bucket
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public PutBucketResponse PutBucket(PutBucketRequest request) {
            return  new PutBucketExecutor().Client(this).Execute<PutBucketResponse, PutBucketResult, PutBucketRequest>(request);
        }
#else
        /// <summary>
        ///  创建bucket
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<PutBucketResponse> PutBucket(PutBucketRequest request) {
            return await new PutBucketExecutor().Client(this).Execute<PutBucketResponse, PutBucketResult, PutBucketRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除一个bucket
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteBucketResponse DeleteBucket(DeleteBucketRequest request) {
            return  new DeleteBucketExecutor().Client(this).Execute<DeleteBucketResponse, DeleteBucketResult, DeleteBucketRequest>(request);
        }
#else
        /// <summary>
        ///  删除一个bucket
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteBucketResponse> DeleteBucket(DeleteBucketRequest request) {
            return await new DeleteBucketExecutor().Client(this).Execute<DeleteBucketResponse, DeleteBucketResult, DeleteBucketRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询bucket是否存在
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public HeadBucketResponse HeadBucket(HeadBucketRequest request) {
            return  new HeadBucketExecutor().Client(this).Execute<HeadBucketResponse, HeadBucketResult, HeadBucketRequest>(request);
        }
#else
        /// <summary>
        ///  查询bucket是否存在
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<HeadBucketResponse> HeadBucket(HeadBucketRequest request) {
            return await new HeadBucketExecutor().Client(this).Execute<HeadBucketResponse, HeadBucketResult, HeadBucketRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  列出当前用户的所有bucket
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ListBucketsResponse ListBuckets(ListBucketsRequest request) {
            return  new ListBucketsExecutor().Client(this).Execute<ListBucketsResponse, ListBucketsResult, ListBucketsRequest>(request);
        }
#else
        /// <summary>
        ///  列出当前用户的所有bucket
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ListBucketsResponse> ListBuckets(ListBucketsRequest request) {
            return await new ListBucketsExecutor().Client(this).Execute<ListBucketsResponse, ListBucketsResult, ListBucketsRequest>(request);
        }
#endif

            /// <summary>
            ///  默认OssClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>ossClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>ossClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>ossClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造OssClient 对象
                ///</summary>
                OssClient Build();
            }

            /// <summary>
            ///  默认OssClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  OssClient service client
                /// </summary>
                private  OssClient ossClient;

                /// <summary>
                ///  默认OssClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    ossClient = new OssClient();
                }

                /// <summary>
                ///  构造OssClient 对象
                ///</summary>
                public OssClient Build()
                {
                    if (ossClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        ossClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (ossClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("OssClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (ossClient.HttpRequestConfig == null)
                    {
                        ossClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (ossClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("OssClient build error: http request config not set");
                        }
                    }
                    return ossClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>ossClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    ossClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>ossClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    ossClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>ossClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    ossClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
