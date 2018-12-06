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

using JDCloudSDK.Monitor.Model;

namespace  JDCloudSDK.Monitor.Apis
{

    /// <summary>
    ///  查看某资源多个监控项数据，metric介绍1：&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/monitoring/metrics&quot;&gt;Metrics&lt;/a&gt;
    /// </summary>
    public class DescribeMetricDataResult : JdcloudResult
    {
        ///<summary>
        /// MetricDatas
        ///</summary>
        public List<MetricData> MetricDatas{ get; set; }

    }
}