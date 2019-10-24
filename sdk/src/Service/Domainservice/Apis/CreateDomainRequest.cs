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
 * 域名
 * 云解析OpenAPI域名接口
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
    ///  添加主域名  
        ///         /// 如何添加免费域名，详细情况请查阅&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/jd-cloud-dns/domainadd&quot;&gt;文档&lt;/a&gt;
        ///         /// 添加收费域名，请查阅&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/jd-cloud-dns/purchase-process&quot;&gt;文档&lt;/a&gt;，
        ///         /// 添加收费域名前，请确保用户的京东云账户有足够的资金支付，Openapi接口回返回订单号，可以用此订单号向计费系统查阅详情。
        ///         /// 
    /// </summary>
    public class CreateDomainRequest : JdcloudRequest
    {
        ///<summary>
        /// 主域名的套餐类型, 免费:0 企业版:1 企业高级版:2
        ///Required:true
        ///</summary>
        [Required]
        public   int PackId{ get; set; }
        ///<summary>
        /// 要添加的主域名
        ///Required:true
        ///</summary>
        [Required]
        public   string DomainName{ get; set; }
        ///<summary>
        /// 主域名的ID，升级套餐必填，请使用describeDomains获取
        ///</summary>
        public   int? DomainId{ get; set; }
        ///<summary>
        /// 新购买:1、升级:3，收费套餐的域名必填
        ///</summary>
        public   int? BuyType{ get; set; }
        ///<summary>
        /// 取值1，2，3 ，含义：时长，收费套餐的域名必填
        ///</summary>
        public   int? TimeSpan{ get; set; }
        ///<summary>
        /// 时间单位，收费套餐的域名必填，1：小时，2：天，3：月，4：年
        ///</summary>
        public   int? TimeUnit{ get; set; }
        ///<summary>
        /// 计费类型，可以不传此参数。
        ///</summary>
        public   int? BillingType{ get; set; }
        ///<summary>
        /// 实例所属的地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}