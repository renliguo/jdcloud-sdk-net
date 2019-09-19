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
 * 监控项自定义监控相关接口
 * 自定义监控项相关接口，提供自定义监控数据上报功能
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

using JDCloudSDK.Monitor.Model;

namespace  JDCloudSDK.Monitor.Apis
{

    /// <summary>
    ///  该接口为自定义监控数据上报的接口，方便您将自己采集的时序数据上报到云监控。不同region域名上报不同region的数据，参考：&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/monitoring/reporting-monitoring-data&quot;&gt;调用说明&lt;/a&gt;可上报原始数据和已聚合的统计数据。支持批量上报方式。单次请求最多包含 50 个数据点；数据大小不超过 256k。
    /// </summary>
    public class PutMetricDataRequest : JdcloudRequest
    {
        ///<summary>
        /// 数据参数
        ///</summary>
        public List<MetricDataCm> MetricDataList{ get; set; }

    }
}