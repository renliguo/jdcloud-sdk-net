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


namespace JDCloudSDK.Detection.Model
{

    /// <summary>
    ///  siteMonitorDnsOption
    /// </summary>
    public class SiteMonitorDnsOption
    {

        ///<summary>
        /// DNS查询类型，可选值：A、MX、NS、CNAME、TXT、ANY，不填默认为A
        ///</summary>
        public string CheckType{ get; set; }
        ///<summary>
        /// 期望解析别名，多个之间用逗号,分割
        ///</summary>
        public string ExpectAlias{ get; set; }
        ///<summary>
        /// 期望解析ip，多个之间用逗号,分割
        ///</summary>
        public string ExpectIP{ get; set; }
        ///<summary>
        /// DNS服务器
        ///</summary>
        public string Server{ get; set; }
        ///<summary>
        /// Timeout
        ///</summary>
        public long? Timeout{ get; set; }
    }
}