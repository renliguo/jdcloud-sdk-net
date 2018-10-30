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
 * 
 * 
 *
 * 
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Monitor.Model
{

    /// <summary>
    ///  创建监控规则
    /// </summary>
    public class CreateAlarmSpec
    {

        ///<summary>
        /// 报警规则通知的联系组，必须在控制台上已创建，例如&quot; [&#39;联系组1&#39;,&#39;联系组2&#39;]&quot;
        ///</summary>
        public List<string> ContactGroups{ get; set; }
        ///<summary>
        /// 报警规则通知的联系人，必须在控制台上已创建，例如 [“联系人1”,”联系人2”]
        ///</summary>
        public List<string> ContactPersons{ get; set; }
        ///<summary>
        /// 取样频次
        ///</summary>
        public string DownSample{ get; set; }
        ///<summary>
        /// 根据产品线查询可用监控项列表 接口 返回的Metric字段
        ///Required:true
        ///</summary>
        [Required]
        public string Metric{ get; set; }
        ///<summary>
        /// 通知周期 单位：小时
        ///</summary>
        public long? NoticePeriod{ get; set; }
        ///<summary>
        /// 报警规则对应实例列表，每次最多100个，例如&quot;[&#39;resourceId1&#39;,&#39;resourceId2&#39;]&quot;
        ///Required:true
        ///</summary>
        [Required]
        public List<string> ResourceIds{ get; set; }
        ///<summary>
        /// 产品名称
        ///Required:true
        ///</summary>
        [Required]
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 查询指标的周期，单位为分钟,目前支持的取值：2，5，15，30，60
        ///Required:true
        ///</summary>
        [Required]
        public double Threshold{ get; set; }
        ///<summary>
        /// 连续探测几次都满足阈值条件时报警，可选值:1,2,3,5
        ///Required:true
        ///</summary>
        [Required]
        public long Times{ get; set; }
    }
}
