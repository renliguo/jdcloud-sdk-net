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


namespace JDCloudSDK.Clouddnsservice.Model
{

    /// <summary>
    ///  domainInfo
    /// </summary>
    public class DomainInfo
    {

        ///<summary>
        /// 域名的唯一ID
        ///</summary>
        public int? Id{ get; set; }
        ///<summary>
        /// 域名字符串
        ///</summary>
        public string DomainName{ get; set; }
        ///<summary>
        /// 创建时间，格式Unix timestamp
        ///</summary>
        public int? CreateTime{ get; set; }
        ///<summary>
        /// 过期时间，格式Unix timestamp
        ///</summary>
        public int? ExpirationDate{ get; set; }
        ///<summary>
        /// 套餐类型，0-&gt;免费 1-&gt;企业版 2-&gt;企业高级版
        ///</summary>
        public int? PackId{ get; set; }
        ///<summary>
        /// 套餐的名字
        ///</summary>
        public string PackName{ get; set; }
        ///<summary>
        /// 解析的状态
        ///</summary>
        public string ResolvingStatus{ get; set; }
        ///<summary>
        /// 创建者
        ///</summary>
        public string Creator{ get; set; }
        ///<summary>
        /// 是否是京东云资源
        ///</summary>
        public bool JcloudNs{ get; set; }
    }
}
