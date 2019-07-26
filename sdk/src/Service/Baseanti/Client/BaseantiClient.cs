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
 * Anti-DDoS Basic APIs
 * DDoS 基础防护防护 IP、攻击记录相关接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Baseanti.Apis;
using JDCloudSDK.Baseanti.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Baseanti.Client
{
    /// <summary>
    ///  Anti-DDoS Basic APIs
    ///  DDoS 基础防护防护 IP、攻击记录相关接口
    ///  Baseanti Api 客户端
    ///</summary>
    public class BaseantiClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private BaseantiClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public BaseantiClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public BaseantiClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public BaseantiClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.1.0
        ///</summary>
        public const string ClientVersion = "1.1.0";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "baseanti.jdcloud-api.com";
        private const string serviceName = "baseanti";
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
        ///  查询基础防护已防护公网 IP 安全信息, 支持 ipv4 和 ipv6
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeIpSafetyInfoResponse DescribeIpSafetyInfo(DescribeIpSafetyInfoRequest request) {
            return  new DescribeIpSafetyInfoExecutor().Client(this).Execute<DescribeIpSafetyInfoResponse, DescribeIpSafetyInfoResult, DescribeIpSafetyInfoRequest>(request);
        }
#else
        /// <summary>
        ///  查询基础防护已防护公网 IP 安全信息, 支持 ipv4 和 ipv6
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeIpSafetyInfoResponse> DescribeIpSafetyInfo(DescribeIpSafetyInfoRequest request) {
            return await new DescribeIpSafetyInfoExecutor().Client(this).Execute<DescribeIpSafetyInfoResponse, DescribeIpSafetyInfoResult, DescribeIpSafetyInfoRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  设置基础防护已防护公网 IP 的清洗阈值, 支持 ipv4 和 ipv6
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public SetIpCleanThresholdResponse SetIpCleanThreshold(SetIpCleanThresholdRequest request) {
            return  new SetIpCleanThresholdExecutor().Client(this).Execute<SetIpCleanThresholdResponse, SetIpCleanThresholdResult, SetIpCleanThresholdRequest>(request);
        }
#else
        /// <summary>
        ///  设置基础防护已防护公网 IP 的清洗阈值, 支持 ipv4 和 ipv6
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<SetIpCleanThresholdResponse> SetIpCleanThreshold(SetIpCleanThresholdRequest request) {
            return await new SetIpCleanThresholdExecutor().Client(this).Execute<SetIpCleanThresholdResponse, SetIpCleanThresholdResult, SetIpCleanThresholdRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询多个公网 IP 的监控流量, 支持 ipv4 和 ipv6
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeIpMonitorFlowResponse DescribeIpMonitorFlow(DescribeIpMonitorFlowRequest request) {
            return  new DescribeIpMonitorFlowExecutor().Client(this).Execute<DescribeIpMonitorFlowResponse, DescribeIpMonitorFlowResult, DescribeIpMonitorFlowRequest>(request);
        }
#else
        /// <summary>
        ///  查询多个公网 IP 的监控流量, 支持 ipv4 和 ipv6
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeIpMonitorFlowResponse> DescribeIpMonitorFlow(DescribeIpMonitorFlowRequest request) {
            return await new DescribeIpMonitorFlowExecutor().Client(this).Execute<DescribeIpMonitorFlowResponse, DescribeIpMonitorFlowResult, DescribeIpMonitorFlowRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询基础防护已防护的公网 IP 的安全信息列表. 包括私有网络的弹性公网 IP(运营商级 NAT 保留地址除外), 云物理服务器的公网 IP 和弹性公网 IP. (已废弃, 建议使用 &lt;a href&#x3D;&quot;http://docs.jdcloud.com/anti-ddos-basic/api/describeelasticipresources&quot;&gt;describeElasticIpResources&lt;/a&gt;, &lt;a href&#x3D;&quot;http://docs.jdcloud.com/anti-ddos-basic/api/describecpsipresources&quot;&gt;describeCpsIpResources&lt;/a&gt; 接口)&quot;
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeIpResourcesResponse DescribeIpResources(DescribeIpResourcesRequest request) {
            return  new DescribeIpResourcesExecutor().Client(this).Execute<DescribeIpResourcesResponse, DescribeIpResourcesResult, DescribeIpResourcesRequest>(request);
        }
#else
        /// <summary>
        ///  查询基础防护已防护的公网 IP 的安全信息列表. 包括私有网络的弹性公网 IP(运营商级 NAT 保留地址除外), 云物理服务器的公网 IP 和弹性公网 IP. (已废弃, 建议使用 &lt;a href&#x3D;&quot;http://docs.jdcloud.com/anti-ddos-basic/api/describeelasticipresources&quot;&gt;describeElasticIpResources&lt;/a&gt;, &lt;a href&#x3D;&quot;http://docs.jdcloud.com/anti-ddos-basic/api/describecpsipresources&quot;&gt;describeCpsIpResources&lt;/a&gt; 接口)&quot;
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeIpResourcesResponse> DescribeIpResources(DescribeIpResourcesRequest request) {
            return await new DescribeIpResourcesExecutor().Client(this).Execute<DescribeIpResourcesResponse, DescribeIpResourcesResult, DescribeIpResourcesRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  攻击情况统计
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeAttackStatisticsResponse DescribeAttackStatistics(DescribeAttackStatisticsRequest request) {
            return  new DescribeAttackStatisticsExecutor().Client(this).Execute<DescribeAttackStatisticsResponse, DescribeAttackStatisticsResult, DescribeAttackStatisticsRequest>(request);
        }
#else
        /// <summary>
        ///  攻击情况统计
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeAttackStatisticsResponse> DescribeAttackStatistics(DescribeAttackStatisticsRequest request) {
            return await new DescribeAttackStatisticsExecutor().Client(this).Execute<DescribeAttackStatisticsResponse, DescribeAttackStatisticsResult, DescribeAttackStatisticsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询基础防护已防护的私有网络的弹性公网 IP 的安全信息. 包括私有网络的弹性公网 IP(运营商级 NAT 保留地址除外)
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeElasticIpResourcesResponse DescribeElasticIpResources(DescribeElasticIpResourcesRequest request) {
            return  new DescribeElasticIpResourcesExecutor().Client(this).Execute<DescribeElasticIpResourcesResponse, DescribeElasticIpResourcesResult, DescribeElasticIpResourcesRequest>(request);
        }
#else
        /// <summary>
        ///  查询基础防护已防护的私有网络的弹性公网 IP 的安全信息. 包括私有网络的弹性公网 IP(运营商级 NAT 保留地址除外)
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeElasticIpResourcesResponse> DescribeElasticIpResources(DescribeElasticIpResourcesRequest request) {
            return await new DescribeElasticIpResourcesExecutor().Client(this).Execute<DescribeElasticIpResourcesResponse, DescribeElasticIpResourcesResult, DescribeElasticIpResourcesRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询基础防护已防护的托管区 IP 的安全信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeCcsIpResourcesResponse DescribeCcsIpResources(DescribeCcsIpResourcesRequest request) {
            return  new DescribeCcsIpResourcesExecutor().Client(this).Execute<DescribeCcsIpResourcesResponse, DescribeCcsIpResourcesResult, DescribeCcsIpResourcesRequest>(request);
        }
#else
        /// <summary>
        ///  查询基础防护已防护的托管区 IP 的安全信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeCcsIpResourcesResponse> DescribeCcsIpResources(DescribeCcsIpResourcesRequest request) {
            return await new DescribeCcsIpResourcesExecutor().Client(this).Execute<DescribeCcsIpResourcesResponse, DescribeCcsIpResourcesResult, DescribeCcsIpResourcesRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询公网 IP 可设置清洗阈值范围, 支持 ipv4 和 ipv6
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeIpCleanThresholdRangeResponse DescribeIpCleanThresholdRange(DescribeIpCleanThresholdRangeRequest request) {
            return  new DescribeIpCleanThresholdRangeExecutor().Client(this).Execute<DescribeIpCleanThresholdRangeResponse, DescribeIpCleanThresholdRangeResult, DescribeIpCleanThresholdRangeRequest>(request);
        }
#else
        /// <summary>
        ///  查询公网 IP 可设置清洗阈值范围, 支持 ipv4 和 ipv6
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeIpCleanThresholdRangeResponse> DescribeIpCleanThresholdRange(DescribeIpCleanThresholdRangeRequest request) {
            return await new DescribeIpCleanThresholdRangeExecutor().Client(this).Execute<DescribeIpCleanThresholdRangeResponse, DescribeIpCleanThresholdRangeResult, DescribeIpCleanThresholdRangeRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询各类型攻击次数
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeAttackTypeCountResponse DescribeAttackTypeCount(DescribeAttackTypeCountRequest request) {
            return  new DescribeAttackTypeCountExecutor().Client(this).Execute<DescribeAttackTypeCountResponse, DescribeAttackTypeCountResult, DescribeAttackTypeCountRequest>(request);
        }
#else
        /// <summary>
        ///  查询各类型攻击次数
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeAttackTypeCountResponse> DescribeAttackTypeCount(DescribeAttackTypeCountRequest request) {
            return await new DescribeAttackTypeCountExecutor().Client(this).Execute<DescribeAttackTypeCountResponse, DescribeAttackTypeCountResult, DescribeAttackTypeCountRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询公网 IP 的攻击记录, 仅支持 ipv4. (已废弃, 建议使用 &lt;a href&#x3D;&quot;http://docs.jdcloud.com/anti-ddos-basic/api/describeattacklogs&quot;&gt;describeAttackLogs&lt;/a&gt; 接口)
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeIpResourceProtectInfoResponse DescribeIpResourceProtectInfo(DescribeIpResourceProtectInfoRequest request) {
            return  new DescribeIpResourceProtectInfoExecutor().Client(this).Execute<DescribeIpResourceProtectInfoResponse, DescribeIpResourceProtectInfoResult, DescribeIpResourceProtectInfoRequest>(request);
        }
#else
        /// <summary>
        ///  查询公网 IP 的攻击记录, 仅支持 ipv4. (已废弃, 建议使用 &lt;a href&#x3D;&quot;http://docs.jdcloud.com/anti-ddos-basic/api/describeattacklogs&quot;&gt;describeAttackLogs&lt;/a&gt; 接口)
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeIpResourceProtectInfoResponse> DescribeIpResourceProtectInfo(DescribeIpResourceProtectInfoRequest request) {
            return await new DescribeIpResourceProtectInfoExecutor().Client(this).Execute<DescribeIpResourceProtectInfoResponse, DescribeIpResourceProtectInfoResult, DescribeIpResourceProtectInfoRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询基础防护已防护的云物理服务器公网 IP 的安全信息. 包括云物理服务器的公网 IP 和弹性公网 IP.
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeCpsIpResourcesResponse DescribeCpsIpResources(DescribeCpsIpResourcesRequest request) {
            return  new DescribeCpsIpResourcesExecutor().Client(this).Execute<DescribeCpsIpResourcesResponse, DescribeCpsIpResourcesResult, DescribeCpsIpResourcesRequest>(request);
        }
#else
        /// <summary>
        ///  查询基础防护已防护的云物理服务器公网 IP 的安全信息. 包括云物理服务器的公网 IP 和弹性公网 IP.
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeCpsIpResourcesResponse> DescribeCpsIpResources(DescribeCpsIpResourcesRequest request) {
            return await new DescribeCpsIpResourcesExecutor().Client(this).Execute<DescribeCpsIpResourcesResponse, DescribeCpsIpResourcesResult, DescribeCpsIpResourcesRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  设置基础防护已防护公网 IP 的清洗阈值, 仅支持 ipv4. (已废弃, 建议使用 &lt;a href&#x3D;&quot;http://docs.jdcloud.com/anti-ddos-basic/api/setipcleanthreshold&quot;&gt;setIpCleanThreshold&lt;/a&gt; 接口)
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public SetCleanThresholdResponse SetCleanThreshold(SetCleanThresholdRequest request) {
            return  new SetCleanThresholdExecutor().Client(this).Execute<SetCleanThresholdResponse, SetCleanThresholdResult, SetCleanThresholdRequest>(request);
        }
#else
        /// <summary>
        ///  设置基础防护已防护公网 IP 的清洗阈值, 仅支持 ipv4. (已废弃, 建议使用 &lt;a href&#x3D;&quot;http://docs.jdcloud.com/anti-ddos-basic/api/setipcleanthreshold&quot;&gt;setIpCleanThreshold&lt;/a&gt; 接口)
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<SetCleanThresholdResponse> SetCleanThreshold(SetCleanThresholdRequest request) {
            return await new SetCleanThresholdExecutor().Client(this).Execute<SetCleanThresholdResponse, SetCleanThresholdResult, SetCleanThresholdRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询公网 IP 的 endTime 之前 15 分钟内监控流量, 仅支持 ipv4. (已废弃, 建议使用 &lt;a href&#x3D;&quot;http://docs.jdcloud.com/anti-ddos-basic/api/describeipmonitorflow&quot;&gt;describeIpMonitorFlow&lt;/a&gt; 接口)
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeIpResourceFlowResponse DescribeIpResourceFlow(DescribeIpResourceFlowRequest request) {
            return  new DescribeIpResourceFlowExecutor().Client(this).Execute<DescribeIpResourceFlowResponse, DescribeIpResourceFlowResult, DescribeIpResourceFlowRequest>(request);
        }
#else
        /// <summary>
        ///  查询公网 IP 的 endTime 之前 15 分钟内监控流量, 仅支持 ipv4. (已废弃, 建议使用 &lt;a href&#x3D;&quot;http://docs.jdcloud.com/anti-ddos-basic/api/describeipmonitorflow&quot;&gt;describeIpMonitorFlow&lt;/a&gt; 接口)
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeIpResourceFlowResponse> DescribeIpResourceFlow(DescribeIpResourceFlowRequest request) {
            return await new DescribeIpResourceFlowExecutor().Client(this).Execute<DescribeIpResourceFlowResponse, DescribeIpResourceFlowResult, DescribeIpResourceFlowRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询公网 IP 安全信息, 仅支持 ipv4. (已废弃, 建议使用 &lt;a href&#x3D;&quot;http://docs.jdcloud.com/anti-ddos-basic/api/describeipsafetyinfo&quot;&gt;describeIpSafetyInfo&lt;/a&gt; 接口)
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeIpResourceInfoResponse DescribeIpResourceInfo(DescribeIpResourceInfoRequest request) {
            return  new DescribeIpResourceInfoExecutor().Client(this).Execute<DescribeIpResourceInfoResponse, DescribeIpResourceInfoResult, DescribeIpResourceInfoRequest>(request);
        }
#else
        /// <summary>
        ///  查询公网 IP 安全信息, 仅支持 ipv4. (已废弃, 建议使用 &lt;a href&#x3D;&quot;http://docs.jdcloud.com/anti-ddos-basic/api/describeipsafetyinfo&quot;&gt;describeIpSafetyInfo&lt;/a&gt; 接口)
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeIpResourceInfoResponse> DescribeIpResourceInfo(DescribeIpResourceInfoRequest request) {
            return await new DescribeIpResourceInfoExecutor().Client(this).Execute<DescribeIpResourceInfoResponse, DescribeIpResourceInfoResult, DescribeIpResourceInfoRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询攻击记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeAttackLogsResponse DescribeAttackLogs(DescribeAttackLogsRequest request) {
            return  new DescribeAttackLogsExecutor().Client(this).Execute<DescribeAttackLogsResponse, DescribeAttackLogsResult, DescribeAttackLogsRequest>(request);
        }
#else
        /// <summary>
        ///  查询攻击记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeAttackLogsResponse> DescribeAttackLogs(DescribeAttackLogsRequest request) {
            return await new DescribeAttackLogsExecutor().Client(this).Execute<DescribeAttackLogsResponse, DescribeAttackLogsResult, DescribeAttackLogsRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认BaseantiClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>baseantiClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>baseantiClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>baseantiClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造BaseantiClient 对象
                ///</summary>
                BaseantiClient Build();
            }

            /// <summary>
            ///  默认BaseantiClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  BaseantiClient service client
                /// </summary>
                private  BaseantiClient baseantiClient;

                /// <summary>
                ///  默认BaseantiClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    baseantiClient = new BaseantiClient();
                }

                /// <summary>
                ///  构造BaseantiClient 对象
                ///</summary>
                public BaseantiClient Build()
                {
                    if (baseantiClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        baseantiClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (baseantiClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("BaseantiClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (baseantiClient.HttpRequestConfig == null)
                    {
                        baseantiClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (baseantiClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("BaseantiClient build error: http request config not set");
                        }
                    }
                    return baseantiClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>baseantiClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    baseantiClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>baseantiClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    baseantiClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>baseantiClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    baseantiClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
