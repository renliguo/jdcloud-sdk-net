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
 * JDCLOUD BILLING Services API
 * 用户中心消费管理查询API接口
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

namespace  JDCloudSDK.Billing.Apis
{

    /// <summary>
    ///  查询消费记录列表
    /// </summary>
    public class QueryConsumeBillsRequest : JdcloudRequest
    {
        ///<summary>
        /// QueryType
        ///</summary>
        public   int? QueryType{ get; set; }
        ///<summary>
        /// AppCode
        ///</summary>
        public   string AppCode{ get; set; }
        ///<summary>
        /// ServiceCode
        ///</summary>
        public   string ServiceCode{ get; set; }
        ///<summary>
        /// BillingType
        ///</summary>
        public   int? BillingType{ get; set; }
        ///<summary>
        /// PayType
        ///</summary>
        public   int? PayType{ get; set; }
        ///<summary>
        /// PayState
        ///</summary>
        public   int? PayState{ get; set; }
        ///<summary>
        /// TimeType
        ///</summary>
        public   int? TimeType{ get; set; }
        ///<summary>
        /// StartTime
        ///</summary>
        public   string StartTime{ get; set; }
        ///<summary>
        /// EndTime
        ///</summary>
        public   string EndTime{ get; set; }
        ///<summary>
        /// IgnoreZero
        ///</summary>
        public   int? IgnoreZero{ get; set; }
        ///<summary>
        /// ResourceId
        ///</summary>
        public   string ResourceId{ get; set; }
        ///<summary>
        /// Site
        ///</summary>
        public   int? Site{ get; set; }
        ///<summary>
        /// Role
        ///</summary>
        public   int? Role{ get; set; }
        ///<summary>
        /// Region
        ///</summary>
        public   string Region{ get; set; }
        ///<summary>
        /// PageIndex
        ///</summary>
        public   int? PageIndex{ get; set; }
        ///<summary>
        /// PageSize
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// RegionId
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}