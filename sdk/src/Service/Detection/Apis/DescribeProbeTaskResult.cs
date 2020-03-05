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
 * Availability-Monitoring-APIs
 * 可用性监控相关接口，提供创建、查询、修改、删除可用性监控任务等功能
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

using JDCloudSDK.Detection.Model;

namespace  JDCloudSDK.Detection.Apis
{

    /// <summary>
    ///  查询可用性监控任务信息
    /// </summary>
    public class DescribeProbeTaskResult : JdcloudResult
    {
        ///<summary>
        /// 探测源信息
        ///</summary>
        public List<Probe> Probes{ get; set; }

        ///<summary>
        /// 探测地址
        ///</summary>
        public   string Address{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public   DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 是否被删除
        ///</summary>
        public   bool Deleted{ get; set; }
        ///<summary>
        /// 是否启用
        ///</summary>
        public   bool Enable{ get; set; }
        ///<summary>
        /// 探测频率，单位秒
        ///</summary>
        public   long? Frequency{ get; set; }
        ///<summary>
        /// http探测的body
        ///</summary>
        public   string HttpBody{ get; set; }
        ///<summary>
        /// http探测的cookie
        ///</summary>
        public List<KeyValue> HttpCookie{ get; set; }

        ///<summary>
        /// http探测的header
        ///</summary>
        public List<KeyValue> HttpHeader{ get; set; }

        ///<summary>
        /// http探测方式
        ///</summary>
        public   long? HttpType{ get; set; }
        ///<summary>
        /// 探测任务 名称
        ///</summary>
        public   string Name{ get; set; }
        ///<summary>
        /// pin
        ///</summary>
        public   string Pin{ get; set; }
        ///<summary>
        /// 探测端口
        ///</summary>
        public   long? Port{ get; set; }
        ///<summary>
        /// 探测类型1:http、2:telnet
        ///</summary>
        public   long? ProbeType{ get; set; }
        ///<summary>
        /// 探测对象的uid(http探测方法无uid)
        ///</summary>
        public   string TargetId{ get; set; }
        ///<summary>
        /// 探测对象所在region，redis或RDS所在region
        ///</summary>
        public   string TargetRegion{ get; set; }
        ///<summary>
        /// 探测任务 id
        ///</summary>
        public   string TaskId{ get; set; }
        ///<summary>
        /// 任务类型、1:url/ip、2:RDS、3:redis
        ///</summary>
        public   long? TaskType{ get; set; }
        ///<summary>
        /// 探测超时时间，单位秒
        ///</summary>
        public   long? Timeout{ get; set; }
        ///<summary>
        /// 更新时间
        ///</summary>
        public   DateTime? UpdateTime{ get; set; }
    }
}