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
 * 京东云sms接口
 * sms相关接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Sms.Apis;
using JDCloudSDK.Sms.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Sms.Client
{
    /// <summary>
    ///  京东云sms接口
    ///  sms相关接口
    ///  Sms Api 客户端
    ///</summary>
    public class SmsClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private SmsClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public SmsClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public SmsClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public SmsClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.0.9
        ///</summary>
        public const string ClientVersion = "1.0.9";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "sms.jdcloud-api.com";
        private const string serviceName = "sms";
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
        ///  拉取回复短信
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public PullMoMsgResponse PullMoMsg(PullMoMsgRequest request) {
            return  new PullMoMsgExecutor().Client(this).Execute<PullMoMsgResponse, PullMoMsgResult, PullMoMsgRequest>(request);
        }
#else
        /// <summary>
        ///  拉取回复短信
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<PullMoMsgResponse> PullMoMsg(PullMoMsgRequest request) {
            return await new PullMoMsgExecutor().Client(this).Execute<PullMoMsgResponse, PullMoMsgResult, PullMoMsgRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除短信签名接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteSdkSmsSignResponse DeleteSdkSmsSign(DeleteSdkSmsSignRequest request) {
            return  new DeleteSdkSmsSignExecutor().Client(this).Execute<DeleteSdkSmsSignResponse, DeleteSdkSmsSignResult, DeleteSdkSmsSignRequest>(request);
        }
#else
        /// <summary>
        ///  删除短信签名接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteSdkSmsSignResponse> DeleteSdkSmsSign(DeleteSdkSmsSignRequest request) {
            return await new DeleteSdkSmsSignExecutor().Client(this).Execute<DeleteSdkSmsSignResponse, DeleteSdkSmsSignResult, DeleteSdkSmsSignRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  新增短信模板接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AddSdkSmsTemplateResponse AddSdkSmsTemplate(AddSdkSmsTemplateRequest request) {
            return  new AddSdkSmsTemplateExecutor().Client(this).Execute<AddSdkSmsTemplateResponse, AddSdkSmsTemplateResult, AddSdkSmsTemplateRequest>(request);
        }
#else
        /// <summary>
        ///  新增短信模板接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AddSdkSmsTemplateResponse> AddSdkSmsTemplate(AddSdkSmsTemplateRequest request) {
            return await new AddSdkSmsTemplateExecutor().Client(this).Execute<AddSdkSmsTemplateResponse, AddSdkSmsTemplateResult, AddSdkSmsTemplateRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除短信模板接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteSdkSmsTemplateResponse DeleteSdkSmsTemplate(DeleteSdkSmsTemplateRequest request) {
            return  new DeleteSdkSmsTemplateExecutor().Client(this).Execute<DeleteSdkSmsTemplateResponse, DeleteSdkSmsTemplateResult, DeleteSdkSmsTemplateRequest>(request);
        }
#else
        /// <summary>
        ///  删除短信模板接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteSdkSmsTemplateResponse> DeleteSdkSmsTemplate(DeleteSdkSmsTemplateRequest request) {
            return await new DeleteSdkSmsTemplateExecutor().Client(this).Execute<DeleteSdkSmsTemplateResponse, DeleteSdkSmsTemplateResult, DeleteSdkSmsTemplateRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  拉取短信状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public PullMtMsgResponse PullMtMsg(PullMtMsgRequest request) {
            return  new PullMtMsgExecutor().Client(this).Execute<PullMtMsgResponse, PullMtMsgResult, PullMtMsgRequest>(request);
        }
#else
        /// <summary>
        ///  拉取短信状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<PullMtMsgResponse> PullMtMsg(PullMtMsgRequest request) {
            return await new PullMtMsgExecutor().Client(this).Execute<PullMtMsgResponse, PullMtMsgResult, PullMtMsgRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询短信签名接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QuerySdkSmsSignStatusResponse QuerySdkSmsSignStatus(QuerySdkSmsSignStatusRequest request) {
            return  new QuerySdkSmsSignStatusExecutor().Client(this).Execute<QuerySdkSmsSignStatusResponse, QuerySdkSmsSignStatusResult, QuerySdkSmsSignStatusRequest>(request);
        }
#else
        /// <summary>
        ///  查询短信签名接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QuerySdkSmsSignStatusResponse> QuerySdkSmsSignStatus(QuerySdkSmsSignStatusRequest request) {
            return await new QuerySdkSmsSignStatusExecutor().Client(this).Execute<QuerySdkSmsSignStatusResponse, QuerySdkSmsSignStatusResult, QuerySdkSmsSignStatusRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  发送数据统计
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AggSendStatusResponse AggSendStatus(AggSendStatusRequest request) {
            return  new AggSendStatusExecutor().Client(this).Execute<AggSendStatusResponse, AggSendStatusResult, AggSendStatusRequest>(request);
        }
#else
        /// <summary>
        ///  发送数据统计
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AggSendStatusResponse> AggSendStatus(AggSendStatusRequest request) {
            return await new AggSendStatusExecutor().Client(this).Execute<AggSendStatusResponse, AggSendStatusResult, AggSendStatusRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  指定模板单发短信
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public SendSingleSmsResponse SendSingleSms(SendSingleSmsRequest request) {
            return  new SendSingleSmsExecutor().Client(this).Execute<SendSingleSmsResponse, SendSingleSmsResult, SendSingleSmsRequest>(request);
        }
#else
        /// <summary>
        ///  指定模板单发短信
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<SendSingleSmsResponse> SendSingleSms(SendSingleSmsRequest request) {
            return await new SendSingleSmsExecutor().Client(this).Execute<SendSingleSmsResponse, SendSingleSmsResult, SendSingleSmsRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  指定模板群发短信
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public SendBatchSmsResponse SendBatchSms(SendBatchSmsRequest request) {
            return  new SendBatchSmsExecutor().Client(this).Execute<SendBatchSmsResponse, SendBatchSmsResult, SendBatchSmsRequest>(request);
        }
#else
        /// <summary>
        ///  指定模板群发短信
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<SendBatchSmsResponse> SendBatchSms(SendBatchSmsRequest request) {
            return await new SendBatchSmsExecutor().Client(this).Execute<SendBatchSmsResponse, SendBatchSmsResult, SendBatchSmsRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询短信模板接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QuerySdkSmsTemplateStatusResponse QuerySdkSmsTemplateStatus(QuerySdkSmsTemplateStatusRequest request) {
            return  new QuerySdkSmsTemplateStatusExecutor().Client(this).Execute<QuerySdkSmsTemplateStatusResponse, QuerySdkSmsTemplateStatusResult, QuerySdkSmsTemplateStatusRequest>(request);
        }
#else
        /// <summary>
        ///  查询短信模板接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QuerySdkSmsTemplateStatusResponse> QuerySdkSmsTemplateStatus(QuerySdkSmsTemplateStatusRequest request) {
            return await new QuerySdkSmsTemplateStatusExecutor().Client(this).Execute<QuerySdkSmsTemplateStatusResponse, QuerySdkSmsTemplateStatusResult, QuerySdkSmsTemplateStatusRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  回执数据统计
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AggReceiptStatusResponse AggReceiptStatus(AggReceiptStatusRequest request) {
            return  new AggReceiptStatusExecutor().Client(this).Execute<AggReceiptStatusResponse, AggReceiptStatusResult, AggReceiptStatusRequest>(request);
        }
#else
        /// <summary>
        ///  回执数据统计
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AggReceiptStatusResponse> AggReceiptStatus(AggReceiptStatusRequest request) {
            return await new AggReceiptStatusExecutor().Client(this).Execute<AggReceiptStatusResponse, AggReceiptStatusResult, AggReceiptStatusRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  拉取单个手机的回复短信
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public PullMoMsgByMobileResponse PullMoMsgByMobile(PullMoMsgByMobileRequest request) {
            return  new PullMoMsgByMobileExecutor().Client(this).Execute<PullMoMsgByMobileResponse, PullMoMsgByMobileResult, PullMoMsgByMobileRequest>(request);
        }
#else
        /// <summary>
        ///  拉取单个手机的回复短信
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<PullMoMsgByMobileResponse> PullMoMsgByMobile(PullMoMsgByMobileRequest request) {
            return await new PullMoMsgByMobileExecutor().Client(this).Execute<PullMoMsgByMobileResponse, PullMoMsgByMobileResult, PullMoMsgByMobileRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  新增短信签名接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AddSdkSmsSignResponse AddSdkSmsSign(AddSdkSmsSignRequest request) {
            return  new AddSdkSmsSignExecutor().Client(this).Execute<AddSdkSmsSignResponse, AddSdkSmsSignResult, AddSdkSmsSignRequest>(request);
        }
#else
        /// <summary>
        ///  新增短信签名接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AddSdkSmsSignResponse> AddSdkSmsSign(AddSdkSmsSignRequest request) {
            return await new AddSdkSmsSignExecutor().Client(this).Execute<AddSdkSmsSignResponse, AddSdkSmsSignResult, AddSdkSmsSignRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  拉取单个手机短信状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public PullMtMsgByMobileResponse PullMtMsgByMobile(PullMtMsgByMobileRequest request) {
            return  new PullMtMsgByMobileExecutor().Client(this).Execute<PullMtMsgByMobileResponse, PullMtMsgByMobileResult, PullMtMsgByMobileRequest>(request);
        }
#else
        /// <summary>
        ///  拉取单个手机短信状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<PullMtMsgByMobileResponse> PullMtMsgByMobile(PullMtMsgByMobileRequest request) {
            return await new PullMtMsgByMobileExecutor().Client(this).Execute<PullMtMsgByMobileResponse, PullMtMsgByMobileResult, PullMtMsgByMobileRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  编辑短信模板接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public EditSdkSmsTemplateResponse EditSdkSmsTemplate(EditSdkSmsTemplateRequest request) {
            return  new EditSdkSmsTemplateExecutor().Client(this).Execute<EditSdkSmsTemplateResponse, EditSdkSmsTemplateResult, EditSdkSmsTemplateRequest>(request);
        }
#else
        /// <summary>
        ///  编辑短信模板接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<EditSdkSmsTemplateResponse> EditSdkSmsTemplate(EditSdkSmsTemplateRequest request) {
            return await new EditSdkSmsTemplateExecutor().Client(this).Execute<EditSdkSmsTemplateResponse, EditSdkSmsTemplateResult, EditSdkSmsTemplateRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  编辑短信签名接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public EditSdkSmsSignResponse EditSdkSmsSign(EditSdkSmsSignRequest request) {
            return  new EditSdkSmsSignExecutor().Client(this).Execute<EditSdkSmsSignResponse, EditSdkSmsSignResult, EditSdkSmsSignRequest>(request);
        }
#else
        /// <summary>
        ///  编辑短信签名接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<EditSdkSmsSignResponse> EditSdkSmsSign(EditSdkSmsSignRequest request) {
            return await new EditSdkSmsSignExecutor().Client(this).Execute<EditSdkSmsSignResponse, EditSdkSmsSignResult, EditSdkSmsSignRequest>(request);
        }
#endif

            /// <summary>
            ///  默认SmsClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>smsClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>smsClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>smsClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造SmsClient 对象
                ///</summary>
                SmsClient Build();
            }

            /// <summary>
            ///  默认SmsClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  SmsClient service client
                /// </summary>
                private  SmsClient smsClient;

                /// <summary>
                ///  默认SmsClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    smsClient = new SmsClient();
                }

                /// <summary>
                ///  构造SmsClient 对象
                ///</summary>
                public SmsClient Build()
                {
                    if (smsClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        smsClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (smsClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("SmsClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (smsClient.HttpRequestConfig == null)
                    {
                        smsClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (smsClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("SmsClient build error: http request config not set");
                        }
                    }
                    return smsClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>smsClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    smsClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>smsClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    smsClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>smsClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    smsClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
