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

namespace JDCloudSDK.Kubernetes.Model
{

    /// <summary>
    ///  描述配置信息
    /// </summary>
    public class LabelSpec
    {

        ///<summary>
        /// key包含两个部分：prefix与name，name是必须的，prefix是可选的。prefix与name分隔用&quot;/&quot;。 
        /// name 可以是字母，数字，[-_.]。长度小于63。prefix：遵循DNS标准（例如：kubernetes.io/），长度不超过253 
        /// [参照](https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set)    
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public string Key{ get; set; }
        ///<summary>
        /// 字母，数字,[-_.],长度不超过63
        ///</summary>
        public string Value{ get; set; }
    }
}
