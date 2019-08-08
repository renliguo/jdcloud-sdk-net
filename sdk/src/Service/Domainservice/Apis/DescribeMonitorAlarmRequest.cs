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
    ///  主域名的监控项的报警信息
    /// </summary>
    public class DescribeMonitorAlarmRequest : JdcloudRequest
    {
        ///<summary>
        /// 当前页数，起始值为1，默认为1
        ///</summary>
        public   int? PageIndex{ get; set; }
        ///<summary>
        /// 分页查询时设置的每页行数
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 关键字
        ///</summary>
        public   string SearchValue{ get; set; }
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
    }
}