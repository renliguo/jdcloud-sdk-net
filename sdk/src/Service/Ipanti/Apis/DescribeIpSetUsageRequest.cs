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
 * IP Sets
 * IP 黑白名单库, 预定义的 IP 黑白名单绑定到转发规则的黑名单或白名单后生效
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

namespace  JDCloudSDK.Ipanti.Apis
{

    /// <summary>
    ///  查询实例的 IP 黑白名单用量信息
    /// </summary>
    public class DescribeIpSetUsageRequest : JdcloudRequest
    {
        ///<summary>
        /// 区域 ID, 高防不区分区域, 传 cn-north-1 即可
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 高防实例 Id
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
    }
}