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
 * EdgeSubDeviceManager
 * iotcore-Edge子设备管理
 *
 * OpenAPI spec version: v2
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Iotedge.Model;

namespace  JDCloudSDK.Iotedge.Apis
{

    /// <summary>
    ///  查询配置信息
    /// </summary>
    public class DescribeSubDeviceConfigWithCoreResult : JdcloudResult
    {
        ///<summary>
        /// 设备对应的identifier
        ///</summary>
        public   string Identifier{ get; set; }
        ///<summary>
        /// 配置唯一标识
        ///</summary>
        public   string ConfId{ get; set; }
        ///<summary>
        /// 设备对应的secret
        ///</summary>
        public   string Secret{ get; set; }
        ///<summary>
        /// 设备对应的设备服务名称
        ///</summary>
        public   string DeviceServiceName{ get; set; }
        ///<summary>
        /// 配置下发服务预期messageId
        ///</summary>
        public   string ExpectMsgId{ get; set; }
        ///<summary>
        /// 配置下发服务当前messageId
        ///</summary>
        public   string TargetMsgId{ get; set; }
        ///<summary>
        /// 设备服务协议列表
        ///</summary>
        public List<Protocols> Protocols{ get; set; }

    }
}