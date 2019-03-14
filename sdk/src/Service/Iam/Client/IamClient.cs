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
 * IAM API
 * IAM相关接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Iam.Apis;
using JDCloudSDK.Iam.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Iam.Client
{
    /// <summary>
    ///  IAM API
    ///  IAM相关接口
    ///  Iam Api 客户端
    ///</summary>
    public class IamClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private IamClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public IamClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public IamClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public IamClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.0.9
        ///</summary>
        public const string ClientVersion = "1.0.9";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "iam.jdcloud-api.com";
        private const string serviceName = "iam";
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
        ///  查询子用户策略列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSubUserPermissionsResponse DescribeSubUserPermissions(DescribeSubUserPermissionsRequest request) {
            return  new DescribeSubUserPermissionsExecutor().Client(this).Execute<DescribeSubUserPermissionsResponse, DescribeSubUserPermissionsResult, DescribeSubUserPermissionsRequest>(request);
        }
#else
        /// <summary>
        ///  查询子用户策略列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSubUserPermissionsResponse> DescribeSubUserPermissions(DescribeSubUserPermissionsRequest request) {
            return await new DescribeSubUserPermissionsExecutor().Client(this).Execute<DescribeSubUserPermissionsResponse, DescribeSubUserPermissionsResult, DescribeSubUserPermissionsRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  为子用户解绑策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public RemovePermissionOfSubUserResponse RemovePermissionOfSubUser(RemovePermissionOfSubUserRequest request) {
            return  new RemovePermissionOfSubUserExecutor().Client(this).Execute<RemovePermissionOfSubUserResponse, RemovePermissionOfSubUserResult, RemovePermissionOfSubUserRequest>(request);
        }
#else
        /// <summary>
        ///  为子用户解绑策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<RemovePermissionOfSubUserResponse> RemovePermissionOfSubUser(RemovePermissionOfSubUserRequest request) {
            return await new RemovePermissionOfSubUserExecutor().Client(this).Execute<RemovePermissionOfSubUserResponse, RemovePermissionOfSubUserResult, RemovePermissionOfSubUserRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询AccessKey列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeUserAccessKeysResponse DescribeUserAccessKeys(DescribeUserAccessKeysRequest request) {
            return  new DescribeUserAccessKeysExecutor().Client(this).Execute<DescribeUserAccessKeysResponse, DescribeUserAccessKeysResult, DescribeUserAccessKeysRequest>(request);
        }
#else
        /// <summary>
        ///  查询AccessKey列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeUserAccessKeysResponse> DescribeUserAccessKeys(DescribeUserAccessKeysRequest request) {
            return await new DescribeUserAccessKeysExecutor().Client(this).Execute<DescribeUserAccessKeysResponse, DescribeUserAccessKeysResult, DescribeUserAccessKeysRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public UpdatePermissionResponse UpdatePermission(UpdatePermissionRequest request) {
            return  new UpdatePermissionExecutor().Client(this).Execute<UpdatePermissionResponse, UpdatePermissionResult, UpdatePermissionRequest>(request);
        }
#else
        /// <summary>
        ///  修改策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<UpdatePermissionResponse> UpdatePermission(UpdatePermissionRequest request) {
            return await new UpdatePermissionExecutor().Client(this).Execute<UpdatePermissionResponse, UpdatePermissionResult, UpdatePermissionRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建子用户
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateSubUserResponse CreateSubUser(CreateSubUserRequest request) {
            return  new CreateSubUserExecutor().Client(this).Execute<CreateSubUserResponse, CreateSubUserResult, CreateSubUserRequest>(request);
        }
