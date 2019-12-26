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
 * Elastic-Network-Interface
 * 弹性网卡相关接口
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

namespace  JDCloudSDK.Vpc.Apis
{

    /// <summary>
    ///  给网卡分配secondaryIp接口
    /// </summary>
    public class AssignSecondaryIpsRequest : JdcloudRequest
    {
        ///<summary>
        /// secondary ip被其他接口占用时，是否抢占。false：非抢占重分配，true：抢占重分配，默认抢占重分配。默认值：true
        ///</summary>
        public   bool Force{ get; set; }
        ///<summary>
        /// 指定分配的secondaryIp地址
        ///</summary>
        public List<string> SecondaryIps{ get; set; }

        ///<summary>
        /// 指定自动分配的secondaryIp个数
        ///</summary>
        public   double? SecondaryIpCount{ get; set; }
        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// networkInterface ID
        ///Required:true
        ///</summary>
        [Required]
        public   string NetworkInterfaceId{ get; set; }
    }
}