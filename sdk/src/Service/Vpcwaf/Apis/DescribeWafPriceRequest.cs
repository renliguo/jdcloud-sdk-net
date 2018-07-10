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
 * 实例管理相关接口
 * API related to waf instance
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

namespace  JDCloudSDK.Vpcwaf.Apis
{

    /// <summary>
    /// 查询WAF实例价格
    /// </summary>
    public class DescribeWafPriceRequest : JdcloudRequest
    {
        ///<summary>
        ///WAF套餐，参考wafInstance.version
        ///Required:true
        ///</summary>
        [Required]
        public   string WafVersion{ get; set; }
        ///<summary>
        ///预付费计费单位，当chargeMode为prepaid_by_duration时有效，取值为：month、year，默认为month
        ///Required:true
        ///</summary>
        [Required]
        public   string ChargeUnit{ get; set; }
        ///<summary>
        ///预付费计费时长，当chargeMode取值为prepaid_by_duration时有效。当chargeUnit为month时取值为：1~9，当chargeUnit为year时取值为：1、2、3
        ///Required:true
        ///</summary>
        [Required]
        public   int ChargeDuration{ get; set; }
        ///<summary>
        ///地域 Id
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}