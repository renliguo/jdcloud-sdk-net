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
    ///  describeAlarmHistoryDetail
    /// </summary>
    public class DescribeAlarmHistoryDetail
    {

        ///<summary>
        /// 报警规则ID
        ///</summary>
        public string AlarmId{ get; set; }
        ///<summary>
        /// 资源维度
        ///</summary>
        public Dictionary<String,string> Dimension{ get; set; }
        ///<summary>
        /// 告警持续次数
        ///</summary>
        public long? DurationTimes{ get; set; }
        ///<summary>
        /// 命名空间
        ///</summary>
        public string Namespace{ get; set; }
        ///<summary>
        /// 命名空间名称
        ///</summary>
        public string NamespaceName{ get; set; }
        ///<summary>
        /// 告警持续时间，单位分钟
        ///</summary>
        public long? NoticeDurationTime{ get; set; }
        ///<summary>
        /// 触发的告警级别。从低到高分别为‘common’, ‘critical’, ‘fatal’
        ///</summary>
        public string NoticeLevelTriggered{ get; set; }
        ///<summary>
        /// 告警时间
        ///</summary>
        public DateTime? NoticeTime{ get; set; }
        ///<summary>
        /// 告警通知人
        ///</summary>
        public List<NoticeReceiver> Receivers{ get; set; }
        ///<summary>
        /// 规则绑定资源所在地域
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// Rule
        ///</summary>
        public CustomRuleDetail Rule{ get; set; }
        ///<summary>
        /// 告警类型  1-告警恢复  2-告警 4-数据不足
        ///</summary>
        public long? Status{ get; set; }
        ///<summary>
        /// 告警值
        ///</summary>
        public double? Value{ get; set; }
    }
}
