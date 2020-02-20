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
 * 京东云电子签章-OpenAPI接口
 * 京东云电子签章-OpenAPI接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Cloudsign.Apis;
using JDCloudSDK.Cloudsign.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Cloudsign.Client
{
    /// <summary>
    ///  京东云电子签章-OpenAPI接口
    ///  京东云电子签章-OpenAPI接口
    ///  Cloudsign Api 客户端
    ///</summary>
    public class CloudsignClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private CloudsignClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public CloudsignClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public CloudsignClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public CloudsignClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.2.0
        ///</summary>
        public const string ClientVersion = "1.2.0";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "cloudsign.jdcloud-api.com";
        private const string serviceName = "cloudsign";
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
        ///  查询服务开通状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeApplyStatusResponse DescribeApplyStatus(DescribeApplyStatusRequest request) {
            return  new DescribeApplyStatusExecutor().Client(this).Execute<DescribeApplyStatusResponse, DescribeApplyStatusResult, DescribeApplyStatusRequest>(request);
        }
#else
        /// <summary>
        ///  查询服务开通状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeApplyStatusResponse> DescribeApplyStatus(DescribeApplyStatusRequest request) {
            return await new DescribeApplyStatusExecutor().Client(this).Execute<DescribeApplyStatusResponse, DescribeApplyStatusResult, DescribeApplyStatusRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  启用合同存管
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public EnableContractSaveResponse EnableContractSave(EnableContractSaveRequest request) {
            return  new EnableContractSaveExecutor().Client(this).Execute<EnableContractSaveResponse, EnableContractSaveResult, EnableContractSaveRequest>(request);
        }
