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


namespace JDCloudSDK.Domainservice.Model
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
        /// 创建时间，格式Unix timestamp，时间单位：毫秒
        ///</summary>
        public long? CreateTime{ get; set; }
        ///<summary>
        /// 过期时间，格式Unix timestamp，时间单位：毫秒
        ///</summary>
        public long? ExpirationDate{ get; set; }
        ///<summary>
        /// 套餐类型，免费:0 企业版:1 企业高级版:2
        ///</summary>
        public int? PackId{ get; set; }
        ///<summary>
        /// 套餐的名字
        ///</summary>
        public string PackName{ get; set; }
        ///<summary>
        /// 解析的状态, 暂无解析:1，正常解析:2， 部分解析:3， 暂停解析:4 NS未修改:5，域名探测错误:7，域名未注册:8，注册局暂停解析:9
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
        ///<summary>
        /// 域名的锁定状态，0:未锁定， 1:已锁定
        ///</summary>
        public int? LockStatus{ get; set; }
        ///<summary>
        /// 主域名当前的Nameserver列表
        ///</summary>
        public List<string> ProbeNsList{ get; set; }
        ///<summary>
        /// 主域名应该设置的Nameserver列表
        ///</summary>
        public List<string> DefNsList{ get; set; }
    }
}
