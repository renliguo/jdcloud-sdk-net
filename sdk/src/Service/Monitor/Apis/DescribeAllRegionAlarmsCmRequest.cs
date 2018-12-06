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
 * CustomMetric APIs
 * 自定义监控相关接口
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


namespace  JDCloudSDK.Monitor.Apis
{

    /// <summary>
    ///  查询所有region的自定义监控规则
    /// </summary>
    public class DescribeAllRegionAlarmsCmRequest : JdcloudRequest
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
        /// 命名空间名称
        ///</summary>
        public   string Namespace{ get; set; }
        ///<summary>
        /// 对象名称
        ///</summary>
        public   string Obj{ get; set; }
        ///<summary>
        /// 产品名称
        ///</summary>
        public   string ServiceCode{ get; set; }
        ///<summary>
        /// 资源Id
        ///</summary>
        public   string ResourceId{ get; set; }
        ///<summary>
        /// 规则报警状态, 1：正常, 2：报警，4：数据不足
        ///</summary>
        public   long? Status{ get; set; }
        ///<summary>
        /// 是否为正在报警的规则，0为忽略，1为是，与 status 同时只能生效一个,isAlarming 优先生效
        ///</summary>
        public   long? IsAlarming{ get; set; }
        ///<summary>
        /// 规则状态：1为启用，0为禁用
        ///</summary>
        public   long? Enabled{ get; set; }
        ///<summary>
        /// region info
        ///</summary>
        public   string Region{ get; set; }
    }
}