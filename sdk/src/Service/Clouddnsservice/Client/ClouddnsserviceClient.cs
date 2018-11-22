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
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Clouddnsservice.Apis;
using JDCloudSDK.Clouddnsservice.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Clouddnsservice.Client
{
    /// <summary>
    ///  京东云解析OpenAPI接口
    ///  京东云解析OpenAPI接口
    ///  Clouddnsservice Api 客户端
    ///</summary>
    public class ClouddnsserviceClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private ClouddnsserviceClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public ClouddnsserviceClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public ClouddnsserviceClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public ClouddnsserviceClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.0.7
        ///</summary>
        public const string ClientVersion = "1.0.7";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "clouddnsservice.jdcloud-api.com";
        private const string serviceName = "clouddnsservice";
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
        ///  删除主域名
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DelDomainResponse DelDomain(DelDomainRequest request) {
            return  new DelDomainExecutor().Client(this).Execute<DelDomainResponse, DelDomainResult, DelDomainRequest>(request);
        }
#else
        /// <summary>
        ///  删除主域名
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DelDomainResponse> DelDomain(DelDomainRequest request) {
            return await new DelDomainExecutor().Client(this).Execute<DelDomainResponse, DelDomainResult, DelDomainRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  域名的监控项修改
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public UpdateMonitorResponse UpdateMonitor(UpdateMonitorRequest request) {
            return  new UpdateMonitorExecutor().Client(this).Execute<UpdateMonitorResponse, UpdateMonitorResult, UpdateMonitorRequest>(request);
        }
#else
        /// <summary>
        ///  域名的监控项修改
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<UpdateMonitorResponse> UpdateMonitor(UpdateMonitorRequest request) {
            return await new UpdateMonitorExecutor().Client(this).Execute<UpdateMonitorResponse, UpdateMonitorResult, UpdateMonitorRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除域名的自定义解析线路的IP段
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DelUserViewIPResponse DelUserViewIP(DelUserViewIPRequest request) {
            return  new DelUserViewIPExecutor().Client(this).Execute<DelUserViewIPResponse, DelUserViewIPResult, DelUserViewIPRequest>(request);
        }
#else
        /// <summary>
        ///  删除域名的自定义解析线路的IP段
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DelUserViewIPResponse> DelUserViewIP(DelUserViewIPRequest request) {
            return await new DelUserViewIPExecutor().Client(this).Execute<DelUserViewIPResponse, DelUserViewIPResult, DelUserViewIPRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查看用户在云解析服务下的操作记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetActionLogResponse GetActionLog(GetActionLogRequest request) {
            return  new GetActionLogExecutor().Client(this).Execute<GetActionLogResponse, GetActionLogResult, GetActionLogRequest>(request);
        }
#else
        /// <summary>
        ///  查看用户在云解析服务下的操作记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetActionLogResponse> GetActionLog(GetActionLogRequest request) {
            return await new GetActionLogExecutor().Client(this).Execute<GetActionLogResponse, GetActionLogResult, GetActionLogRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  添加域名的解析记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AddRRResponse AddRR(AddRRRequest request) {
            return  new AddRRExecutor().Client(this).Execute<AddRRResponse, AddRRResult, AddRRRequest>(request);
        }
#else
        /// <summary>
        ///  添加域名的解析记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AddRRResponse> AddRR(AddRRRequest request) {
            return await new AddRRExecutor().Client(this).Execute<AddRRResponse, AddRRResult, AddRRRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询用户名下的主域名列表。&lt;br&gt;    
        /// 请在调用域名相关的API之前，调用此API获取相关的domainId和domainName。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetDomainsResponse GetDomains(GetDomainsRequest request) {
            return  new GetDomainsExecutor().Client(this).Execute<GetDomainsResponse, GetDomainsResult, GetDomainsRequest>(request);
        }
#else
        /// <summary>
        ///  查询用户名下的主域名列表。&lt;br&gt;    
        /// 请在调用域名相关的API之前，调用此API获取相关的domainId和domainName。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetDomainsResponse> GetDomains(GetDomainsRequest request) {
            return await new GetDomainsExecutor().Client(this).Execute<GetDomainsResponse, GetDomainsResult, GetDomainsRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  主域名的监控项的报警信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetMonitorAlarmInfoResponse GetMonitorAlarmInfo(GetMonitorAlarmInfoRequest request) {
            return  new GetMonitorAlarmInfoExecutor().Client(this).Execute<GetMonitorAlarmInfoResponse, GetMonitorAlarmInfoResult, GetMonitorAlarmInfoRequest>(request);
        }
#else
        /// <summary>
        ///  主域名的监控项的报警信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetMonitorAlarmInfoResponse> GetMonitorAlarmInfo(GetMonitorAlarmInfoRequest request) {
            return await new GetMonitorAlarmInfoExecutor().Client(this).Execute<GetMonitorAlarmInfoResponse, GetMonitorAlarmInfoResult, GetMonitorAlarmInfoRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  添加子域名的某些特定监控对象为监控项
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AddMonitorTargetResponse AddMonitorTarget(AddMonitorTargetRequest request) {
            return  new AddMonitorTargetExecutor().Client(this).Execute<AddMonitorTargetResponse, AddMonitorTargetResult, AddMonitorTargetRequest>(request);
        }
#else
        /// <summary>
        ///  添加子域名的某些特定监控对象为监控项
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AddMonitorTargetResponse> AddMonitorTarget(AddMonitorTargetRequest request) {
            return await new AddMonitorTargetExecutor().Client(this).Execute<AddMonitorTargetResponse, AddMonitorTargetResult, AddMonitorTargetRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  添加主域名
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AddDomainResponse AddDomain(AddDomainRequest request) {
            return  new AddDomainExecutor().Client(this).Execute<AddDomainResponse, AddDomainResult, AddDomainRequest>(request);
        }
#else
        /// <summary>
        ///  添加主域名
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AddDomainResponse> AddDomain(AddDomainRequest request) {
            return await new AddDomainExecutor().Client(this).Execute<AddDomainResponse, AddDomainResult, AddDomainRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询域名的自定义解析线路的IP段
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetUserViewIPResponse GetUserViewIP(GetUserViewIPRequest request) {
            return  new GetUserViewIPExecutor().Client(this).Execute<GetUserViewIPResponse, GetUserViewIPResult, GetUserViewIPRequest>(request);
        }
#else
        /// <summary>
        ///  查询域名的自定义解析线路的IP段
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetUserViewIPResponse> GetUserViewIP(GetUserViewIPRequest request) {
            return await new GetUserViewIPExecutor().Client(this).Execute<GetUserViewIPResponse, GetUserViewIPResult, GetUserViewIPRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  添加域名的自定义解析线路
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AddUserViewResponse AddUserView(AddUserViewRequest request) {
            return  new AddUserViewExecutor().Client(this).Execute<AddUserViewResponse, AddUserViewResult, AddUserViewRequest>(request);
        }
#else
        /// <summary>
        ///  添加域名的自定义解析线路
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AddUserViewResponse> AddUserView(AddUserViewRequest request) {
            return await new AddUserViewExecutor().Client(this).Execute<AddUserViewResponse, AddUserViewResult, AddUserViewRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查看域名的查询流量
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetDomainQueryTrafficResponse GetDomainQueryTraffic(GetDomainQueryTrafficRequest request) {
            return  new GetDomainQueryTrafficExecutor().Client(this).Execute<GetDomainQueryTrafficResponse, GetDomainQueryTrafficResult, GetDomainQueryTrafficRequest>(request);
        }
#else
        /// <summary>
        ///  查看域名的查询流量
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetDomainQueryTrafficResponse> GetDomainQueryTraffic(GetDomainQueryTrafficRequest request) {
            return await new GetDomainQueryTrafficExecutor().Client(this).Execute<GetDomainQueryTrafficResponse, GetDomainQueryTrafficResult, GetDomainQueryTrafficRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询子域名的可用监控对象
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetTargetsResponse GetTargets(GetTargetsRequest request) {
            return  new GetTargetsExecutor().Client(this).Execute<GetTargetsResponse, GetTargetsResult, GetTargetsRequest>(request);
        }
#else
        /// <summary>
        ///  查询子域名的可用监控对象
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetTargetsResponse> GetTargets(GetTargetsRequest request) {
            return await new GetTargetsExecutor().Client(this).Execute<GetTargetsResponse, GetTargetsResult, GetTargetsRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询域名的自定义解析线路
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetUserViewResponse GetUserView(GetUserViewRequest request) {
            return  new GetUserViewExecutor().Client(this).Execute<GetUserViewResponse, GetUserViewResult, GetUserViewRequest>(request);
        }
#else
        /// <summary>
        ///  查询域名的自定义解析线路
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetUserViewResponse> GetUserView(GetUserViewRequest request) {
            return await new GetUserViewExecutor().Client(this).Execute<GetUserViewResponse, GetUserViewResult, GetUserViewRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  添加域名的自定义解析线路的IP段
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AddUserViewIPResponse AddUserViewIP(AddUserViewIPRequest request) {
            return  new AddUserViewIPExecutor().Client(this).Execute<AddUserViewIPResponse, AddUserViewIPResult, AddUserViewIPRequest>(request);
        }
#else
        /// <summary>
        ///  添加域名的自定义解析线路的IP段
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AddUserViewIPResponse> AddUserViewIP(AddUserViewIPRequest request) {
            return await new AddUserViewIPExecutor().Client(this).Execute<AddUserViewIPResponse, AddUserViewIPResult, AddUserViewIPRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查看域名的解析次数
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetDomainQueryCountResponse GetDomainQueryCount(GetDomainQueryCountRequest request) {
            return  new GetDomainQueryCountExecutor().Client(this).Execute<GetDomainQueryCountResponse, GetDomainQueryCountResult, GetDomainQueryCountRequest>(request);
        }
#else
        /// <summary>
        ///  查看域名的解析次数
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetDomainQueryCountResponse> GetDomainQueryCount(GetDomainQueryCountRequest request) {
            return await new GetDomainQueryCountExecutor().Client(this).Execute<GetDomainQueryCountResponse, GetDomainQueryCountResult, GetDomainQueryCountRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除域名的自定义解析线路
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DelUserViewResponse DelUserView(DelUserViewRequest request) {
            return  new DelUserViewExecutor().Client(this).Execute<DelUserViewResponse, DelUserViewResult, DelUserViewRequest>(request);
        }
#else
        /// <summary>
        ///  删除域名的自定义解析线路
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DelUserViewResponse> DelUserView(DelUserViewRequest request) {
            return await new DelUserViewExecutor().Client(this).Execute<DelUserViewResponse, DelUserViewResult, DelUserViewRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  添加子域名的监控项，默认把子域名的所有监控项都添加上监控
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AddMonitorResponse AddMonitor(AddMonitorRequest request) {
            return  new AddMonitorExecutor().Client(this).Execute<AddMonitorResponse, AddMonitorResult, AddMonitorRequest>(request);
        }
#else
        /// <summary>
        ///  添加子域名的监控项，默认把子域名的所有监控项都添加上监控
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AddMonitorResponse> AddMonitor(AddMonitorRequest request) {
            return await new AddMonitorExecutor().Client(this).Execute<AddMonitorResponse, AddMonitorResult, AddMonitorRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询云解析所有的基础解析线路。&lt;br&gt;
        /// 在使用解析线路的参数之前，请调用此接口获取解析线路的ID。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetViewTreeResponse GetViewTree(GetViewTreeRequest request) {
            return  new GetViewTreeExecutor().Client(this).Execute<GetViewTreeResponse, GetViewTreeResult, GetViewTreeRequest>(request);
        }
#else
        /// <summary>
        ///  查询云解析所有的基础解析线路。&lt;br&gt;
        /// 在使用解析线路的参数之前，请调用此接口获取解析线路的ID。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetViewTreeResponse> GetViewTree(GetViewTreeRequest request) {
            return await new GetViewTreeExecutor().Client(this).Execute<GetViewTreeResponse, GetViewTreeResult, GetViewTreeRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改主域名的某个解析记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public UpdateRRResponse UpdateRR(UpdateRRRequest request) {
            return  new UpdateRRExecutor().Client(this).Execute<UpdateRRResponse, UpdateRRResult, UpdateRRRequest>(request);
        }
#else
        /// <summary>
        ///  修改主域名的某个解析记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<UpdateRRResponse> UpdateRR(UpdateRRRequest request) {
            return await new UpdateRRExecutor().Client(this).Execute<UpdateRRResponse, UpdateRRResult, UpdateRRRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查看主域名的监控项的配置以及状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetMonitorResponse GetMonitor(GetMonitorRequest request) {
            return  new GetMonitorExecutor().Client(this).Execute<GetMonitorResponse, GetMonitorResult, GetMonitorRequest>(request);
        }
#else
        /// <summary>
        ///  查看主域名的监控项的配置以及状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetMonitorResponse> GetMonitor(GetMonitorRequest request) {
            return await new GetMonitorExecutor().Client(this).Execute<GetMonitorResponse, GetMonitorResult, GetMonitorRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  监控项的操作集合，包括：删除，暂停，启动, 手动恢复, 手动切换
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public OperateMonitorResponse OperateMonitor(OperateMonitorRequest request) {
            return  new OperateMonitorExecutor().Client(this).Execute<OperateMonitorResponse, OperateMonitorResult, OperateMonitorRequest>(request);
        }
#else
        /// <summary>
        ///  监控项的操作集合，包括：删除，暂停，启动, 手动恢复, 手动切换
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<OperateMonitorResponse> OperateMonitor(OperateMonitorRequest request) {
            return await new OperateMonitorExecutor().Client(this).Execute<OperateMonitorResponse, OperateMonitorResult, OperateMonitorRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改主域名
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public UpdateDomainResponse UpdateDomain(UpdateDomainRequest request) {
            return  new UpdateDomainExecutor().Client(this).Execute<UpdateDomainResponse, UpdateDomainResult, UpdateDomainRequest>(request);
        }
#else
        /// <summary>
        ///  修改主域名
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<UpdateDomainResponse> UpdateDomain(UpdateDomainRequest request) {
            return await new UpdateDomainExecutor().Client(this).Execute<UpdateDomainResponse, UpdateDomainResult, UpdateDomainRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询主域名的解析记录。&lt;br&gt;
        /// 在使用解析记录相关的接口之前，请调用此接口获取解析记录的列表。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public SearchRRResponse SearchRR(SearchRRRequest request) {
            return  new SearchRRExecutor().Client(this).Execute<SearchRRResponse, SearchRRResult, SearchRRRequest>(request);
        }
#else
        /// <summary>
        ///  查询主域名的解析记录。&lt;br&gt;
        /// 在使用解析记录相关的接口之前，请调用此接口获取解析记录的列表。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<SearchRRResponse> SearchRR(SearchRRRequest request) {
            return await new SearchRRExecutor().Client(this).Execute<SearchRRResponse, SearchRRResult, SearchRRRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  启用、停用、删除主域名下的解析记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public OperateRRResponse OperateRR(OperateRRRequest request) {
            return  new OperateRRExecutor().Client(this).Execute<OperateRRResponse, OperateRRResult, OperateRRRequest>(request);
        }
#else
        /// <summary>
        ///  启用、停用、删除主域名下的解析记录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<OperateRRResponse> OperateRR(OperateRRRequest request) {
            return await new OperateRRExecutor().Client(this).Execute<OperateRRResponse, OperateRRResult, OperateRRRequest>(request);
        }
#endif

            /// <summary>
            ///  默认ClouddnsserviceClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>clouddnsserviceClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>clouddnsserviceClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>clouddnsserviceClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造ClouddnsserviceClient 对象
                ///</summary>
                ClouddnsserviceClient Build();
            }

            /// <summary>
            ///  默认ClouddnsserviceClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  ClouddnsserviceClient service client
                /// </summary>
                private  ClouddnsserviceClient clouddnsserviceClient;

                /// <summary>
                ///  默认ClouddnsserviceClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    clouddnsserviceClient = new ClouddnsserviceClient();
                }

                /// <summary>
                ///  构造ClouddnsserviceClient 对象
                ///</summary>
                public ClouddnsserviceClient Build()
                {
                    if (clouddnsserviceClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        clouddnsserviceClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (clouddnsserviceClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("ClouddnsserviceClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (clouddnsserviceClient.HttpRequestConfig == null)
                    {
                        clouddnsserviceClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (clouddnsserviceClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("ClouddnsserviceClient build error: http request config not set");
                        }
                    }
                    return clouddnsserviceClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>clouddnsserviceClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    clouddnsserviceClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>clouddnsserviceClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    clouddnsserviceClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>clouddnsserviceClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    clouddnsserviceClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
