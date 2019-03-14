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
 * Live-Video
 * 直播管理API
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

namespace  JDCloudSDK.Live.Apis
{

    /// <summary>
    ///  删除APP水印配置
    /// </summary>
    public class DeleteLiveStreamAppWatermarkRequest : JdcloudRequest
    {
        ///<summary>
        /// 推流加速域名
        ///Required:true
        ///</summary>
        [Required]
        public   string PublishDomain{ get; set; }
        ///<summary>
        /// 直播流所属应用名称
        ///Required:true
        ///</summary>
        [Required]
        public   string AppName{ get; set; }
        ///<summary>
        /// 水印模板自定义名称:
        ///   - 标准质量模板：sd、hd、hsd
        ///   - 自定义模板: 枚举类型校验，忽略大小写，自动删除空格,
        ///               取值要求：数字、大小写字母或短横线(&quot;-&quot;),
        ///               首尾不能有特殊字符(&quot;-&quot;)
        ///   - &lt;b&gt;注意: 不能与标准的转码模板和已定义命名重复&lt;/b&gt;
        ///Required:true
        ///</summary>
        [Required]
        public   string Template{ get; set; }
    }
}