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
 * 网站监控
 * 云解析OpenAPI网站监控接口
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

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Domainservice.Apis
{

    /// <summary>
    ///  监控项的操作集合，包括：暂停，启动, 手动恢复, 手动切换
    /// </summary>
    public class ModifyMonitorStatusRequest : JdcloudRequest
    {
        ///<summary>
        /// 暂停stop, 开启start, 手动恢复recover，手动切换switch，手动恢复和手动切换时候不支持批量操作
        ///Required:true
        ///</summary>
        [Required]
        public   string Action{ get; set; }
        ///<summary>
        /// 监控项的主机值, 手动切换时必填
        ///</summary>
        public   string SwitchTarget{ get; set; }
        ///<summary>
        /// 实例所属的地域ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// 域名ID，请使用describeDomains接口获取。
        ///Required:true
        ///</summary>
        [Required]
        public   string DomainId{ get; set; }
        ///<summary>
        /// 监控项ID，请使用describeMonitor接口获取。
        ///Required:true
        ///</summary>
        [Required]
        public   string MonitorId{ get; set; }
    }
}