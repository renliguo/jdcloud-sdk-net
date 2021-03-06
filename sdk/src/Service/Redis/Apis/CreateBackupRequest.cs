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
    ///  创建并执行缓存Redis实例的备份任务，只能为手动备份，可设置备份文件名称
    /// </summary>
    public class CreateBackupRequest : JdcloudRequest
    {
        ///<summary>
        /// 备份文件名称，只支持英文数字和下划线的组合，长度不超过32个字符
        ///Required:true
        ///</summary>
        [Required]
        public   string FileName{ get; set; }
        ///<summary>
        /// 备份类型：手动备份为1，只能为手动备份
        ///Required:true
        ///</summary>
        [Required]
        public   int BackupType{ get; set; }
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