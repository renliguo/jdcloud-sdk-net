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
 * 云硬盘API
 * 云硬盘API包含云硬盘相关接口和快照相关接口。可提供批量创建云硬盘，删除云硬盘，制作云硬盘快照等功能。
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Disk.Apis;
using JDCloudSDK.Disk.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Disk.Client
{
    /// <summary>
    ///  云硬盘API
    ///  云硬盘API包含云硬盘相关接口和快照相关接口。可提供批量创建云硬盘，删除云硬盘，制作云硬盘快照等功能。
    ///  Disk Api 客户端
    ///</summary>
    public class DiskClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private DiskClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public DiskClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public DiskClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public DiskClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.0.6
        ///</summary>
        public const string ClientVersion = "1.0.6";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "disk.jdcloud-api.com";
        private const string serviceName = "disk";
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
        ///  为指定云硬盘创建快照,新生成的快照的状态为creating
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request) {
            return  new CreateSnapshotExecutor().Client(this).Execute<CreateSnapshotResponse, CreateSnapshotResult, CreateSnapshotRequest>(request);
        }
#else
        /// <summary>
        ///  为指定云硬盘创建快照,新生成的快照的状态为creating
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateSnapshotResponse> CreateSnapshot(CreateSnapshotRequest request) {
            return await new CreateSnapshotExecutor().Client(this).Execute<CreateSnapshotResponse, CreateSnapshotResult, CreateSnapshotRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  从已有快照恢复一块云硬盘
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public RestoreDiskResponse RestoreDisk(RestoreDiskRequest request) {
            return  new RestoreDiskExecutor().Client(this).Execute<RestoreDiskResponse, RestoreDiskResult, RestoreDiskRequest>(request);
        }
#else
        /// <summary>
        ///  从已有快照恢复一块云硬盘
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<RestoreDiskResponse> RestoreDisk(RestoreDiskRequest request) {
            return await new RestoreDiskExecutor().Client(this).Execute<RestoreDiskResponse, RestoreDiskResult, RestoreDiskRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询云硬盘列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeDisksResponse DescribeDisks(DescribeDisksRequest request) {
            return  new DescribeDisksExecutor().Client(this).Execute<DescribeDisksResponse, DescribeDisksResult, DescribeDisksRequest>(request);
        }
#else
        /// <summary>
        ///  查询云硬盘列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeDisksResponse> DescribeDisks(DescribeDisksRequest request) {
            return await new DescribeDisksExecutor().Client(this).Execute<DescribeDisksResponse, DescribeDisksResult, DescribeDisksRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询云硬盘快照列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request) {
            return  new DescribeSnapshotsExecutor().Client(this).Execute<DescribeSnapshotsResponse, DescribeSnapshotsResult, DescribeSnapshotsRequest>(request);
        }
#else
        /// <summary>
        ///  查询云硬盘快照列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSnapshotsResponse> DescribeSnapshots(DescribeSnapshotsRequest request) {
            return await new DescribeSnapshotsExecutor().Client(this).Execute<DescribeSnapshotsResponse, DescribeSnapshotsResult, DescribeSnapshotsRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询云硬盘信息详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeDiskResponse DescribeDisk(DescribeDiskRequest request) {
            return  new DescribeDiskExecutor().Client(this).Execute<DescribeDiskResponse, DescribeDiskResult, DescribeDiskRequest>(request);
        }
#else
        /// <summary>
        ///  查询云硬盘信息详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeDiskResponse> DescribeDisk(DescribeDiskRequest request) {
            return await new DescribeDiskExecutor().Client(this).Execute<DescribeDiskResponse, DescribeDiskResult, DescribeDiskRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建一块或多块云硬盘
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateDisksResponse CreateDisks(CreateDisksRequest request) {
            return  new CreateDisksExecutor().Client(this).Execute<CreateDisksResponse, CreateDisksResult, CreateDisksRequest>(request);
        }
#else
        /// <summary>
        ///  创建一块或多块云硬盘
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateDisksResponse> CreateDisks(CreateDisksRequest request) {
            return await new CreateDisksExecutor().Client(this).Execute<CreateDisksResponse, CreateDisksResult, CreateDisksRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  扩容云硬盘到指定大小
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ExtendDiskResponse ExtendDisk(ExtendDiskRequest request) {
            return  new ExtendDiskExecutor().Client(this).Execute<ExtendDiskResponse, ExtendDiskResult, ExtendDiskRequest>(request);
        }
#else
        /// <summary>
        ///  扩容云硬盘到指定大小
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ExtendDiskResponse> ExtendDisk(ExtendDiskRequest request) {
            return await new ExtendDiskExecutor().Client(this).Execute<ExtendDiskResponse, ExtendDiskResult, ExtendDiskRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除单个云硬盘
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteDiskResponse DeleteDisk(DeleteDiskRequest request) {
            return  new DeleteDiskExecutor().Client(this).Execute<DeleteDiskResponse, DeleteDiskResult, DeleteDiskRequest>(request);
        }
#else
        /// <summary>
        ///  删除单个云硬盘
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteDiskResponse> DeleteDisk(DeleteDiskRequest request) {
            return await new DeleteDiskExecutor().Client(this).Execute<DeleteDiskResponse, DeleteDiskResult, DeleteDiskRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询云硬盘快照信息详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSnapshotResponse DescribeSnapshot(DescribeSnapshotRequest request) {
            return  new DescribeSnapshotExecutor().Client(this).Execute<DescribeSnapshotResponse, DescribeSnapshotResult, DescribeSnapshotRequest>(request);
        }
#else
        /// <summary>
        ///  查询云硬盘快照信息详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSnapshotResponse> DescribeSnapshot(DescribeSnapshotRequest request) {
            return await new DescribeSnapshotExecutor().Client(this).Execute<DescribeSnapshotResponse, DescribeSnapshotResult, DescribeSnapshotRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除单个云硬盘快照:快照状态必须为 available 或 error 状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request) {
            return  new DeleteSnapshotExecutor().Client(this).Execute<DeleteSnapshotResponse, DeleteSnapshotResult, DeleteSnapshotRequest>(request);
        }
#else
        /// <summary>
        ///  删除单个云硬盘快照:快照状态必须为 available 或 error 状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteSnapshotResponse> DeleteSnapshot(DeleteSnapshotRequest request) {
            return await new DeleteSnapshotExecutor().Client(this).Execute<DeleteSnapshotResponse, DeleteSnapshotResult, DeleteSnapshotRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改快照的名字或描述信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifySnpAttributeResponse ModifySnpAttribute(ModifySnpAttributeRequest request) {
            return  new ModifySnpAttributeExecutor().Client(this).Execute<ModifySnpAttributeResponse, ModifySnpAttributeResult, ModifySnpAttributeRequest>(request);
        }
#else
        /// <summary>
        ///  修改快照的名字或描述信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifySnpAttributeResponse> ModifySnpAttribute(ModifySnpAttributeRequest request) {
            return await new ModifySnpAttributeExecutor().Client(this).Execute<ModifySnpAttributeResponse, ModifySnpAttributeResult, ModifySnpAttributeRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改云硬盘的名字或描述信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyDiskAttributeResponse ModifyDiskAttribute(ModifyDiskAttributeRequest request) {
            return  new ModifyDiskAttributeExecutor().Client(this).Execute<ModifyDiskAttributeResponse, ModifyDiskAttributeResult, ModifyDiskAttributeRequest>(request);
        }
#else
        /// <summary>
        ///  修改云硬盘的名字或描述信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyDiskAttributeResponse> ModifyDiskAttribute(ModifyDiskAttributeRequest request) {
            return await new ModifyDiskAttributeExecutor().Client(this).Execute<ModifyDiskAttributeResponse, ModifyDiskAttributeResult, ModifyDiskAttributeRequest>(request);
        }
#endif

            /// <summary>
            ///  默认DiskClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>diskClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>diskClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>diskClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造DiskClient 对象
                ///</summary>
                DiskClient Build();
            }

            /// <summary>
            ///  默认DiskClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  DiskClient service client
                /// </summary>
                private  DiskClient diskClient;

                /// <summary>
                ///  默认DiskClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    diskClient = new DiskClient();
                }

                /// <summary>
                ///  构造DiskClient 对象
                ///</summary>
                public DiskClient Build()
                {
                    if (diskClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        diskClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (diskClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("DiskClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (diskClient.HttpRequestConfig == null)
                    {
                        diskClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (diskClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("DiskClient build error: http request config not set");
                        }
                    }
                    return diskClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>diskClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    diskClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>diskClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    diskClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>diskClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    diskClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
