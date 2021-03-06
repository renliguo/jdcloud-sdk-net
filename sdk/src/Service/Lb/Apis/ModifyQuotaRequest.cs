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
 * Quota
 * 配额的相关接口
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

namespace  JDCloudSDK.Lb.Apis
{

    /// <summary>
    ///  修改配额信息
    /// </summary>
    public class ModifyQuotaRequest : JdcloudRequest
    {
        ///<summary>
        /// lb类型，取值范围：alb、nlb、dnlb，默认为alb
        ///</summary>
        public   string LbType{ get; set; }
        ///<summary>
        /// 资源类型，取值范围：loadbalancer、listener、target_group、target、backend、urlMap(仅alb支持)、rules(仅alb支持)
        ///Required:true
        ///</summary>
        [Required]
        public   string Type{ get; set; }
        ///<summary>
        /// type为loadbalancer不设置, type为listener、backend、target_group、urlMap设置为loadbalancerId, type为target设置为targetGroupId, type为rules设置为urlMapId
        ///</summary>
        public   string ParentResourceId{ get; set; }
        ///<summary>
        /// 配额大小
        ///Required:true
        ///</summary>
        [Required]
        public   int MaxLimit{ get; set; }
        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}