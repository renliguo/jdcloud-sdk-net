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
 * 
 * 
 *
 * 
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Domainservice.Model
{

    /// <summary>
    ///  batchSetDNS
    /// </summary>
    public class BatchSetDNS
    {

        ///<summary>
        /// 主机记录
        ///Required:true
        ///</summary>
        [Required]
        public string HostRecord{ get; set; }
        ///<summary>
        /// 解析记录的值
        ///Required:true
        ///</summary>
        [Required]
        public string HostValue{ get; set; }
        ///<summary>
        /// 解析记录的ID, 如果是新增请填0，如果是更新，请使用describeResourceRecord接口查询解析记录ID。
        ///Required:true
        ///</summary>
        [Required]
        public int Id{ get; set; }
        ///<summary>
        /// 是否是京东云资源
        ///</summary>
        public bool JcloudRes{ get; set; }
        ///<summary>
        /// 优先级，只存在于MX, SRV解析记录类型
        ///</summary>
        public int? MxPriority{ get; set; }
        ///<summary>
        /// 端口，只存在于SRV解析记录类型
        ///</summary>
        public int? Port{ get; set; }
        ///<summary>
        /// 解析记录的生存时间，单位：秒
        ///Required:true
        ///</summary>
        [Required]
        public int Ttl{ get; set; }
        ///<summary>
        /// 解析的类型，请参考&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/jd-cloud-dns/detailed-interpretation-of-parsed-records&quot;&gt;解析记录类型详解&lt;/a&gt;
        ///Required:true
        ///</summary>
        [Required]
        public string Type{ get; set; }
        ///<summary>
        /// 解析记录的权重，目前支持权重的有：A/AAAA/CNAME/JNAME，A/AAAA权重范围：0-100、CNAME/JNAME权重范围：1-100。
        ///</summary>
        public int? Weight{ get; set; }
        ///<summary>
        /// 解析线路的ID，请调用describeViewTree接口获取基础解析线路的ID，使用describeUserView接口获取自定义线路的ID。
        ///Required:true
        ///</summary>
        [Required]
        public int ViewValue{ get; set; }
    }
}
