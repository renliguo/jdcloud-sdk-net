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
using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Monitor.Apis
{

    /// <summary>
    ///  查询规则, 查询参数组合及优先级从高到低为：
        ///         /// 1：alarmIds不为空
        ///         /// 2：alarmId不为空
        ///         /// 3：serviceCode不为空
        ///         /// 3.1：serviceCode + resourceId
        ///         /// 3.2: serviceCode + resourceIds
        ///         /// 3.3: serviceCode + ruleName
        ///         /// 4：serviceCodes不为空
        ///         /// 4.1：serviceCode + resourceId
        ///         /// 4.2: serviceCode + resourceIds
        ///         /// 4.3: serviceCode + ruleName
        ///         /// 5: 所有规则
    /// </summary>
    public class DescribeAlarmsRequest : JdcloudRequest
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
        /// 产品线标识,默认返回该serviceCode下所有group的数据。eg:serviceCode&#x3D;jdw（jdw产品线下包含jdw-master与jdw-segment两个分组)会返回jdw-master和jdw-segment的数据。
        ///</summary>
        public   string ServiceCode{ get; set; }
        ///<summary>
        /// 分组标识、指定该参数时，查询只返回该group的数据。groupCode参数仅在与serviceCode匹配时生效；eg:serviceCode&#x3D;jdw、groupCode&#x3D;jdw-master,只返回jdw-master分组的数据，不返回jdw-segment的数据。
        ///</summary>
        public   string GroupCode{ get; set; }
        ///<summary>
        /// 资源ID,根据resourceId查询时必须指定serviceCode才会生效
        ///</summary>
        public   string ResourceId{ get; set; }
        ///<summary>
        /// 规则类型, 1表示资源监控，6表示站点监控,7表示可用性监控
        ///</summary>
        public   long? RuleType{ get; set; }
        ///<summary>
        /// 规则报警状态, 1：正常, 2：报警，4：数据不足
        ///</summary>
        public   long? Status{ get; set; }
        ///<summary>
        /// 规则状态：1为启用，0为禁用
        ///</summary>
        public   long? Enabled{ get; set; }
        ///<summary>
        /// 是否为正在报警的规则，0为忽略，1为是，与 status 同时只能生效一个,isAlarming 优先生效
        ///</summary>
        public   long? IsAlarming{ get; set; }
        ///<summary>
        /// 规则的id，若指定filter的alarmIds过滤时，忽略该参数
        ///</summary>
        public   string AlarmId{ get; set; }
        ///<summary>
        /// 服务码或资源Id列表
        /// serviceCodes - 产品线servicecode，精确匹配，支持多个
        /// resourceIds - 资源Id，精确匹配，支持多个（必须指定serviceCode才会在该serviceCode下根据resourceIds过滤，否则该参数不生效）
        /// alarmIds - 规则id，精确匹配，支持多个
        /// ruleName - 规则名称，模糊匹配，支持单个
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