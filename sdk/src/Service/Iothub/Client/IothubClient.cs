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
 * JCLOUD IoT Hub API
 * API related to IoT Hub
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Iothub.Apis;
using JDCloudSDK.Iothub.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Iothub.Client
{
    /// <summary>
    ///  JCLOUD IoT Hub API
    ///  API related to IoT Hub
    ///  Iothub Api 客户端
    ///</summary>
    public class IothubClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private IothubClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public IothubClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public IothubClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public IothubClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.0.7
        ///</summary>
        public const string ClientVersion = "1.0.7";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "iothub.jdcloud-api.com";
        private const string serviceName = "iothub";
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
        ///  客户用该接口可以登记模块
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModuleEnrollResponse ModuleEnroll(ModuleEnrollRequest request) {
            return  new ModuleEnrollExecutor().Client(this).Execute<ModuleEnrollResponse, ModuleEnrollResult, ModuleEnrollRequest>(request);
        }
#else
        /// <summary>
        ///  客户用该接口可以登记模块
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModuleEnrollResponse> ModuleEnroll(ModuleEnrollRequest request) {
            return await new ModuleEnrollExecutor().Client(this).Execute<ModuleEnrollResponse, ModuleEnrollResult, ModuleEnrollRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  客户用该接口可以修改模块预期状态
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModuleStateResponse ModuleState(ModuleStateRequest request) {
            return  new ModuleStateExecutor().Client(this).Execute<ModuleStateResponse, ModuleStateResult, ModuleStateRequest>(request);
        }
#else
        /// <summary>
        ///  客户用该接口可以修改模块预期状态
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModuleStateResponse> ModuleState(ModuleStateRequest request) {
            return await new ModuleStateExecutor().Client(this).Execute<ModuleStateResponse, ModuleStateResult, ModuleStateRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  客户用该接口可以批量登记设备
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DevicesEnrollResponse DevicesEnroll(DevicesEnrollRequest request) {
            return  new DevicesEnrollExecutor().Client(this).Execute<DevicesEnrollResponse, DevicesEnrollResult, DevicesEnrollRequest>(request);
        }
#else
        /// <summary>
        ///  客户用该接口可以批量登记设备
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DevicesEnrollResponse> DevicesEnroll(DevicesEnrollRequest request) {
            return await new DevicesEnrollExecutor().Client(this).Execute<DevicesEnrollResponse, DevicesEnrollResult, DevicesEnrollRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  客户用该接口可以修改设备预期状态
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeviceStateResponse DeviceState(DeviceStateRequest request) {
            return  new DeviceStateExecutor().Client(this).Execute<DeviceStateResponse, DeviceStateResult, DeviceStateRequest>(request);
        }
#else
        /// <summary>
        ///  客户用该接口可以修改设备预期状态
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeviceStateResponse> DeviceState(DeviceStateRequest request) {
            return await new DeviceStateExecutor().Client(this).Execute<DeviceStateResponse, DeviceStateResult, DeviceStateRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  客户用该接口可以对设备下发命令
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeviceCommandResponse DeviceCommand(DeviceCommandRequest request) {
            return  new DeviceCommandExecutor().Client(this).Execute<DeviceCommandResponse, DeviceCommandResult, DeviceCommandRequest>(request);
        }
#else
        /// <summary>
        ///  客户用该接口可以对设备下发命令
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeviceCommandResponse> DeviceCommand(DeviceCommandRequest request) {
            return await new DeviceCommandExecutor().Client(this).Execute<DeviceCommandResponse, DeviceCommandResult, DeviceCommandRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  激活一个设备，包括Edge、Dragon和普通设备
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeviceActivateResponse DeviceActivate(DeviceActivateRequest request) {
            return  new DeviceActivateExecutor().Client(this).Execute<DeviceActivateResponse, DeviceActivateResult, DeviceActivateRequest>(request);
        }
#else
        /// <summary>
        ///  激活一个设备，包括Edge、Dragon和普通设备
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeviceActivateResponse> DeviceActivate(DeviceActivateRequest request) {
            return await new DeviceActivateExecutor().Client(this).Execute<DeviceActivateResponse, DeviceActivateResult, DeviceActivateRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  物模型注册接口
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public OmEnrollResponse OmEnroll(OmEnrollRequest request) {
            return  new OmEnrollExecutor().Client(this).Execute<OmEnrollResponse, OmEnrollResult, OmEnrollRequest>(request);
        }
#else
        /// <summary>
        ///  物模型注册接口
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<OmEnrollResponse> OmEnroll(OmEnrollRequest request) {
            return await new OmEnrollExecutor().Client(this).Execute<OmEnrollResponse, OmEnrollResult, OmEnrollRequest>(request);
        }
#endif

            /// <summary>
            ///  默认IothubClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>iothubClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>iothubClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>iothubClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造IothubClient 对象
                ///</summary>
                IothubClient Build();
            }

            /// <summary>
            ///  默认IothubClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  IothubClient service client
                /// </summary>
                private  IothubClient iothubClient;

                /// <summary>
                ///  默认IothubClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    iothubClient = new IothubClient();
                }

                /// <summary>
                ///  构造IothubClient 对象
                ///</summary>
                public IothubClient Build()
                {
                    if (iothubClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        iothubClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (iothubClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("IothubClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (iothubClient.HttpRequestConfig == null)
                    {
                        iothubClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (iothubClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("IothubClient build error: http request config not set");
                        }
                    }
                    return iothubClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>iothubClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    iothubClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>iothubClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    iothubClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>iothubClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    iothubClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
