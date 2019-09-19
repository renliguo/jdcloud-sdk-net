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
    ///  查询监控图可用的产品线列表
    /// </summary>
    public class DescribeServicesRequest : JdcloudRequest
    {
        ///<summary>
        /// 服务码列表
        /// filter name 为serviceCodes表示查询多个产品线的规则
        ///</summary>
        public List<Filter> Filters{ get; set; }

        ///<summary>
        /// 要查询的产品线类型   0：all    1：资源监控   2：其它   默认：1。若指定了查询的serviceCode，则忽略该参数
        ///</summary>
        public   long? ProductType{ get; set; }
    }
}