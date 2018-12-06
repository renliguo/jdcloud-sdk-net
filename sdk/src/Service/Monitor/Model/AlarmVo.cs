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


namespace JDCloudSDK.Monitor.Model
{

    /// <summary>
    ///  alarmVo
    /// </summary>
    public class AlarmVo
    {

        ///<summary>
        /// 监控项单位
        ///</summary>
        public string CalculateUnit{ get; set; }
        ///<summary>
        /// 统计方法：平均值&#x3D;avg、最大值&#x3D;max、最小值&#x3D;min
        ///</summary>
        public string Calculation{ get; set; }
        ///<summary>
        /// 联系人列表
        ///</summary>
        public List<BaseContact> Contacts{ get; set; }
        ///<summary>
        /// CreateTime
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 是否删除 1正常，0删除
        ///</summary>
        public long? Deleted{ get; set; }
        ///<summary>
        /// 规则ID
        ///</summary>
        public long? Id{ get; set; }
        ///<summary>
        /// 监控项ID
        ///</summary>
        public long? MetricId{ get; set; }
        ///<summary>
        /// 监控项名称
        ///</summary>
        public string MetricName{ get; set; }
        ///<summary>
        /// NoticeLevel
        ///</summary>
        public NoticeLevel NoticeLevel{ get; set; }
        ///<summary>
        /// 通知周期
        ///</summary>
        public long? NoticePeriod{ get; set; }
        ///<summary>
        /// 报警比较符，只能为以下几种lte(&lt;&#x3D;),lt(&lt;),gt(&gt;),gte(&gt;&#x3D;),eq(&#x3D;&#x3D;),ne(!&#x3D;)
        ///</summary>
        public string Operation{ get; set; }
        ///<summary>
        /// 统计周期（单位：分钟）
        ///</summary>
        public long? Period{ get; set; }
        ///<summary>
        /// 规则类型
        ///</summary>
        public long? RuleType{ get; set; }
        ///<summary>
        /// 规则所属资源类型
        ///</summary>
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 监控项附属信息
        ///</summary>
        public string Tag{ get; set; }
        ///<summary>
        /// 多值标签
        ///</summary>
        public Dictionary<string,string> Tags{ get; set; }
        ///<summary>
        /// 阈值
        ///</summary>
        public double? Threshold{ get; set; }
        ///<summary>
        /// 连续多少次后报警
        ///</summary>
        public long? Times{ get; set; }
        ///<summary>
        /// UpdateTime
        ///</summary>
        public DateTime? UpdateTime{ get; set; }
    }
}
