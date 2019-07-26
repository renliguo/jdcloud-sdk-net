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
 * IP Resource APIs
 * Anti DDoS Basic IP Resource APIs
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

namespace  JDCloudSDK.Baseanti.Apis
{

    /// <summary>
    ///  查询基础防护已防护的私有网络的弹性公网 IP 的安全信息. 包括私有网络的弹性公网 IP(运营商级 NAT 保留地址除外)
        ///         /// 
    /// </summary>
    public class DescribeElasticIpResourcesRequest : JdcloudRequest
    {
        ///<summary>
        /// 页码
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 分页大小
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 地域编码. 基础防护已支持华北-北京, 华东-宿迁, 华东-上海, 华南-广州
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}