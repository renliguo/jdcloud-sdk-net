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
 * 云物理服务器
 * 云物理服务器监听器操作相关的接口
 *
 * OpenAPI spec version: v1
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

namespace  JDCloudSDK.Cps.Apis
{

    /// <summary>
    ///  修改监听器
    /// </summary>
    public class ModifyListenerRequest : JdcloudRequest
    {
        ///<summary>
        /// 调度算法
        ///</summary>
        public   string Algorithm{ get; set; }
        ///<summary>
        /// 会话保持
        ///</summary>
        public   string StickySession{ get; set; }
        ///<summary>
        /// 是否获取真实ip，取值范围on|off
        ///</summary>
        public   string RealIp{ get; set; }
        ///<summary>
        /// 名称
        ///</summary>
        public   string Name{ get; set; }
        ///<summary>
        /// 描述
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// 健康检查
        ///</summary>
        public   string HealthCheck{ get; set; }
        ///<summary>
        /// 健康检查响应的最大超时时间
        ///</summary>
        public   int? HealthCheckTimeout{ get; set; }
        ///<summary>
        /// 健康检查响应的最大间隔时间
        ///</summary>
        public   int? HealthCheckInterval{ get; set; }
        ///<summary>
        /// 健康检查结果为success的阈值
        ///</summary>
        public   int? HealthyThreshold{ get; set; }
        ///<summary>
        /// 健康检查结果为fail的阈值
        ///</summary>
        public   int? UnhealthyThreshold{ get; set; }
        ///<summary>
        /// 服务器组id
        ///</summary>
        public   string ServerGroupId{ get; set; }
        ///<summary>
        /// 地域ID，可调用接口（describeCPSLBRegions）获取云物理服务器支持的地域
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 监听器ID
        ///Required:true
        ///</summary>
        [Required]
        public   string ListenerId{ get; set; }
    }
}