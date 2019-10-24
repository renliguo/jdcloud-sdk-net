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

using Newtonsoft.Json;
using JDCloudSDK.Charge.Model;

namespace JDCloudSDK.Edcps.Model
{

    /// <summary>
    ///  elasticIp
    /// </summary>
    public class ElasticIp
    {

        ///<summary>
        /// 地域代码, 如cn-east-tz1
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// 弹性公网IPID
        ///</summary>
        public string ElasticIpId{ get; set; }
        ///<summary>
        /// 弹性公网IP
        ///</summary>
        [JsonProperty("elasticIp")]
        public string ElasticIpValue{ get; set; }
        ///<summary>
        /// 带宽, 单位Mbps
        ///</summary>
        public int? Bandwidth{ get; set; }
        ///<summary>
        /// 额外上行带宽, 单位Mbps
        ///</summary>
        public int? ExtraUplinkBandwidth{ get; set; }
        ///<summary>
        /// 链路类型
        ///</summary>
        public string LineType{ get; set; }
        ///<summary>
        /// 状态
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 实例类型
        ///</summary>
        public string InstanceType{ get; set; }
        ///<summary>
        /// 实例ID
        ///</summary>
        public string InstanceId{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public string CreateTime{ get; set; }
        ///<summary>
        /// 计费信息
        ///</summary>
        public JDCloudSDK.Charge.Model.Charge Charge{ get; set; }
    }
}
