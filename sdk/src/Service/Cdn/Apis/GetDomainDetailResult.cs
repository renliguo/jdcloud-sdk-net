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
 * JCloud Openapi For CDN
 * Openapi For JCLOUD cdn
 *
 * OpenAPI spec version: v1
 * Contact: pid-cdn@jd.com
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Cdn.Model;

namespace  JDCloudSDK.Cdn.Apis
{

    /// <summary>
    ///  查询加速域名详情
    /// </summary>
    public class GetDomainDetailResult : JdcloudResult
    {
        ///<summary>
        /// AllStatus
        ///</summary>
        public   string AllStatus{ get; set; }
        ///<summary>
        /// AllowNoReferHeader
        ///</summary>
        public   string AllowNoReferHeader{ get; set; }
        ///<summary>
        /// AllowNullReferHeader
        ///</summary>
        public   string AllowNullReferHeader{ get; set; }
        ///<summary>
        /// DailyBandWidth
        ///</summary>
        public   int? DailyBandWidth{ get; set; }
        ///<summary>
        /// ForbiddenType
        ///</summary>
        public   string ForbiddenType{ get; set; }
        ///<summary>
        /// MaxFileSize
        ///</summary>
        public   long? MaxFileSize{ get; set; }
        ///<summary>
        /// MinFileSize
        ///</summary>
        public   long? MinFileSize{ get; set; }
        ///<summary>
        /// SumFileSize
        ///</summary>
        public   long? SumFileSize{ get; set; }
        ///<summary>
        /// AvgFileSize
        ///</summary>
        public   long? AvgFileSize{ get; set; }
        ///<summary>
        /// ReferList
        ///</summary>
        public List<string> ReferList{ get; set; }

        ///<summary>
        /// ReferType
        ///</summary>
        public   string ReferType{ get; set; }
        ///<summary>
        /// Domain
        ///</summary>
        public   string Domain{ get; set; }
        ///<summary>
        /// Cname
        ///</summary>
        public   string Cname{ get; set; }
        ///<summary>
        /// ArchiveNo
        ///</summary>
        public   string ArchiveNo{ get; set; }
        ///<summary>
        /// Type
        ///</summary>
        public   string Type{ get; set; }
        ///<summary>
        /// Created
        ///</summary>
        public   string Created{ get; set; }
        ///<summary>
        /// Modified
        ///</summary>
        public   string Modified{ get; set; }
        ///<summary>
        /// Status
        ///</summary>
        public   string Status{ get; set; }
        ///<summary>
        /// AuditStatus
        ///</summary>
        public   string AuditStatus{ get; set; }
        ///<summary>
        /// Source
        ///</summary>
        public   BackSourceInfo Source{ get; set; }
        ///<summary>
        /// SourceType
        ///</summary>
        public   string SourceType{ get; set; }
        ///<summary>
        /// 默认的回源host
        ///</summary>
        public   string DefaultSourceHost{ get; set; }
        ///<summary>
        /// BackSourceType
        ///</summary>
        public   string BackSourceType{ get; set; }
        ///<summary>
        /// HttpType
        ///</summary>
        public   string HttpType{ get; set; }
        ///<summary>
        /// Certificate
        ///</summary>
        public   string Certificate{ get; set; }
        ///<summary>
        /// RsaKey
        ///</summary>
        public   string RsaKey{ get; set; }
        ///<summary>
        /// JumpType
        ///</summary>
        public   string JumpType{ get; set; }
    }
}