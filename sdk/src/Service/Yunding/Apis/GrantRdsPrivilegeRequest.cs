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
 * yunding-rds
 * 云鼎-云数据库管理相关接口
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

using JDCloudSDK.Rds.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Yunding.Apis
{

    /// <summary>
    ///  授予账号的数据库访问权限，即该账号对数据库拥有什么权限。一个账号可以对多个数据库具有访问权限。&lt;br&gt;为便于管理，RDS对权限进行了归类，目前提供以下两种权限&lt;br&gt;- ro：只读权限，用户只能读取数据库中的数据，不能进行创建、插入、删除、更改等操作。&lt;br&gt;- rw：读写权限，用户可以对数据库进行增删改查等操作
    /// </summary>
    public class GrantRdsPrivilegeRequest : JdcloudRequest
    {
        ///<summary>
        /// 账号的访问权限
        ///Required:true
        ///</summary>
        [Required]
        public List<JDCloudSDK.Rds.Model.AccountPrivilege> AccountPrivileges{ get; set; }

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
        ///<summary>
        /// 账号名，在同一个实例中账号名不能重复
        ///Required:true
        ///</summary>
        [Required]
        public   string AccountName{ get; set; }
    }
}