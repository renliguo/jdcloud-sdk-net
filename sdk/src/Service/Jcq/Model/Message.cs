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


namespace JDCloudSDK.Jcq.Model
{

    /// <summary>
    ///  message
    /// </summary>
    public class Message
    {

        ///<summary>
        /// 消息id
        ///</summary>
        public string MessageId{ get; set; }
        ///<summary>
        /// 内容
        ///</summary>
        public string Body{ get; set; }
        ///<summary>
        /// tag以逗号隔开
        ///</summary>
        public string Tags{ get; set; }
        ///<summary>
        /// 用户设置的属性json字符串
        ///</summary>
        public string Properties{ get; set; }
        ///<summary>
        /// 消息的存储时间
        ///</summary>
        public double? StoreTime{ get; set; }
    }
}
