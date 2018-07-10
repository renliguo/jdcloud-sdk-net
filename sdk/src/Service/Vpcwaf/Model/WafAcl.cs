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


namespace JDCloudSDK.Vpcwaf.Model
{

    /// <summary>
    /// wafAcl
    /// </summary>
    public class WafAcl
    {

        ///<summary>
        ///拦截规则ID
        ///</summary>
        public string AclRuleId{ get; set; }
        ///<summary>
        ///规则名称
        ///</summary>
        public string AclRuleName{ get; set; }
        ///<summary>
        ///攻击源ip
        ///</summary>
        public string AclIp{ get; set; }
        ///<summary>
        ///攻击URL
        ///</summary>
        public string AclUrl{ get; set; }
        ///<summary>
        ///请求方式
        ///</summary>
        public string AclMethod{ get; set; }
        ///<summary>
        ///攻击时间
        ///</summary>
        public string AclDatetime{ get; set; }
    }
}
