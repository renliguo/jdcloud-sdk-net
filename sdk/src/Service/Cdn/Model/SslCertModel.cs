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


namespace JDCloudSDK.Cdn.Model
{

    /// <summary>
    ///  sslCertModel
    /// </summary>
    public class SslCertModel
    {

        ///<summary>
        /// 证书Id
        ///</summary>
        public string CertId{ get; set; }
        ///<summary>
        /// 证书名称
        ///</summary>
        public string CertName{ get; set; }
        ///<summary>
        /// 绑定域名
        ///</summary>
        public string CommonName{ get; set; }
        ///<summary>
        /// 证书类型
        ///</summary>
        public string CertType{ get; set; }
        ///<summary>
        /// 开始时间
        ///</summary>
        public DateTime? StartTime{ get; set; }
        ///<summary>
        /// 结束时间
        ///</summary>
        public DateTime? EndTime{ get; set; }
        ///<summary>
        /// 是否允许被删除,1允许,0不允许
        ///</summary>
        public int? Deletable{ get; set; }
        ///<summary>
        /// 对私钥文件使用sha256算法计算的摘要信息
        ///</summary>
        public string Digest{ get; set; }
        ///<summary>
        /// 证书别名
        ///</summary>
        public string AliasName{ get; set; }
        ///<summary>
        /// 域名
        ///</summary>
        public List<string> DnsNames{ get; set; }
        ///<summary>
        /// 是否允许被下载,0-&gt;不允许,1-&gt;允许
        ///</summary>
        public int? Downloadable{ get; set; }
    }
}
