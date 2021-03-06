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
 * SSL Certificate
 * SSL数字证书相关信息接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Ssl.Model;

namespace  JDCloudSDK.Ssl.Apis
{

    /// <summary>
    ///  查看证书详情
    /// </summary>
    public class DescribeCertResult : JdcloudResult
    {
        ///<summary>
        /// 证书Id
        ///</summary>
        public   string CertId{ get; set; }
        ///<summary>
        /// 证书名称
        ///</summary>
        public   string CertName{ get; set; }
        ///<summary>
        /// 绑定域名
        ///</summary>
        public   string CommonName{ get; set; }
        ///<summary>
        /// 证书类型
        ///</summary>
        public   string CertType{ get; set; }
        ///<summary>
        /// 签发者
        ///</summary>
        public   string Issuer{ get; set; }
        ///<summary>
        /// 开始时间
        ///</summary>
        public   DateTime? StartTime{ get; set; }
        ///<summary>
        /// 结束时间
        ///</summary>
        public   DateTime? EndTime{ get; set; }
        ///<summary>
        /// 域名
        ///</summary>
        public List<string> DnsNames{ get; set; }

        ///<summary>
        /// 对私钥文件使用sha256算法计算的摘要信息
        ///</summary>
        public   string Digest{ get; set; }
        ///<summary>
        /// 绑定信息的总数量
        ///</summary>
        public   int? TotalCount{ get; set; }
        ///<summary>
        /// 证书关联信息
        ///</summary>
        public List<CertBindInfo> UsedBy{ get; set; }

    }
}