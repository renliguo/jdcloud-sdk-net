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

namespace JDCloudSDK.Clouddnsservice.Model
{

    /// <summary>
    ///  delViewIP
    /// </summary>
    public class DelViewIP
    {

        ///<summary>
        /// 域名ID
        ///Required:true
        ///</summary>
        [Required]
        public int DomainId{ get; set; }
        ///<summary>
        /// 自定义线路ID
        ///Required:true
        ///</summary>
        [Required]
        public int ViewId{ get; set; }
        ///<summary>
        /// 自定义线路名称, 最多64个字符
        ///Required:true
        ///</summary>
        [Required]
        public string ViewName{ get; set; }
        ///<summary>
        /// 此线路需要删除的ip段。&lt;br&gt;
        /// ip段支持1.2.3.4-5.6.7.8和1.2.3.4/16两种格式。    
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public List<string> IpRanges{ get; set; }
    }
}
