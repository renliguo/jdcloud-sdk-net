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

namespace JDCloudSDK.Monitor.Model
{

    /// <summary>
    ///  updateTemplateRequestV2
    /// </summary>
    public class UpdateTemplateRequestV2
    {

        ///<summary>
        /// 模板描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 模板资源类型下的维度，如果该资源分维度,则必须传入此参数
        ///</summary>
        public string Dimension{ get; set; }
        ///<summary>
        /// 模板的资源类型
        ///Required:true
        ///</summary>
        [Required]
        public string Product{ get; set; }
        ///<summary>
        /// 模板名称
        ///Required:true
        ///</summary>
        [Required]
        public string TemplateName{ get; set; }
        ///<summary>
        /// 模板内包含的规则
        ///Required:true
        ///</summary>
        [Required]
        public List<BasicRule> TemplateRules{ get; set; }
        ///<summary>
        /// 模板UUID
        ///Required:true
        ///</summary>
        [Required]
        public string TemplateUuid{ get; set; }
    }
}
