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

using JDCloudSDK.Domainservice.Model;

namespace  JDCloudSDK.Domainservice.Apis
{

    /// <summary>
    ///  添加主域名  
        ///         /// 如何添加免费域名，详细情况请查阅&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/jd-cloud-dns/domainadd&quot;&gt;文档&lt;/a&gt;
        ///         /// 添加收费域名，请查阅&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/jd-cloud-dns/purchase-process&quot;&gt;文档&lt;/a&gt;，
        ///         /// 添加收费域名前，请确保用户的京东云账户有足够的资金支付，Openapi接口回返回订单号，可以用此订单号向计费系统查阅详情。
        ///         /// 
    /// </summary>
    public class CreateDomainResult : JdcloudResult
    {
        ///<summary>
        /// 新添加的的域名结构
        ///</summary>
        public   DomainAdded Data{ get; set; }
        ///<summary>
        /// 添加收费版域名的订单号
        ///</summary>
        public   string Order{ get; set; }
    }
}