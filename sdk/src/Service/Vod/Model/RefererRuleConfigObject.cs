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

namespace JDCloudSDK.Vod.Model
{

    /// <summary>
    ///  Referer防盗链规则配置对象
    /// </summary>
    public class RefererRuleConfigObject
    {

        ///<summary>
        /// 启用策略。取值范围：
        ///   denial - 拒绝
        ///   allowance - 允许
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public string Strategy{ get; set; }
        ///<summary>
        /// Referer域名列表
        ///Required:true
        ///</summary>
        [Required]
        public List<string> Domains{ get; set; }
        ///<summary>
        /// 是否允许请求头 Referer 为空，如允许浏览器直接访问等
        ///Required:true
        ///</summary>
        [Required]
        public bool AllowBlank{ get; set; }
    }
}