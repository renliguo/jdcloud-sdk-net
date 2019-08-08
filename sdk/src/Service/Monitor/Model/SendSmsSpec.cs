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
    ///  sendSmsSpec
    /// </summary>
    public class SendSmsSpec
    {

        ///<summary>
        /// Contacts
        ///Required:true
        ///</summary>
        [Required]
        public Contacts Contacts{ get; set; }
        ///<summary>
        /// 短信模板Id
        ///Required:true
        ///</summary>
        [Required]
        public long TemplateId{ get; set; }
        ///<summary>
        /// 短信模板参数
        ///Required:true
        ///</summary>
        [Required]
        public List<string> TemplateParam{ get; set; }
    }
}
