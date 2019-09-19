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

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Cps.Model
{

    /// <summary>
    ///  listenerSpec
    /// </summary>
    public class ListenerSpec
    {

        ///<summary>
        /// 负载均衡实例ID
        ///Required:true
        ///</summary>
        [Required]
        public string LoadBalancerId{ get; set; }
        ///<summary>
        /// 协议, 如TCP
        ///Required:true
        ///</summary>
        [Required]
        public string Protocol{ get; set; }
        ///<summary>
        /// 端口1-65535
        ///Required:true
        ///</summary>
        [Required]
        public int Port{ get; set; }
        ///<summary>
        /// 调度算法，取值wrr（加权轮询）|wlc（加权最小连接数）|conhash（源IP）)
        ///Required:true
        ///</summary>
        [Required]
        public string Algorithm{ get; set; }
        ///<summary>
        /// 是否开启会话保持，取值on|off
        ///Required:true
        ///</summary>
        [Required]
        public string StickySession{ get; set; }
        ///<summary>
        /// 是否获取真实ip，取值on|off
        ///</summary>
        public string RealIp{ get; set; }
        ///<summary>
        /// 名称
        ///Required:true
        ///</summary>
        [Required]
        public string Name{ get; set; }
        ///<summary>
        /// 描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 是否开启健康检查，取值on|off
        ///Required:true
        ///</summary>
        [Required]
        public string HealthCheck{ get; set; }
        ///<summary>
        /// 健康检查响应的最大超时时间，单位s
        ///</summary>
        public int? HealthCheckTimeout{ get; set; }
        ///<summary>
        /// 健康检查响应的最大间隔时间，单位s
        ///</summary>
        public int? HealthCheckInterval{ get; set; }
        ///<summary>
        /// 健康检查结果为success的阈值
        ///</summary>
        public int? HealthyThreshold{ get; set; }
        ///<summary>
        /// 健康检查结果为fail的阈值
        ///</summary>
        public int? UnhealthyThreshold{ get; set; }
        ///<summary>
        /// 服务器组id
        ///</summary>
        public string ServerGroupId{ get; set; }
    }
}
