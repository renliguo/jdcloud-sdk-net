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
 * 京东云解析OpenAPI接口
 * 京东云解析OpenAPI接口
 *
 * OpenAPI spec version: v2
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Domainservice.Apis;
using JDCloudSDK.Domainservice.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Domainservice.Client
{
    /// <summary>
    ///  京东云解析OpenAPI接口
    ///  京东云解析OpenAPI接口
    ///  Domainservice Api 客户端
    ///</summary>
    public class DomainserviceClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private DomainserviceClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public DomainserviceClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public DomainserviceClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public DomainserviceClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.2.0
        ///</summary>
        public const string ClientVersion = "1.2.0";

        private const string apiVersion = "v2";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "domainservice.jdcloud-api.com";
        private const string serviceName = "domainservice";
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
        ///  删除主域名的自定义解析线路的IP段
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteUserViewIPResponse DeleteUserViewIP(DeleteUserViewIPRequest request) {
            return  new DeleteUserViewIPExecutor().Client(this).Execute<DeleteUserViewIPResponse, DeleteUserViewIPResult, DeleteUserViewIPRequest>(request);
        }
#else
        /// <summary>
        ///  删除主域名的自定义解析线路的IP段
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteUserViewIPResponse> DeleteUserViewIP(DeleteUserViewIPRequest request) {
            return await new DeleteUserViewIPExecutor().Client(this).Execute<DeleteUserViewIPResponse, DeleteUserViewIPResult, DeleteUserViewIPRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查看用户在云解析服务下的操作记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeActionLogResponse DescribeActionLog(DescribeActionLogRequest request) {
            return  new DescribeActionLogExecutor().Client(this).Execute<DescribeActionLogResponse, DescribeActionLogResult, DescribeActionLogRequest>(request);
        }
#else
        /// <summary>
        ///  查看用户在云解析服务下的操作记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeActionLogResponse> DescribeActionLog(DescribeActionLogRequest request) {
            return await new DescribeActionLogExecutor().Client(this).Execute<DescribeActionLogResponse, DescribeActionLogResult, DescribeActionLogRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查看主域名的解析次数
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeDomainQueryCountResponse DescribeDomainQueryCount(DescribeDomainQueryCountRequest request) {
            return  new DescribeDomainQueryCountExecutor().Client(this).Execute<DescribeDomainQueryCountResponse, DescribeDomainQueryCountResult, DescribeDomainQueryCountRequest>(request);
        }
#else
        /// <summary>
        ///  查看主域名的解析次数
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeDomainQueryCountResponse> DescribeDomainQueryCount(DescribeDomainQueryCountRequest request) {
            return await new DescribeDomainQueryCountExecutor().Client(this).Execute<DescribeDomainQueryCountResponse, DescribeDomainQueryCountResult, DescribeDomainQueryCountRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查看域名的查询流量
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeDomainQueryTrafficResponse DescribeDomainQueryTraffic(DescribeDomainQueryTrafficRequest request) {
            return  new DescribeDomainQueryTrafficExecutor().Client(this).Execute<DescribeDomainQueryTrafficResponse, DescribeDomainQueryTrafficResult, DescribeDomainQueryTrafficRequest>(request);
        }
#else
        /// <summary>
        ///  查看域名的查询流量
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeDomainQueryTrafficResponse> DescribeDomainQueryTraffic(DescribeDomainQueryTrafficRequest request) {
            return await new DescribeDomainQueryTrafficExecutor().Client(this).Execute<DescribeDomainQueryTrafficResponse, DescribeDomainQueryTrafficResult, DescribeDomainQueryTrafficRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  监控项的操作集合，包括：暂停，启动, 手动恢复, 手动切换
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyMonitorStatusResponse ModifyMonitorStatus(ModifyMonitorStatusRequest request) {
            return  new ModifyMonitorStatusExecutor().Client(this).Execute<ModifyMonitorStatusResponse, ModifyMonitorStatusResult, ModifyMonitorStatusRequest>(request);
        }
#else
        /// <summary>
        ///  监控项的操作集合，包括：暂停，启动, 手动恢复, 手动切换
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyMonitorStatusResponse> ModifyMonitorStatus(ModifyMonitorStatusRequest request) {
            return await new ModifyMonitorStatusExecutor().Client(this).Execute<ModifyMonitorStatusResponse, ModifyMonitorStatusResult, ModifyMonitorStatusRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  添加主域名的解析记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateResourceRecordResponse CreateResourceRecord(CreateResourceRecordRequest request) {
            return  new CreateResourceRecordExecutor().Client(this).Execute<CreateResourceRecordResponse, CreateResourceRecordResult, CreateResourceRecordRequest>(request);
        }
#else
        /// <summary>
        ///  添加主域名的解析记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateResourceRecordResponse> CreateResourceRecord(CreateResourceRecordRequest request) {
            return await new CreateResourceRecordExecutor().Client(this).Execute<CreateResourceRecordResponse, CreateResourceRecordResult, CreateResourceRecordRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改主域名
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyDomainResponse ModifyDomain(ModifyDomainRequest request) {
            return  new ModifyDomainExecutor().Client(this).Execute<ModifyDomainResponse, ModifyDomainResult, ModifyDomainRequest>(request);
        }
#else
        /// <summary>
        ///  修改主域名
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyDomainResponse> ModifyDomain(ModifyDomainRequest request) {
            return await new ModifyDomainExecutor().Client(this).Execute<ModifyDomainResponse, ModifyDomainResult, ModifyDomainRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  同一个主域名下，批量新增或者批量更新导入解析记录。
        /// 如果解析记录的ID为0，是新增解析记录，如果不为0，则是更新解析记录。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public BatchSetResourceRecordsResponse BatchSetResourceRecords(BatchSetResourceRecordsRequest request) {
            return  new BatchSetResourceRecordsExecutor().Client(this).Execute<BatchSetResourceRecordsResponse, BatchSetResourceRecordsResult, BatchSetResourceRecordsRequest>(request);
        }
#else
        /// <summary>
        ///  同一个主域名下，批量新增或者批量更新导入解析记录。
        /// 如果解析记录的ID为0，是新增解析记录，如果不为0，则是更新解析记录。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<BatchSetResourceRecordsResponse> BatchSetResourceRecords(BatchSetResourceRecordsRequest request) {
            return await new BatchSetResourceRecordsExecutor().Client(this).Execute<BatchSetResourceRecordsResponse, BatchSetResourceRecordsResult, BatchSetResourceRecordsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询子域名的可用监控对象
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeMonitorTargetResponse DescribeMonitorTarget(DescribeMonitorTargetRequest request) {
            return  new DescribeMonitorTargetExecutor().Client(this).Execute<DescribeMonitorTargetResponse, DescribeMonitorTargetResult, DescribeMonitorTargetRequest>(request);
        }
#else
        /// <summary>
        ///  查询子域名的可用监控对象
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeMonitorTargetResponse> DescribeMonitorTarget(DescribeMonitorTargetRequest request) {
            return await new DescribeMonitorTargetExecutor().Client(this).Execute<DescribeMonitorTargetResponse, DescribeMonitorTargetResult, DescribeMonitorTargetRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  添加子域名的某些特定监控对象为监控项
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateMonitorTargetResponse CreateMonitorTarget(CreateMonitorTargetRequest request) {
            return  new CreateMonitorTargetExecutor().Client(this).Execute<CreateMonitorTargetResponse, CreateMonitorTargetResult, CreateMonitorTargetRequest>(request);
        }
#else
        /// <summary>
        ///  添加子域名的某些特定监控对象为监控项
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateMonitorTargetResponse> CreateMonitorTarget(CreateMonitorTargetRequest request) {
            return await new CreateMonitorTargetExecutor().Client(this).Execute<CreateMonitorTargetResponse, CreateMonitorTargetResult, CreateMonitorTargetRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  添加主域名  
        /// 如何添加免费域名，详细情况请查阅&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/jd-cloud-dns/domainadd&quot;&gt;文档&lt;/a&gt;
        /// 添加收费域名，请查阅&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/jd-cloud-dns/purchase-process&quot;&gt;文档&lt;/a&gt;，
        /// 添加收费域名前，请确保用户的京东云账户有足够的资金支付，Openapi接口回返回订单号，可以用此订单号向计费系统查阅详情。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateDomainResponse CreateDomain(CreateDomainRequest request) {
            return  new CreateDomainExecutor().Client(this).Execute<CreateDomainResponse, CreateDomainResult, CreateDomainRequest>(request);
        }
#else
        /// <summary>
        ///  添加主域名  
        /// 如何添加免费域名，详细情况请查阅&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/jd-cloud-dns/domainadd&quot;&gt;文档&lt;/a&gt;
        /// 添加收费域名，请查阅&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/jd-cloud-dns/purchase-process&quot;&gt;文档&lt;/a&gt;，
        /// 添加收费域名前，请确保用户的京东云账户有足够的资金支付，Openapi接口回返回订单号，可以用此订单号向计费系统查阅详情。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateDomainResponse> CreateDomain(CreateDomainRequest request) {
            return await new CreateDomainExecutor().Client(this).Execute<CreateDomainResponse, CreateDomainResult, CreateDomainRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询主域名的自定义解析线路的IP段
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeUserViewIPResponse DescribeUserViewIP(DescribeUserViewIPRequest request) {
            return  new DescribeUserViewIPExecutor().Client(this).Execute<DescribeUserViewIPResponse, DescribeUserViewIPResult, DescribeUserViewIPRequest>(request);
        }
#else
        /// <summary>
        ///  查询主域名的自定义解析线路的IP段
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeUserViewIPResponse> DescribeUserViewIP(DescribeUserViewIPRequest request) {
            return await new DescribeUserViewIPExecutor().Client(this).Execute<DescribeUserViewIPResponse, DescribeUserViewIPResult, DescribeUserViewIPRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  启用、停用主域名下的解析记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyResourceRecordStatusResponse ModifyResourceRecordStatus(ModifyResourceRecordStatusRequest request) {
            return  new ModifyResourceRecordStatusExecutor().Client(this).Execute<ModifyResourceRecordStatusResponse, ModifyResourceRecordStatusResult, ModifyResourceRecordStatusRequest>(request);
        }
#else
        /// <summary>
        ///  启用、停用主域名下的解析记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyResourceRecordStatusResponse> ModifyResourceRecordStatus(ModifyResourceRecordStatusRequest request) {
            return await new ModifyResourceRecordStatusExecutor().Client(this).Execute<ModifyResourceRecordStatusResponse, ModifyResourceRecordStatusResult, ModifyResourceRecordStatusRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改主域名的某个解析记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyResourceRecordResponse ModifyResourceRecord(ModifyResourceRecordRequest request) {
            return  new ModifyResourceRecordExecutor().Client(this).Execute<ModifyResourceRecordResponse, ModifyResourceRecordResult, ModifyResourceRecordRequest>(request);
        }
#else
        /// <summary>
        ///  修改主域名的某个解析记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyResourceRecordResponse> ModifyResourceRecord(ModifyResourceRecordRequest request) {
            return await new ModifyResourceRecordExecutor().Client(this).Execute<ModifyResourceRecordResponse, ModifyResourceRecordResult, ModifyResourceRecordRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取用户所属的主域名列表。   
        /// 请在调用域名相关的接口之前，调用此接口获取相关的domainId和domainName。  
        /// 主域名的相关概念，请查阅&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/jd-cloud-dns/product-overview&quot;&gt;云解析文档&lt;/a&gt;
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request) {
            return  new DescribeDomainsExecutor().Client(this).Execute<DescribeDomainsResponse, DescribeDomainsResult, DescribeDomainsRequest>(request);
        }
#else
        /// <summary>
        ///  获取用户所属的主域名列表。   
        /// 请在调用域名相关的接口之前，调用此接口获取相关的domainId和domainName。  
        /// 主域名的相关概念，请查阅&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/jd-cloud-dns/product-overview&quot;&gt;云解析文档&lt;/a&gt;
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeDomainsResponse> DescribeDomains(DescribeDomainsRequest request) {
            return await new DescribeDomainsExecutor().Client(this).Execute<DescribeDomainsResponse, DescribeDomainsResult, DescribeDomainsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  添加子域名的监控项，默认把子域名的所有监控项都添加上监控
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateMonitorResponse CreateMonitor(CreateMonitorRequest request) {
            return  new CreateMonitorExecutor().Client(this).Execute<CreateMonitorResponse, CreateMonitorResult, CreateMonitorRequest>(request);
        }
#else
        /// <summary>
        ///  添加子域名的监控项，默认把子域名的所有监控项都添加上监控
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateMonitorResponse> CreateMonitor(CreateMonitorRequest request) {
            return await new CreateMonitorExecutor().Client(this).Execute<CreateMonitorResponse, CreateMonitorResult, CreateMonitorRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  添加主域名的自定义解析线路的IP段
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateUserViewIPResponse CreateUserViewIP(CreateUserViewIPRequest request) {
            return  new CreateUserViewIPExecutor().Client(this).Execute<CreateUserViewIPResponse, CreateUserViewIPResult, CreateUserViewIPRequest>(request);
        }
#else
        /// <summary>
        ///  添加主域名的自定义解析线路的IP段
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateUserViewIPResponse> CreateUserViewIP(CreateUserViewIPRequest request) {
            return await new CreateUserViewIPExecutor().Client(this).Execute<CreateUserViewIPResponse, CreateUserViewIPResult, CreateUserViewIPRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除主域名的自定义解析线路
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteUserViewResponse DeleteUserView(DeleteUserViewRequest request) {
            return  new DeleteUserViewExecutor().Client(this).Execute<DeleteUserViewResponse, DeleteUserViewResult, DeleteUserViewRequest>(request);
        }
#else
        /// <summary>
        ///  删除主域名的自定义解析线路
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteUserViewResponse> DeleteUserView(DeleteUserViewRequest request) {
            return await new DeleteUserViewExecutor().Client(this).Execute<DeleteUserViewResponse, DeleteUserViewResult, DeleteUserViewRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  域名的监控项修改
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyMonitorResponse ModifyMonitor(ModifyMonitorRequest request) {
            return  new ModifyMonitorExecutor().Client(this).Execute<ModifyMonitorResponse, ModifyMonitorResult, ModifyMonitorRequest>(request);
        }
#else
        /// <summary>
        ///  域名的监控项修改
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyMonitorResponse> ModifyMonitor(ModifyMonitorRequest request) {
            return await new ModifyMonitorExecutor().Client(this).Execute<ModifyMonitorResponse, ModifyMonitorResult, ModifyMonitorRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询主域名的解析记录。  
        /// 在使用解析记录相关的接口之前，请调用此接口获取解析记录的列表。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeResourceRecordResponse DescribeResourceRecord(DescribeResourceRecordRequest request) {
            return  new DescribeResourceRecordExecutor().Client(this).Execute<DescribeResourceRecordResponse, DescribeResourceRecordResult, DescribeResourceRecordRequest>(request);
        }
#else
        /// <summary>
        ///  查询主域名的解析记录。  
        /// 在使用解析记录相关的接口之前，请调用此接口获取解析记录的列表。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeResourceRecordResponse> DescribeResourceRecord(DescribeResourceRecordRequest request) {
            return await new DescribeResourceRecordExecutor().Client(this).Execute<DescribeResourceRecordResponse, DescribeResourceRecordResult, DescribeResourceRecordRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询主域名的自定义解析线路
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeUserViewResponse DescribeUserView(DescribeUserViewRequest request) {
            return  new DescribeUserViewExecutor().Client(this).Execute<DescribeUserViewResponse, DescribeUserViewResult, DescribeUserViewRequest>(request);
        }
#else
        /// <summary>
        ///  查询主域名的自定义解析线路
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeUserViewResponse> DescribeUserView(DescribeUserViewRequest request) {
            return await new DescribeUserViewExecutor().Client(this).Execute<DescribeUserViewResponse, DescribeUserViewResult, DescribeUserViewRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  主域名的监控项的报警信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeMonitorAlarmResponse DescribeMonitorAlarm(DescribeMonitorAlarmRequest request) {
            return  new DescribeMonitorAlarmExecutor().Client(this).Execute<DescribeMonitorAlarmResponse, DescribeMonitorAlarmResult, DescribeMonitorAlarmRequest>(request);
        }
#else
        /// <summary>
        ///  主域名的监控项的报警信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeMonitorAlarmResponse> DescribeMonitorAlarm(DescribeMonitorAlarmRequest request) {
            return await new DescribeMonitorAlarmExecutor().Client(this).Execute<DescribeMonitorAlarmResponse, DescribeMonitorAlarmResult, DescribeMonitorAlarmRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  添加主域名的自定义解析线路
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateUserViewResponse CreateUserView(CreateUserViewRequest request) {
            return  new CreateUserViewExecutor().Client(this).Execute<CreateUserViewResponse, CreateUserViewResult, CreateUserViewRequest>(request);
        }
#else
        /// <summary>
        ///  添加主域名的自定义解析线路
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateUserViewResponse> CreateUserView(CreateUserViewRequest request) {
            return await new CreateUserViewExecutor().Client(this).Execute<CreateUserViewResponse, CreateUserViewResult, CreateUserViewRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询云解析所有的基础解析线路。  
        /// 在使用解析线路的参数之前，请调用此接口获取解析线路的ID。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeViewTreeResponse DescribeViewTree(DescribeViewTreeRequest request) {
            return  new DescribeViewTreeExecutor().Client(this).Execute<DescribeViewTreeResponse, DescribeViewTreeResult, DescribeViewTreeRequest>(request);
        }
#else
        /// <summary>
        ///  查询云解析所有的基础解析线路。  
        /// 在使用解析线路的参数之前，请调用此接口获取解析线路的ID。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeViewTreeResponse> DescribeViewTree(DescribeViewTreeRequest request) {
            return await new DescribeViewTreeExecutor().Client(this).Execute<DescribeViewTreeResponse, DescribeViewTreeResult, DescribeViewTreeRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除主域名下的解析记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteResourceRecordResponse DeleteResourceRecord(DeleteResourceRecordRequest request) {
            return  new DeleteResourceRecordExecutor().Client(this).Execute<DeleteResourceRecordResponse, DeleteResourceRecordResult, DeleteResourceRecordRequest>(request);
        }
#else
        /// <summary>
        ///  删除主域名下的解析记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteResourceRecordResponse> DeleteResourceRecord(DeleteResourceRecordRequest request) {
            return await new DeleteResourceRecordExecutor().Client(this).Execute<DeleteResourceRecordResponse, DeleteResourceRecordResult, DeleteResourceRecordRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查看主域名的监控项的配置以及状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeMonitorResponse DescribeMonitor(DescribeMonitorRequest request) {
            return  new DescribeMonitorExecutor().Client(this).Execute<DescribeMonitorResponse, DescribeMonitorResult, DescribeMonitorRequest>(request);
        }
#else
        /// <summary>
        ///  查看主域名的监控项的配置以及状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeMonitorResponse> DescribeMonitor(DescribeMonitorRequest request) {
            return await new DescribeMonitorExecutor().Client(this).Execute<DescribeMonitorResponse, DescribeMonitorResult, DescribeMonitorRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  监控项的删除
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteMonitorResponse DeleteMonitor(DeleteMonitorRequest request) {
            return  new DeleteMonitorExecutor().Client(this).Execute<DeleteMonitorResponse, DeleteMonitorResult, DeleteMonitorRequest>(request);
        }
#else
        /// <summary>
        ///  监控项的删除
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteMonitorResponse> DeleteMonitor(DeleteMonitorRequest request) {
            return await new DeleteMonitorExecutor().Client(this).Execute<DeleteMonitorResponse, DeleteMonitorResult, DeleteMonitorRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除主域名
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest request) {
            return  new DeleteDomainExecutor().Client(this).Execute<DeleteDomainResponse, DeleteDomainResult, DeleteDomainRequest>(request);
        }
#else
        /// <summary>
        ///  删除主域名
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteDomainResponse> DeleteDomain(DeleteDomainRequest request) {
            return await new DeleteDomainExecutor().Client(this).Execute<DeleteDomainResponse, DeleteDomainResult, DeleteDomainRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认DomainserviceClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>domainserviceClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>domainserviceClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>domainserviceClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造DomainserviceClient 对象
                ///</summary>
                DomainserviceClient Build();
            }

            /// <summary>
            ///  默认DomainserviceClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  DomainserviceClient service client
                /// </summary>
                private  DomainserviceClient domainserviceClient;

                /// <summary>
                ///  默认DomainserviceClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    domainserviceClient = new DomainserviceClient();
                }

                /// <summary>
                ///  构造DomainserviceClient 对象
                ///</summary>
                public DomainserviceClient Build()
                {
                    if (domainserviceClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        domainserviceClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (domainserviceClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("DomainserviceClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (domainserviceClient.HttpRequestConfig == null)
                    {
                        domainserviceClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (domainserviceClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("DomainserviceClient build error: http request config not set");
                        }
                    }
                    return domainserviceClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>domainserviceClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    domainserviceClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>domainserviceClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    domainserviceClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>domainserviceClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    domainserviceClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
