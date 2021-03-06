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
 * 实例管理
 * 实例管理相关接口
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
    ///  根据源实例全量备份创建一个新实例，新实例的数据跟源实例在创建备份时的数据状态一样。&lt;br&gt;例如根据源实例A的一个全量备份“mybak”新建一个实例B，该备份是在“‘2018-8-18 03:23:54”创建的。那么新建实例B的数据状态跟实例A‘2018-8-18 03:23:54’的状态一致
    /// </summary>
    public class CreateInstanceFromBackupRequest : JdcloudRequest
    {
        ///<summary>
        /// 备份ID
        ///Required:true
        ///</summary>
        [Required]
        public   string BackupId{ get; set; }
        ///<summary>
        /// 标识是创建什么类型的实例，例如MySQL，SQL Server等,具体可参见文档[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)&lt;br&gt;**注意：备份来源实例的engine和要创建的实例的engine必须一致**
        ///Required:true
        ///</summary>
        [Required]
        public   string Engine{ get; set; }
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