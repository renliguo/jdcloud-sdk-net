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
 * order相关接口
 * API related to order
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

namespace  JDCloudSDK.Order.Apis
{

    /// <summary>
    /// 订单改价
    /// </summary>
    public class UpdateOrderPriceRequest : JdcloudRequest
    {
        ///<summary>
        ///订单对应的用户pin
        ///Required:true
        ///</summary>
        [Required]
        public   string OrderPin{ get; set; }
        ///<summary>
        ///修改的价格
        ///Required:true
        ///</summary>
        [Required]
        public   double ActualFee{ get; set; }
        ///<summary>
        ///改价原因
        ///Required:true
        ///</summary>
        [Required]
        public   string Remark{ get; set; }
        ///<summary>
        ///Region ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        ///Order Number
        ///Required:true
        ///</summary>
        [Required]
        public   string OrderNumber{ get; set; }
    }
}