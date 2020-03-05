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

using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Rds.Apis
{

    /// <summary>
    ///  实例扩容，支持升级实例的CPU，内存及磁盘。
    /// </summary>
    public class ModifyInstanceSpecRequest : JdcloudRequest
    {
        ///<summary>
        /// 扩容后实例规格
        ///Required:true
        ///</summary>
        [Required]
        public   string NewInstanceClass{ get; set; }
        ///<summary>
        /// 扩容后实例磁盘大小
        ///Required:true
        ///</summary>
        [Required]
        public   int NewInstanceStorageGB{ get; set; }
        ///<summary>
        /// 存储类型，如果不指定，默认会采用实例原存储类型.
        ///</summary>
        public   string NewInstanceStorageType{ get; set; }
        ///<summary>
        /// 实例数据加密(存储类型为云硬盘才支持数据加密). false：不加密; true：加密. 如果实例从本地盘变为云硬盘，缺省为false. 如果实例本来就是使用云硬盘的，缺省和源实例保持一致
        ///</summary>
        public   bool StorageEncrypted{ get; set; }
        ///<summary>
        /// 地域代码，取值范围参见[《各地域及可用区对照表》](../Enum-Definitions/Regions-AZ.md)
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// RDS 实例ID，唯一标识一个RDS实例
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
    }
}