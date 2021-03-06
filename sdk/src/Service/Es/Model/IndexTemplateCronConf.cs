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

namespace JDCloudSDK.Es.Model
{

    /// <summary>
    ///  indexTemplateCronConf
    /// </summary>
    public class IndexTemplateCronConf
    {

        ///<summary>
        /// 索引模板名称
        ///Required:true
        ///</summary>
        [Required]
        public string TemplateName{ get; set; }
        ///<summary>
        /// 任务起始执行时间，遵循ISO8601标准，使用UTC时间，格式为：YYYY-MM-DDTHH:mm:ssZ
        ///Required:true
        ///</summary>
        [Required]
        public DateTime BeginTime{ get; set; }
        ///<summary>
        /// 任务执行频率, day： 每天，week： 每周，month：每月
        ///Required:true
        ///</summary>
        [Required]
        public string Cycle{ get; set; }
        ///<summary>
        /// 索引前缀
        ///Required:true
        ///</summary>
        [Required]
        public string IndexPrefix{ get; set; }
        ///<summary>
        /// 索引后缀格式, &quot;yyyy-MM-dd&quot;, &quot;yyyy.MM.dd&quot;, &quot;yyyy_MM_dd&quot;, &quot;yyyyMMdd&quot;, &quot;yyyyww&quot;, &quot;yyyy-MM&quot;, &quot;yyyy.MM&quot;, &quot;yyyy_MM&quot;, &quot;yyyyMM&quot;
        ///Required:true
        ///</summary>
        [Required]
        public string IndexSuffixFormat{ get; set; }
        ///<summary>
        /// 提前创建索引天数
        ///Required:true
        ///</summary>
        [Required]
        public int AheadOfDay{ get; set; }
        ///<summary>
        /// 是否开启自动删除索引
        ///Required:true
        ///</summary>
        [Required]
        public bool IsAutoDelete{ get; set; }
        ///<summary>
        /// 索引保留天数, 开启自动删除索引后生效
        ///Required:true
        ///</summary>
        [Required]
        public int ReserveOfDay{ get; set; }
    }
}
