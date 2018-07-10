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


namespace JDCloudSDK.Csa.Model
{

    /// <summary>
    /// notifyContacts
    /// </summary>
    public class NotifyContacts
    {

        ///<summary>
        ///是否成功
        ///</summary>
        public bool Success{ get; set; }
        ///<summary>
        ///消息
        ///</summary>
        public string Msg{ get; set; }
        ///<summary>
        ///联系组
        ///</summary>
        public List<NotifyContactGroup> ContactGroups{ get; set; }
        ///<summary>
        ///联系人
        ///</summary>
        public List<NotifyContactPerson> ContactPersons{ get; set; }
    }
}
