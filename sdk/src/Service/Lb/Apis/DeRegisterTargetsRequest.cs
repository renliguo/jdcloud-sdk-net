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
 * TargetGroup
 * 目标target组相关接口
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
    ///  从TargetGroup中移除一个或多个Target，失败则全部回滚。 成功移除后，所有target将不会再接收来自loadbalancer新建连接的流量
    /// </summary>
    public class DeRegisterTargetsRequest : JdcloudRequest
    {
        ///<summary>
        /// Target Id列表
        ///</summary>
        public List<string> TargetIds{ get; set; }

        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// TargetGroup Id
        ///Required:true
        ///</summary>
        [Required]
        public   string TargetGroupId{ get; set; }
    }
}