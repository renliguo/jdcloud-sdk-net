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
 * 设备生命周期管理
 * 用于完成设备全生命周期管理
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Iothub.Client
{

    /// <summary>
    ///  激活一个设备，包括Edge、Dragon和普通设备
        /// 
    /// </summary>
    public class DeviceActivateExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  激活一个设备，包括Edge、Dragon和普通设备
        /// 接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "GET";
            }
        }
        /// <summary>
        ///  激活一个设备，包括Edge、Dragon和普通设备
        /// 接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/device/{deviceId}/activate";
            }
        }
    }
}
