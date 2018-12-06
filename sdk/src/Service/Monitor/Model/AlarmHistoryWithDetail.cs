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
    ///  alarmHistoryWithDetail
    /// </summary>
    public class AlarmHistoryWithDetail
    {

        ///<summary>
        /// 告警联系人
        ///</summary>
        public List<DescribedNoticeContacts> Contacts{ get; set; }
        ///<summary>
        /// 用于前端显示的‘触发告警级别’。从低到高分别为‘普通’, ‘紧急’, ‘严重’
        ///</summary>
        public string NoticeLevel{ get; set; }
        ///<summary>
        /// noticeTime
        ///</summary>
        public long? NoticeTime{ get; set; }
        ///<summary>
        /// Rule
        ///</summary>
        public Rule Rule{ get; set; }
        ///<summary>
        /// 告警值
        ///</summary>
        public double? Value{ get; set; }
    }
}
