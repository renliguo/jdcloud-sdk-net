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
 * 跨地域备份同步服务
 * API related to Relational Database Service
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

using JDCloudSDK.Rds.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Rds.Apis
{

    /// <summary>
    ///  根据跨地域备份同步服务时间点创建实例。
    /// </summary>
    public class CreateInstanceByTimeInCrossRegionRequest : JdcloudRequest
    {
        ///<summary>
        /// 根据源实例的哪个时间点创建新实例
        ///Required:true
        ///</summary>
        [Required]
        public   string RestoreTime{ get; set; }
        ///<summary>
        /// 跨地域备份同步服务ID
        ///Required:true
        ///</summary>
        [Required]
        public   string ServiceId{ get; set; }
        ///<summary>
        /// 新建实例规格
        ///Required:true
        ///</summary>
        [Required]
        public   RestoredNewDBInstanceSpec InstanceSpec{ get; set; }
        ///<summary>
        /// 地域代码，取值范围参见[《各地域及可用区对照表》](../Enum-Definitions/Regions-AZ.md)
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}