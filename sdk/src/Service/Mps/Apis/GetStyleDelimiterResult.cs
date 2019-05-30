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
 * Image-Style-Delimiter-API
 * 图片样式分隔符API
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

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Mps.Apis
{

    /// <summary>
    ///  获取bucket的图片样式分隔符配置
    /// </summary>
    public class GetStyleDelimiterResult : JdcloudResult
    {
        ///<summary>
        /// 图片样式分隔符配置（JSON数组）；支持的分隔符包含：[&quot;-&quot;, &quot;_&quot;, &quot;/&quot;, &quot;!&quot;]
        ///Required:true
        ///</summary>
        [Required]
        public List<string> Delimiters{ get; set; }

    }
}