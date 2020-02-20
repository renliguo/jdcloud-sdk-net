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
 * es实例接口
 * es实例的创建、变配、删除、查询接口
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

using JDCloudSDK.Es.Model;
using JDCloudSDK.Charge.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Es.Apis
{

    /// <summary>
    ///  创建一个指定配置的es实例
    /// </summary>
    public class CreateInstanceRequest : JdcloudRequest
    {
        ///<summary>
        /// es实例的相关配置
        ///Required:true
        ///</summary>
        [Required]
        public   InstanceSpec Instance{ get; set; }
        ///<summary>
        /// 计费信息的相关配置，es只有prepaid_by_duration和postpaid_by_duration 2种计费模式
        ///</summary>
        public   JDCloudSDK.Charge.Model.ChargeSpec Charge{ get; set; }
        ///<summary>
        /// regionId
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}