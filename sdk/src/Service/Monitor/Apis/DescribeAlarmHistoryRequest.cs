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
 * Monitoring Rules APIs
 * 云监控规则相关接口，提供创建、查询、修改、删除监控规则等功能
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
    ///  查询报警历史
    /// </summary>
    public class DescribeAlarmHistoryRequest : JdcloudRequest
    {
        ///<summary>
        /// 当前所在页，默认为1
        ///</summary>
        public   long? PageNumber{ get; set; }
        ///<summary>
        /// 页面大小，默认为20；取值范围[1, 100]
        ///</summary>
        public   long? PageSize{ get; set; }
        ///<summary>
        /// 产品线标识，同一个产品线下可能存在多个product，如(redis下有redis2.8cluster、redis4.0)
        ///</summary>
        public   string ServiceCode{ get; set; }
        ///<summary>
        /// 产品标识,默认返回该product下所有dimension的数据。eg:product&#x3D;redis2.8cluster（redis2.8cluster产品下包含redis2.8-shard与redis2.8-proxy、redis2.8-instance多个维度)。
        ///</summary>
        public   string Product{ get; set; }
        ///<summary>
        /// 维度标识、指定该参数时，查询只返回该维度的数据。如redis2.8cluster下存在实例、分片等多个维度
        ///</summary>
        public   string Dimension{ get; set; }
        ///<summary>
        /// 根据region筛选对应region的资源的报警历史
        ///</summary>
        public   string Region{ get; set; }
        ///<summary>
        /// 正在报警, 取值为1
        ///</summary>
        public   long? IsAlarming{ get; set; }
        ///<summary>
        /// 报警的状态,1为报警恢复、2为报警、4为报警恢复无数据
        ///</summary>
        public   long? Status{ get; set; }
        ///<summary>
        /// 开始时间
        ///</summary>
        public   string StartTime{ get; set; }
        ///<summary>
        /// 结束时间
        ///</summary>
        public   string EndTime{ get; set; }
        ///<summary>
        /// 规则类型,默认查询1， 1表示资源监控，6表示站点监控,7表示可用性监控
        ///</summary>
        public   long? RuleType{ get; set; }
        ///<summary>
        /// 规则名称模糊搜索
        ///</summary>
        public   string RuleName{ get; set; }
        ///<summary>
        /// serviceCodes - 产品线servicecode，精确匹配，支持多个
        /// resourceIds - 资源Id，精确匹配，支持多个（必须指定serviceCode才会在该serviceCode下根据resourceIds过滤，否则该参数不生效）
        /// alarmIds - 规则Id，精确匹配，支持多个
        ///</summary>
        public List<Filter> Filters{ get; set; }

    }
}