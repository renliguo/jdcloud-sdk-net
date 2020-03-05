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
 * EdgeAppManager
 * 边缘应用管理和部署
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

using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Iotedge.Apis
{

    /// <summary>
    ///  一个实例下的一个在线应用信息，设备服务具有proplist
    /// </summary>
    public class DescribeSettingsRequest : JdcloudRequest
    {
        ///<summary>
        /// 应用名字
        ///Required:true
        ///</summary>
        [Required]
        public   string AppName{ get; set; }
        ///<summary>
        /// 应用版本
        ///Required:true
        ///</summary>
        [Required]
        public   string AppVersion{ get; set; }
        ///<summary>
        /// 设备归属的实例所在区域
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 实例的ID
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
        ///<summary>
        /// 系统Id
        ///Required:true
        ///</summary>
        [Required]
        public   string OsId{ get; set; }
        ///<summary>
        /// 硬件Id
        ///Required:true
        ///</summary>
        [Required]
        public   string HardwareId{ get; set; }
    }
}