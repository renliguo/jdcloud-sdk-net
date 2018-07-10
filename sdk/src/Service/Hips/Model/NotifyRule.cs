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


namespace JDCloudSDK.Hips.Model
{

    /// <summary>
    /// notifyRule
    /// </summary>
    public class NotifyRule
    {

        ///<summary>
        ///标识
        ///</summary>
        public long? RuleId{ get; set; }
        ///<summary>
        ///告警监控项
        ///</summary>
        public string Item{ get; set; }
        ///<summary>
        ///发送规则
        ///</summary>
        public string RuleDesc{ get; set; }
        ///<summary>
        ///发送频率
        ///</summary>
        public string SendFrquency{ get; set; }
        ///<summary>
        ///发送方式。1为站内信，2为邮件，3为短信。
        ///</summary>
        public int? SendWay{ get; set; }
        ///<summary>
        ///发送时间方式。 0为8点到20点，1为24小时。
        ///</summary>
        public int? SendTime{ get; set; }
        ///<summary>
        ///启用/禁用
        ///</summary>
        public int? Enabled{ get; set; }
    }
}
