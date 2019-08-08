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
    ///  baseRuleT
    /// </summary>
    public class BaseRuleT
    {

        ///<summary>
        /// 弹性伸缩组ID
        ///</summary>
        public string AutoScalingPolicyId{ get; set; }
        ///<summary>
        /// 监控项单位
        ///</summary>
        public string CalculateUnit{ get; set; }
        ///<summary>
        /// 统计方法，必须与定义的metric一致，可选值列表：avg,sum,max,min
        ///Required:true
        ///</summary>
        [Required]
        public string Calculation{ get; set; }
        ///<summary>
        /// 降采样函数
        ///</summary>
        public string DownSample{ get; set; }
        ///<summary>
        /// 监控项
        ///Required:true
        ///</summary>
        [Required]
        public string Metric{ get; set; }
        ///<summary>
        /// 监控项ID
        ///</summary>
        public long? MetricId{ get; set; }
        ///<summary>
        /// NoticeLevel
        ///</summary>
        public NoticeLevel NoticeLevel{ get; set; }
        ///<summary>
        /// 通知周期，单位：小时
        ///Required:true
        ///</summary>
        [Required]
        public long NoticePeriod{ get; set; }
        ///<summary>
        /// 报警比较符，只能为以下几种lte(&lt;&#x3D;),lt(&lt;),gt(&gt;),gte(&gt;&#x3D;),eq(&#x3D;&#x3D;),ne(!&#x3D;)
        ///Required:true
        ///</summary>
        [Required]
        public string Operation{ get; set; }
        ///<summary>
        /// 查询指标的周期，单位为分钟,目前支持的取值：1, 2，5，10,15，30，60
        ///Required:true
        ///</summary>
        [Required]
        public long Period{ get; set; }
        ///<summary>
        /// 规则类型, 1表示云监控，2表示弹性伸缩，3表示AG，4表示AutoHeal，5表示自定义监控，6表示hawkeye
        ///Required:true
        ///</summary>
        [Required]
        public long RuleType{ get; set; }
        ///<summary>
        /// 多值标签
        ///</summary>
        public Dictionary<String,string> Tags{ get; set; }
        ///<summary>
        /// 报警阈值，目前只开放数值类型功能
        ///Required:true
        ///</summary>
        [Required]
        public double Threshold{ get; set; }
        ///<summary>
        /// 连续探测几次都满足阈值条件时报警，可选值:1,2,3,5,10,15,30,60
        ///Required:true
        ///</summary>
        [Required]
        public long Times{ get; set; }
    }
}
