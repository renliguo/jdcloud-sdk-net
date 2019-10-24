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
 * 解析记录
 * 云解析OpenAPI解析记录接口
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

namespace  JDCloudSDK.Domainservice.Apis
{

    /// <summary>
    ///  查询主域名的解析记录。  
        ///         /// 在使用解析记录相关的接口之前，请调用此接口获取解析记录的列表。
        ///         /// 
    /// </summary>
    public class DescribeResourceRecordRequest : JdcloudRequest
    {
        ///<summary>
        /// 当前页数，起始值为1，默认为1
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 分页查询时设置的每页行数, 默认为10
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 关键字，按照”%search%”模式匹配解析记录的主机记录
        ///</summary>
        public   string Search{ get; set; }
        ///<summary>
        /// 实例所属的地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 域名ID，请使用describeDomains接口获取。
        ///Required:true
        ///</summary>
        [Required]
        public   string DomainId{ get; set; }
    }
}