#else
        /// <summary>
        ///  创建子用户
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateSubUserResponse> CreateSubUser(CreateSubUserRequest request) {
            return await new CreateSubUserExecutor().Client(this).Execute<CreateSubUserResponse, CreateSubUserResult, CreateSubUserRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreatePermissionResponse CreatePermission(CreatePermissionRequest request) {
            return  new CreatePermissionExecutor().Client(this).Execute<CreatePermissionResponse, CreatePermissionResult, CreatePermissionRequest>(request);
        }
#else
        /// <summary>
        ///  创建策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreatePermissionResponse> CreatePermission(CreatePermissionRequest request) {
            return await new CreatePermissionExecutor().Client(this).Execute<CreatePermissionResponse, CreatePermissionResult, CreatePermissionRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询策略列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribePermissionsResponse DescribePermissions(DescribePermissionsRequest request) {
            return  new DescribePermissionsExecutor().Client(this).Execute<DescribePermissionsResponse, DescribePermissionsResult, DescribePermissionsRequest>(request);
        }
#else
        /// <summary>
        ///  查询策略列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribePermissionsResponse> DescribePermissions(DescribePermissionsRequest request) {
            return await new DescribePermissionsExecutor().Client(this).Execute<DescribePermissionsResponse, DescribePermissionsResult, DescribePermissionsRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询策略详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribePermissionDetailResponse DescribePermissionDetail(DescribePermissionDetailRequest request) {
            return  new DescribePermissionDetailExecutor().Client(this).Execute<DescribePermissionDetailResponse, DescribePermissionDetailResult, DescribePermissionDetailRequest>(request);
        }
#else
        /// <summary>
        ///  查询策略详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribePermissionDetailResponse> DescribePermissionDetail(DescribePermissionDetailRequest request) {
            return await new DescribePermissionDetailExecutor().Client(this).Execute<DescribePermissionDetailResponse, DescribePermissionDetailResult, DescribePermissionDetailRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  为子用户绑定策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AddPermissionsToSubUserResponse AddPermissionsToSubUser(AddPermissionsToSubUserRequest request) {
            return  new AddPermissionsToSubUserExecutor().Client(this).Execute<AddPermissionsToSubUserResponse, AddPermissionsToSubUserResult, AddPermissionsToSubUserRequest>(request);
        }
#else
        /// <summary>
        ///  为子用户绑定策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AddPermissionsToSubUserResponse> AddPermissionsToSubUser(AddPermissionsToSubUserRequest request) {
            return await new AddPermissionsToSubUserExecutor().Client(this).Execute<AddPermissionsToSubUserResponse, AddPermissionsToSubUserResult, AddPermissionsToSubUserRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除AccessKey
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteUserAccessKeyResponse DeleteUserAccessKey(DeleteUserAccessKeyRequest request) {
            return  new DeleteUserAccessKeyExecutor().Client(this).Execute<DeleteUserAccessKeyResponse, DeleteUserAccessKeyResult, DeleteUserAccessKeyRequest>(request);
        }
#else
        /// <summary>
        ///  删除AccessKey
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteUserAccessKeyResponse> DeleteUserAccessKey(DeleteUserAccessKeyRequest request) {
            return await new DeleteUserAccessKeyExecutor().Client(this).Execute<DeleteUserAccessKeyResponse, DeleteUserAccessKeyResult, DeleteUserAccessKeyRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  禁用AccessKey
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DisabledUserAccessKeyResponse DisabledUserAccessKey(DisabledUserAccessKeyRequest request) {
            return  new DisabledUserAccessKeyExecutor().Client(this).Execute<DisabledUserAccessKeyResponse, DisabledUserAccessKeyResult, DisabledUserAccessKeyRequest>(request);
        }
#else
        /// <summary>
        ///  禁用AccessKey
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DisabledUserAccessKeyResponse> DisabledUserAccessKey(DisabledUserAccessKeyRequest request) {
            return await new DisabledUserAccessKeyExecutor().Client(this).Execute<DisabledUserAccessKeyResponse, DisabledUserAccessKeyResult, DisabledUserAccessKeyRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建AccessKey
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateUserAccessKeyResponse CreateUserAccessKey(CreateUserAccessKeyRequest request) {
            return  new CreateUserAccessKeyExecutor().Client(this).Execute<CreateUserAccessKeyResponse, CreateUserAccessKeyResult, CreateUserAccessKeyRequest>(request);
        }
#else
        /// <summary>
        ///  创建AccessKey
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateUserAccessKeyResponse> CreateUserAccessKey(CreateUserAccessKeyRequest request) {
            return await new CreateUserAccessKeyExecutor().Client(this).Execute<CreateUserAccessKeyResponse, CreateUserAccessKeyResult, CreateUserAccessKeyRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  启用AccessKey
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public EnabledUserAccessKeyResponse EnabledUserAccessKey(EnabledUserAccessKeyRequest request) {
            return  new EnabledUserAccessKeyExecutor().Client(this).Execute<EnabledUserAccessKeyResponse, EnabledUserAccessKeyResult, EnabledUserAccessKeyRequest>(request);
        }
#else
        /// <summary>
        ///  启用AccessKey
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<EnabledUserAccessKeyResponse> EnabledUserAccessKey(EnabledUserAccessKeyRequest request) {
            return await new EnabledUserAccessKeyExecutor().Client(this).Execute<EnabledUserAccessKeyResponse, EnabledUserAccessKeyResult, EnabledUserAccessKeyRequest>(request);
        }
#endif

            /// <summary>
            ///  默认IamClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>iamClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>iamClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>iamClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造IamClient 对象
                ///</summary>
                IamClient Build();
            }

            /// <summary>
            ///  默认IamClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  IamClient service client
                /// </summary>
                private  IamClient iamClient;

                /// <summary>
                ///  默认IamClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    iamClient = new IamClient();
                }

                /// <summary>
                ///  构造IamClient 对象
                ///</summary>
                public IamClient Build()
                {
                    if (iamClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        iamClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (iamClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("IamClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (iamClient.HttpRequestConfig == null)
                    {
                        iamClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (iamClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("IamClient build error: http request config not set");
                        }
                    }
                    return iamClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>iamClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    iamClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>iamClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    iamClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>iamClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    iamClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
