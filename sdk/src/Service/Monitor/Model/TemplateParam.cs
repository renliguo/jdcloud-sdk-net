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
    ///  创建模板请求
    /// </summary>
    public class TemplateParam
    {

        ///<summary>
        /// 描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 名称
        ///Required:true
        ///</summary>
        [Required]
        public string Name{ get; set; }
        ///<summary>
        /// 模板参数信息,必须有数据源信息
        ///Required:true
        ///</summary>
        [Required]
        public List<ParamInfo> Params{ get; set; }
        ///<summary>
        /// 模板标签, map[string]string, 必须有数据源的标签,比如&quot;datasourceType&quot;:&quot;cloudmonitor&quot;
        ///Required:true
        ///</summary>
        [Required]
        public List<Dictionary<String,string>> Tags{ get; set; }
        ///<summary>
        /// 模板oss地址
        ///Required:true
        ///</summary>
        [Required]
        public string TemplateAddr{ get; set; }
        ///<summary>
        /// 模板缩略图oss地址
        ///Required:true
        ///</summary>
        [Required]
        public string ThumbnailAddr{ get; set; }
    }
}
