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


namespace JDCloudSDK.Ucapi.Model
{

    /// <summary>
    /// messageSubscriptionParam
    /// </summary>
    public class MessageSubscriptionParam
    {

        ///<summary>
        ///用户pin
        ///</summary>
        public string Pin{ get; set; }
        ///<summary>
        ///消息设置id
        ///</summary>
        public long? Id{ get; set; }
        ///<summary>
        ///接收人类型 1-联系人 2-联系组
        ///</summary>
        public int? ReceiverType{ get; set; }
        ///<summary>
        ///类别code
        ///</summary>
        public string CategoryCode{ get; set; }
        ///<summary>
        ///订阅人信息
        ///</summary>
        public List<Subscription> Subscriptions{ get; set; }
    }
}
