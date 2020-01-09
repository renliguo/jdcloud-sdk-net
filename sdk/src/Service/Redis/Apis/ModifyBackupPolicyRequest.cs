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
 * Redis Instance API
 * 缓存Redis实例的创建、删除、修改基本信息、设置密码、变配、实例列表、备份、配置参数等接口
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

namespace  JDCloudSDK.Redis.Apis
{

    /// <summary>
    ///  修改缓存Redis实例的自动备份策略，可修改备份周期和备份时间
    /// </summary>
    public class ModifyBackupPolicyRequest : JdcloudRequest
    {
        ///<summary>
        /// 备份时间，格式为：HH:mm-HH:mm 时区，例如&quot;01:00-02:00 +0800&quot;，表示东八区的1点到2点
        ///Required:true
        ///</summary>
        [Required]
        public   string BackupTime{ get; set; }
        ///<summary>
        /// 备份周期，包括：Monday，Tuesday，Wednesday，Thursday，Friday，Saturday，Sunday，多个用逗号分隔
        ///Required:true
        ///</summary>
        [Required]
        public   string BackupPeriod{ get; set; }
        ///<summary>
        /// 缓存Redis实例所在区域的Region ID。目前有华北-北京、华南-广州、华东-上海三个区域，Region ID分别为cn-north-1、cn-south-1、cn-east-2
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 缓存Redis实例ID，是访问实例的唯一标识
        ///Required:true
        ///</summary>
        [Required]
        public   string CacheInstanceId{ get; set; }
    }
}