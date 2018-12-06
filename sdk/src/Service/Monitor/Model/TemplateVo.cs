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


namespace JDCloudSDK.Monitor.Model
{

    /// <summary>
    ///  templateVo
    /// </summary>
    public class TemplateVo
    {

        ///<summary>
        /// CreateTime
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 模板描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 用户
        ///</summary>
        public string Pin{ get; set; }
        ///<summary>
        /// 模板内包含的规则数量
        ///</summary>
        public long? RulesCount{ get; set; }
        ///<summary>
        /// 模板所属资源类型
        ///</summary>
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 模板id
        ///</summary>
        public long? TemplateId{ get; set; }
        ///<summary>
        /// 模板名称
        ///</summary>
        public string TemplateName{ get; set; }
        ///<summary>
        /// 模板内包含的规则
        ///</summary>
        public List<AlarmVo> TemplateRules{ get; set; }
        ///<summary>
        /// 模板内包含的提供给前端的拼接好的规则
        ///</summary>
        public List<string> TemplateRulesString{ get; set; }
        ///<summary>
        /// 模板类型，区分默认模板和用户自定义模板：1表示默认模板，2表示用户自定义模板
        ///</summary>
        public long? TemplateType{ get; set; }
        ///<summary>
        /// UpdateTime
        ///</summary>
        public DateTime? UpdateTime{ get; set; }
    }
}
