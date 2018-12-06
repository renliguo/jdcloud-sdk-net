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
 * 监控项相关接口
 * 监控项相关接口，提供可用监控项列表查询和监控数据查询等功能
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
using JDCloudSDK.Monitor.Model;

namespace  JDCloudSDK.Monitor.Apis
{

    /// <summary>
    ///  查看某资源多个监控项数据，metric介绍：&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/monitoring/metrics&quot;&gt;Metrics&lt;/a&gt;
    /// </summary>
    public class BatchDescribeMetricDataRequest : JdcloudRequest
    {
        ///<summary>
        /// 资源的类型，取值vm, lb, ip, database 等
        ///Required:true
        ///</summary>
        [Required]
        public   string ServiceCode{ get; set; }
        ///<summary>
        /// 资源的uuid
        ///Required:true
        ///</summary>
        [Required]
        public   string ResourceId{ get; set; }
        ///<summary>
        /// 指标聚合方式，每个指标都有默认的聚合方式， 可选值包括：sum,avg.max.min
        ///</summary>
        public   string AggrType{ get; set; }
        ///<summary>
        /// 查询时间范围的开始时间， UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ssZ（默认为当前时间，早于30d时，将被重置为30d）
        ///</summary>
        public   string StartTime{ get; set; }
        ///<summary>
        /// 查询时间范围的结束时间， UTC时间，格式：2016-12- yyyy-MM-dd&#39;T&#39;HH:mm:ssZ（为空时，将由startTime与timeInterval计算得出）
        ///</summary>
        public   string EndTime{ get; set; }
        ///<summary>
        /// 时间间隔：1h，6h，12h，1d，3d，7d，14d，固定时间间隔，timeInterval 与 endTime 至少填一项
        ///</summary>
        public   string TimeInterval{ get; set; }
        ///<summary>
        /// 自定义标签
        ///</summary>
        public List<TagFilter> Tags{ get; set; }

        ///<summary>
        /// 是否对查询的tags分组
        ///</summary>
        public   bool GroupBy{ get; set; }
        ///<summary>
        /// 是否跨资源查询，默认为false。当该字段为false时，取resourceId字段进行查询；当该子弹为true时，忽略resourceId字段，从tags中取resourceId作为实际的多资源id处理。
        ///</summary>
        public   bool MultiResources{ get; set; }
        ///<summary>
        /// 自定义过滤标签，查询时必须在filters中指定要查询的metric，支持多个metric。如：  name&#x3D;&#39;metric&#39;,values&#x3D;[&quot;metric1&quot;,&quot;metric2&quot;]
        ///</summary>
        public List<Filter> Filters{ get; set; }

        ///<summary>
        /// 地域 Id
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}