#else
        /// <summary>
        ///  启用合同存管
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<EnableContractSaveResponse> EnableContractSave(EnableContractSaveRequest request) {
            return await new EnableContractSaveExecutor().Client(this).Execute<EnableContractSaveResponse, EnableContractSaveResult, EnableContractSaveRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取合同模板列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeTemplateListResponse DescribeTemplateList(DescribeTemplateListRequest request) {
            return  new DescribeTemplateListExecutor().Client(this).Execute<DescribeTemplateListResponse, DescribeTemplateListResult, DescribeTemplateListRequest>(request);
        }
#else
        /// <summary>
        ///  获取合同模板列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeTemplateListResponse> DescribeTemplateList(DescribeTemplateListRequest request) {
            return await new DescribeTemplateListExecutor().Client(this).Execute<DescribeTemplateListResponse, DescribeTemplateListResult, DescribeTemplateListRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取已签章合同列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeContractListResponse DescribeContractList(DescribeContractListRequest request) {
            return  new DescribeContractListExecutor().Client(this).Execute<DescribeContractListResponse, DescribeContractListResult, DescribeContractListRequest>(request);
        }
#else
        /// <summary>
        ///  获取已签章合同列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeContractListResponse> DescribeContractList(DescribeContractListRequest request) {
            return await new DescribeContractListExecutor().Client(this).Execute<DescribeContractListResponse, DescribeContractListResult, DescribeContractListRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  上传印章
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public UploadStampResponse UploadStamp(UploadStampRequest request) {
            return  new UploadStampExecutor().Client(this).Execute<UploadStampResponse, UploadStampResult, UploadStampRequest>(request);
        }
#else
        /// <summary>
        ///  上传印章
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<UploadStampResponse> UploadStamp(UploadStampRequest request) {
            return await new UploadStampExecutor().Client(this).Execute<UploadStampResponse, UploadStampResult, UploadStampRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  1. 下载印章
        /// 2. 多个印章id用逗号分隔
        ///  [MFA enabled]
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DownloadStampsResponse DownloadStamps(DownloadStampsRequest request) {
            return  new DownloadStampsExecutor().Client(this).Execute<DownloadStampsResponse, DownloadStampsResult, DownloadStampsRequest>(request);
        }
#else
        /// <summary>
        ///  1. 下载印章
        /// 2. 多个印章id用逗号分隔
        ///  [MFA enabled]
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DownloadStampsResponse> DownloadStamps(DownloadStampsRequest request) {
            return await new DownloadStampsExecutor().Client(this).Execute<DownloadStampsResponse, DownloadStampsResult, DownloadStampsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取电子签章的数据统计信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetStatisticsResponse GetStatistics(GetStatisticsRequest request) {
            return  new GetStatisticsExecutor().Client(this).Execute<GetStatisticsResponse, GetStatisticsResult, GetStatisticsRequest>(request);
        }
#else
        /// <summary>
        ///  获取电子签章的数据统计信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetStatisticsResponse> GetStatistics(GetStatisticsRequest request) {
            return await new GetStatisticsExecutor().Client(this).Execute<GetStatisticsResponse, GetStatisticsResult, GetStatisticsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  合同签章四种方式：
        /// 1. 合同文件 + 印章文件：contractContent + stampContent
        /// 2. 合同文件 + 印章ID：contractContent + stampId
        /// 3. 模板ID + 印章文件：templateId + stampContent
        /// 4. 模板ID + 印章ID：templateId + stampId
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public SignContractResponse SignContract(SignContractRequest request) {
            return  new SignContractExecutor().Client(this).Execute<SignContractResponse, SignContractResult, SignContractRequest>(request);
        }
#else
        /// <summary>
        ///  合同签章四种方式：
        /// 1. 合同文件 + 印章文件：contractContent + stampContent
        /// 2. 合同文件 + 印章ID：contractContent + stampId
        /// 3. 模板ID + 印章文件：templateId + stampContent
        /// 4. 模板ID + 印章ID：templateId + stampId
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<SignContractResponse> SignContract(SignContractRequest request) {
            return await new SignContractExecutor().Client(this).Execute<SignContractResponse, SignContractResult, SignContractRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  1. 下载已签章的合同
        /// 2. 多个合同id用逗号分隔
        ///  [MFA enabled]
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DownloadContractsResponse DownloadContracts(DownloadContractsRequest request) {
            return  new DownloadContractsExecutor().Client(this).Execute<DownloadContractsResponse, DownloadContractsResult, DownloadContractsRequest>(request);
        }
#else
        /// <summary>
        ///  1. 下载已签章的合同
        /// 2. 多个合同id用逗号分隔
        ///  [MFA enabled]
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DownloadContractsResponse> DownloadContracts(DownloadContractsRequest request) {
            return await new DownloadContractsExecutor().Client(this).Execute<DownloadContractsResponse, DownloadContractsResult, DownloadContractsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  1. 下载合同模板
        /// 2. 多个合同id用逗号分隔
        ///  [MFA enabled]
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DownloadTemplatesResponse DownloadTemplates(DownloadTemplatesRequest request) {
            return  new DownloadTemplatesExecutor().Client(this).Execute<DownloadTemplatesResponse, DownloadTemplatesResult, DownloadTemplatesRequest>(request);
        }
#else
        /// <summary>
        ///  1. 下载合同模板
        /// 2. 多个合同id用逗号分隔
        ///  [MFA enabled]
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DownloadTemplatesResponse> DownloadTemplates(DownloadTemplatesRequest request) {
            return await new DownloadTemplatesExecutor().Client(this).Execute<DownloadTemplatesResponse, DownloadTemplatesResult, DownloadTemplatesRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  验签已签章合同
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public VerifyContractResponse VerifyContract(VerifyContractRequest request) {
            return  new VerifyContractExecutor().Client(this).Execute<VerifyContractResponse, VerifyContractResult, VerifyContractRequest>(request);
        }
#else
        /// <summary>
        ///  验签已签章合同
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<VerifyContractResponse> VerifyContract(VerifyContractRequest request) {
            return await new VerifyContractExecutor().Client(this).Execute<VerifyContractResponse, VerifyContractResult, VerifyContractRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  申请开通电子签章服务（cloudsign）
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ApplyServiceResponse ApplyService(ApplyServiceRequest request) {
            return  new ApplyServiceExecutor().Client(this).Execute<ApplyServiceResponse, ApplyServiceResult, ApplyServiceRequest>(request);
        }
#else
        /// <summary>
        ///  申请开通电子签章服务（cloudsign）
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ApplyServiceResponse> ApplyService(ApplyServiceRequest request) {
            return await new ApplyServiceExecutor().Client(this).Execute<ApplyServiceResponse, ApplyServiceResult, ApplyServiceRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  上传合同模板
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public UploadTemplateResponse UploadTemplate(UploadTemplateRequest request) {
            return  new UploadTemplateExecutor().Client(this).Execute<UploadTemplateResponse, UploadTemplateResult, UploadTemplateRequest>(request);
        }
#else
        /// <summary>
        ///  上传合同模板
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<UploadTemplateResponse> UploadTemplate(UploadTemplateRequest request) {
            return await new UploadTemplateExecutor().Client(this).Execute<UploadTemplateResponse, UploadTemplateResult, UploadTemplateRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除合同模板 [MFA enabled]
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request) {
            return  new DeleteTemplateExecutor().Client(this).Execute<DeleteTemplateResponse, DeleteTemplateResult, DeleteTemplateRequest>(request);
        }
#else
        /// <summary>
        ///  删除合同模板 [MFA enabled]
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteTemplateResponse> DeleteTemplate(DeleteTemplateRequest request) {
            return await new DeleteTemplateExecutor().Client(this).Execute<DeleteTemplateResponse, DeleteTemplateResult, DeleteTemplateRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除已签章的合同 [MFA enabled]
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteContractResponse DeleteContract(DeleteContractRequest request) {
            return  new DeleteContractExecutor().Client(this).Execute<DeleteContractResponse, DeleteContractResult, DeleteContractRequest>(request);
        }
#else
        /// <summary>
        ///  删除已签章的合同 [MFA enabled]
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteContractResponse> DeleteContract(DeleteContractRequest request) {
            return await new DeleteContractExecutor().Client(this).Execute<DeleteContractResponse, DeleteContractResult, DeleteContractRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  禁用合同存管
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DisableContractSaveResponse DisableContractSave(DisableContractSaveRequest request) {
            return  new DisableContractSaveExecutor().Client(this).Execute<DisableContractSaveResponse, DisableContractSaveResult, DisableContractSaveRequest>(request);
        }
#else
        /// <summary>
        ///  禁用合同存管
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DisableContractSaveResponse> DisableContractSave(DisableContractSaveRequest request) {
            return await new DisableContractSaveExecutor().Client(this).Execute<DisableContractSaveResponse, DisableContractSaveResult, DisableContractSaveRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  签章系统加密密钥 [MFA enabled]
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public SetKmsKeyIdResponse SetKmsKeyId(SetKmsKeyIdRequest request) {
            return  new SetKmsKeyIdExecutor().Client(this).Execute<SetKmsKeyIdResponse, SetKmsKeyIdResult, SetKmsKeyIdRequest>(request);
        }
#else
        /// <summary>
        ///  签章系统加密密钥 [MFA enabled]
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<SetKmsKeyIdResponse> SetKmsKeyId(SetKmsKeyIdRequest request) {
            return await new SetKmsKeyIdExecutor().Client(this).Execute<SetKmsKeyIdResponse, SetKmsKeyIdResult, SetKmsKeyIdRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除印章 [MFA enabled]
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteStampResponse DeleteStamp(DeleteStampRequest request) {
            return  new DeleteStampExecutor().Client(this).Execute<DeleteStampResponse, DeleteStampResult, DeleteStampRequest>(request);
        }
#else
        /// <summary>
        ///  删除印章 [MFA enabled]
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteStampResponse> DeleteStamp(DeleteStampRequest request) {
            return await new DeleteStampExecutor().Client(this).Execute<DeleteStampResponse, DeleteStampResult, DeleteStampRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取印章列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeStampListResponse DescribeStampList(DescribeStampListRequest request) {
            return  new DescribeStampListExecutor().Client(this).Execute<DescribeStampListResponse, DescribeStampListResult, DescribeStampListRequest>(request);
        }
#else
        /// <summary>
        ///  获取印章列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeStampListResponse> DescribeStampList(DescribeStampListRequest request) {
            return await new DescribeStampListExecutor().Client(this).Execute<DescribeStampListResponse, DescribeStampListResult, DescribeStampListRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认CloudsignClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>cloudsignClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>cloudsignClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>cloudsignClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造CloudsignClient 对象
                ///</summary>
                CloudsignClient Build();
            }

            /// <summary>
            ///  默认CloudsignClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  CloudsignClient service client
                /// </summary>
                private  CloudsignClient cloudsignClient;

                /// <summary>
                ///  默认CloudsignClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    cloudsignClient = new CloudsignClient();
                }

                /// <summary>
                ///  构造CloudsignClient 对象
                ///</summary>
                public CloudsignClient Build()
                {
                    if (cloudsignClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        cloudsignClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (cloudsignClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("CloudsignClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (cloudsignClient.HttpRequestConfig == null)
                    {
                        cloudsignClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (cloudsignClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("CloudsignClient build error: http request config not set");
                        }
                    }
                    return cloudsignClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>cloudsignClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    cloudsignClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>cloudsignClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    cloudsignClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>cloudsignClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    cloudsignClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
