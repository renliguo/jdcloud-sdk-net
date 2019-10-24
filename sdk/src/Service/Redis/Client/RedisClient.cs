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
 * JDCloud Redis API
 * 京东云缓存Redis相关接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Redis.Apis;
using JDCloudSDK.Redis.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Redis.Client
{
    /// <summary>
    ///  JDCloud Redis API
    ///  京东云缓存Redis相关接口
    ///  Redis Api 客户端
    ///</summary>
    public class RedisClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private RedisClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public RedisClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public RedisClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public RedisClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.2.0
        ///</summary>
        public const string ClientVersion = "1.2.0";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "redis.jdcloud-api.com";
        private const string serviceName = "redis";
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
        ///  修改缓存Redis实例的自动备份策略，可修改备份周期和备份时间
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyBackupPolicyResponse ModifyBackupPolicy(ModifyBackupPolicyRequest request) {
            return  new ModifyBackupPolicyExecutor().Client(this).Execute<ModifyBackupPolicyResponse, ModifyBackupPolicyResult, ModifyBackupPolicyRequest>(request);
        }
#else
        /// <summary>
        ///  修改缓存Redis实例的自动备份策略，可修改备份周期和备份时间
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyBackupPolicyResponse> ModifyBackupPolicy(ModifyBackupPolicyRequest request) {
            return await new ModifyBackupPolicyExecutor().Client(this).Execute<ModifyBackupPolicyResponse, ModifyBackupPolicyResult, ModifyBackupPolicyRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  变更缓存Redis实例规格（变配），只能变更运行状态的实例规格，变更的规格不能与之前的相同。
        /// 预付费用户，从集群版变配到主从版，新规格的内存大小要大于老规格的内存大小，从主从版到集群版，新规格的内存大小要不小于老规格的内存大小。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyCacheInstanceClassResponse ModifyCacheInstanceClass(ModifyCacheInstanceClassRequest request) {
            return  new ModifyCacheInstanceClassExecutor().Client(this).Execute<ModifyCacheInstanceClassResponse, ModifyCacheInstanceClassResult, ModifyCacheInstanceClassRequest>(request);
        }
#else
        /// <summary>
        ///  变更缓存Redis实例规格（变配），只能变更运行状态的实例规格，变更的规格不能与之前的相同。
        /// 预付费用户，从集群版变配到主从版，新规格的内存大小要大于老规格的内存大小，从主从版到集群版，新规格的内存大小要不小于老规格的内存大小。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyCacheInstanceClassResponse> ModifyCacheInstanceClass(ModifyCacheInstanceClassRequest request) {
            return await new ModifyCacheInstanceClassExecutor().Client(this).Execute<ModifyCacheInstanceClassResponse, ModifyCacheInstanceClassResult, ModifyCacheInstanceClassRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建并执行缓存Redis实例的备份任务，只能为手动备份，可设置备份文件名称
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateBackupResponse CreateBackup(CreateBackupRequest request) {
            return  new CreateBackupExecutor().Client(this).Execute<CreateBackupResponse, CreateBackupResult, CreateBackupRequest>(request);
        }
#else
        /// <summary>
        ///  创建并执行缓存Redis实例的备份任务，只能为手动备份，可设置备份文件名称
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateBackupResponse> CreateBackup(CreateBackupRequest request) {
            return await new CreateBackupExecutor().Client(this).Execute<CreateBackupResponse, CreateBackupResult, CreateBackupRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查看缓存Redis实例的当前配置参数
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeInstanceConfigResponse DescribeInstanceConfig(DescribeInstanceConfigRequest request) {
            return  new DescribeInstanceConfigExecutor().Client(this).Execute<DescribeInstanceConfigResponse, DescribeInstanceConfigResult, DescribeInstanceConfigRequest>(request);
        }
#else
        /// <summary>
        ///  查看缓存Redis实例的当前配置参数
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeInstanceConfigResponse> DescribeInstanceConfig(DescribeInstanceConfigRequest request) {
            return await new DescribeInstanceConfigExecutor().Client(this).Execute<DescribeInstanceConfigResponse, DescribeInstanceConfigResult, DescribeInstanceConfigRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询缓存Redis实例的自动备份策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeBackupPolicyResponse DescribeBackupPolicy(DescribeBackupPolicyRequest request) {
            return  new DescribeBackupPolicyExecutor().Client(this).Execute<DescribeBackupPolicyResponse, DescribeBackupPolicyResult, DescribeBackupPolicyRequest>(request);
        }
#else
        /// <summary>
        ///  查询缓存Redis实例的自动备份策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicy(DescribeBackupPolicyRequest request) {
            return await new DescribeBackupPolicyExecutor().Client(this).Execute<DescribeBackupPolicyResponse, DescribeBackupPolicyResult, DescribeBackupPolicyRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除按配置计费、或包年包月已到期的缓存Redis实例，包年包月未到期不可删除。
        /// 只有处于运行running或者错误error状态才可以删除，其余状态不可以删除。
        /// 白名单用户不能删除包年包月已到期的缓存Redis实例。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteCacheInstanceResponse DeleteCacheInstance(DeleteCacheInstanceRequest request) {
            return  new DeleteCacheInstanceExecutor().Client(this).Execute<DeleteCacheInstanceResponse, DeleteCacheInstanceResult, DeleteCacheInstanceRequest>(request);
        }
#else
        /// <summary>
        ///  删除按配置计费、或包年包月已到期的缓存Redis实例，包年包月未到期不可删除。
        /// 只有处于运行running或者错误error状态才可以删除，其余状态不可以删除。
        /// 白名单用户不能删除包年包月已到期的缓存Redis实例。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteCacheInstanceResponse> DeleteCacheInstance(DeleteCacheInstanceRequest request) {
            return await new DeleteCacheInstanceExecutor().Client(this).Execute<DeleteCacheInstanceResponse, DeleteCacheInstanceResult, DeleteCacheInstanceRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  重置缓存Redis实例的密码，可为空
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ResetCacheInstancePasswordResponse ResetCacheInstancePassword(ResetCacheInstancePasswordRequest request) {
            return  new ResetCacheInstancePasswordExecutor().Client(this).Execute<ResetCacheInstancePasswordResponse, ResetCacheInstancePasswordResult, ResetCacheInstancePasswordRequest>(request);
        }
#else
        /// <summary>
        ///  重置缓存Redis实例的密码，可为空
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ResetCacheInstancePasswordResponse> ResetCacheInstancePassword(ResetCacheInstancePasswordRequest request) {
            return await new ResetCacheInstancePasswordExecutor().Client(this).Execute<ResetCacheInstancePasswordResponse, ResetCacheInstancePasswordResult, ResetCacheInstancePasswordRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取缓存Redis实例的慢查询日志
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSlowLogResponse DescribeSlowLog(DescribeSlowLogRequest request) {
            return  new DescribeSlowLogExecutor().Client(this).Execute<DescribeSlowLogResponse, DescribeSlowLogResult, DescribeSlowLogRequest>(request);
        }
#else
        /// <summary>
        ///  获取缓存Redis实例的慢查询日志
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSlowLogResponse> DescribeSlowLog(DescribeSlowLogRequest request) {
            return await new DescribeSlowLogExecutor().Client(this).Execute<DescribeSlowLogResponse, DescribeSlowLogResult, DescribeSlowLogRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建一个指定配置的缓存Redis实例：可选择主从版或集群版，每种类型又分为多种规格（按CPU核数、内存容量、磁盘容量、带宽等划分），具体可参考产品规格代码，https://docs.jdcloud.com/cn/jcs-for-redis/specifications
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateCacheInstanceResponse CreateCacheInstance(CreateCacheInstanceRequest request) {
            return  new CreateCacheInstanceExecutor().Client(this).Execute<CreateCacheInstanceResponse, CreateCacheInstanceResult, CreateCacheInstanceRequest>(request);
        }
#else
        /// <summary>
        ///  创建一个指定配置的缓存Redis实例：可选择主从版或集群版，每种类型又分为多种规格（按CPU核数、内存容量、磁盘容量、带宽等划分），具体可参考产品规格代码，https://docs.jdcloud.com/cn/jcs-for-redis/specifications
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateCacheInstanceResponse> CreateCacheInstance(CreateCacheInstanceRequest request) {
            return await new CreateCacheInstanceExecutor().Client(this).Execute<CreateCacheInstanceResponse, CreateCacheInstanceResult, CreateCacheInstanceRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  恢复缓存Redis实例的某次备份
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public RestoreInstanceResponse RestoreInstance(RestoreInstanceRequest request) {
            return  new RestoreInstanceExecutor().Client(this).Execute<RestoreInstanceResponse, RestoreInstanceResult, RestoreInstanceRequest>(request);
        }
#else
        /// <summary>
        ///  恢复缓存Redis实例的某次备份
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<RestoreInstanceResponse> RestoreInstance(RestoreInstanceRequest request) {
            return await new RestoreInstanceExecutor().Client(this).Execute<RestoreInstanceResponse, RestoreInstanceResult, RestoreInstanceRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询账户的缓存Redis配额信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeUserQuotaResponse DescribeUserQuota(DescribeUserQuotaRequest request) {
            return  new DescribeUserQuotaExecutor().Client(this).Execute<DescribeUserQuotaResponse, DescribeUserQuotaResult, DescribeUserQuotaRequest>(request);
        }
#else
        /// <summary>
        ///  查询账户的缓存Redis配额信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeUserQuotaResponse> DescribeUserQuota(DescribeUserQuotaRequest request) {
            return await new DescribeUserQuotaExecutor().Client(this).Execute<DescribeUserQuotaResponse, DescribeUserQuotaResult, DescribeUserQuotaRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取缓存Redis实例的备份文件临时下载地址
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeDownloadUrlResponse DescribeDownloadUrl(DescribeDownloadUrlRequest request) {
            return  new DescribeDownloadUrlExecutor().Client(this).Execute<DescribeDownloadUrlResponse, DescribeDownloadUrlResult, DescribeDownloadUrlRequest>(request);
        }
#else
        /// <summary>
        ///  获取缓存Redis实例的备份文件临时下载地址
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeDownloadUrlResponse> DescribeDownloadUrl(DescribeDownloadUrlRequest request) {
            return await new DescribeDownloadUrlExecutor().Client(this).Execute<DescribeDownloadUrlResponse, DescribeDownloadUrlResult, DescribeDownloadUrlRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询缓存Redis实例列表，可分页、可排序、可搜索、可过滤
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeCacheInstancesResponse DescribeCacheInstances(DescribeCacheInstancesRequest request) {
            return  new DescribeCacheInstancesExecutor().Client(this).Execute<DescribeCacheInstancesResponse, DescribeCacheInstancesResult, DescribeCacheInstancesRequest>(request);
        }
#else
        /// <summary>
        ///  查询缓存Redis实例列表，可分页、可排序、可搜索、可过滤
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeCacheInstancesResponse> DescribeCacheInstances(DescribeCacheInstancesRequest request) {
            return await new DescribeCacheInstancesExecutor().Client(this).Execute<DescribeCacheInstancesResponse, DescribeCacheInstancesResult, DescribeCacheInstancesRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询Redis实例的集群内部信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeClusterInfoResponse DescribeClusterInfo(DescribeClusterInfoRequest request) {
            return  new DescribeClusterInfoExecutor().Client(this).Execute<DescribeClusterInfoResponse, DescribeClusterInfoResult, DescribeClusterInfoRequest>(request);
        }
#else
        /// <summary>
        ///  查询Redis实例的集群内部信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeClusterInfoResponse> DescribeClusterInfo(DescribeClusterInfoRequest request) {
            return await new DescribeClusterInfoExecutor().Client(this).Execute<DescribeClusterInfoResponse, DescribeClusterInfoResult, DescribeClusterInfoRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改缓存Redis实例的资源名称或描述，二者至少选一
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyCacheInstanceAttributeResponse ModifyCacheInstanceAttribute(ModifyCacheInstanceAttributeRequest request) {
            return  new ModifyCacheInstanceAttributeExecutor().Client(this).Execute<ModifyCacheInstanceAttributeResponse, ModifyCacheInstanceAttributeResult, ModifyCacheInstanceAttributeRequest>(request);
        }
#else
        /// <summary>
        ///  修改缓存Redis实例的资源名称或描述，二者至少选一
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyCacheInstanceAttributeResponse> ModifyCacheInstanceAttribute(ModifyCacheInstanceAttributeRequest request) {
            return await new ModifyCacheInstanceAttributeExecutor().Client(this).Execute<ModifyCacheInstanceAttributeResponse, ModifyCacheInstanceAttributeResult, ModifyCacheInstanceAttributeRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询缓存Redis实例的备份结果（备份文件列表），可分页、可指定起止时间或备份任务ID
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeBackupsResponse DescribeBackups(DescribeBackupsRequest request) {
            return  new DescribeBackupsExecutor().Client(this).Execute<DescribeBackupsResponse, DescribeBackupsResult, DescribeBackupsRequest>(request);
        }
#else
        /// <summary>
        ///  查询缓存Redis实例的备份结果（备份文件列表），可分页、可指定起止时间或备份任务ID
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeBackupsResponse> DescribeBackups(DescribeBackupsRequest request) {
            return await new DescribeBackupsExecutor().Client(this).Execute<DescribeBackupsResponse, DescribeBackupsResult, DescribeBackupsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询缓存Redis实例的详细信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeCacheInstanceResponse DescribeCacheInstance(DescribeCacheInstanceRequest request) {
            return  new DescribeCacheInstanceExecutor().Client(this).Execute<DescribeCacheInstanceResponse, DescribeCacheInstanceResult, DescribeCacheInstanceRequest>(request);
        }
#else
        /// <summary>
        ///  查询缓存Redis实例的详细信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeCacheInstanceResponse> DescribeCacheInstance(DescribeCacheInstanceRequest request) {
            return await new DescribeCacheInstanceExecutor().Client(this).Execute<DescribeCacheInstanceResponse, DescribeCacheInstanceResult, DescribeCacheInstanceRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改缓存Redis实例的配置参数，支持部分参数修改
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyInstanceConfigResponse ModifyInstanceConfig(ModifyInstanceConfigRequest request) {
            return  new ModifyInstanceConfigExecutor().Client(this).Execute<ModifyInstanceConfigResponse, ModifyInstanceConfigResult, ModifyInstanceConfigRequest>(request);
        }
#else
        /// <summary>
        ///  修改缓存Redis实例的配置参数，支持部分参数修改
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyInstanceConfigResponse> ModifyInstanceConfig(ModifyInstanceConfigRequest request) {
            return await new ModifyInstanceConfigExecutor().Client(this).Execute<ModifyInstanceConfigResponse, ModifyInstanceConfigResult, ModifyInstanceConfigRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询某区域下的缓存Redis实例规格列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeInstanceClassResponse DescribeInstanceClass(DescribeInstanceClassRequest request) {
            return  new DescribeInstanceClassExecutor().Client(this).Execute<DescribeInstanceClassResponse, DescribeInstanceClassResult, DescribeInstanceClassRequest>(request);
        }
#else
        /// <summary>
        ///  查询某区域下的缓存Redis实例规格列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeInstanceClassResponse> DescribeInstanceClass(DescribeInstanceClassRequest request) {
            return await new DescribeInstanceClassExecutor().Client(this).Execute<DescribeInstanceClassResponse, DescribeInstanceClassResult, DescribeInstanceClassRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认RedisClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>redisClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>redisClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>redisClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造RedisClient 对象
                ///</summary>
                RedisClient Build();
            }

            /// <summary>
            ///  默认RedisClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  RedisClient service client
                /// </summary>
                private  RedisClient redisClient;

                /// <summary>
                ///  默认RedisClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    redisClient = new RedisClient();
                }

                /// <summary>
                ///  构造RedisClient 对象
                ///</summary>
                public RedisClient Build()
                {
                    if (redisClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        redisClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (redisClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("RedisClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (redisClient.HttpRequestConfig == null)
                    {
                        redisClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (redisClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("RedisClient build error: http request config not set");
                        }
                    }
                    return redisClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>redisClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    redisClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>redisClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    redisClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>redisClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    redisClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
