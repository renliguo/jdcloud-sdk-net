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
    ///  添加直播应用名
        ///         /// - 需要提前在应用(app)级别绑定功能模板时才需要提前新建应用名
        ///         /// - 新的应用名可以推流时自动创建
        ///         /// 
    /// </summary>
    public class AddLiveAppRequest : JdcloudRequest
    {
        ///<summary>
        /// 直播的推流域名
        ///Required:true
        ///</summary>
        [Required]
        public   string PublishDomain{ get; set; }
        ///<summary>
        /// 应用名称
        /// - 取值: 数字字母中划线(&quot;-&quot;)下划线(&quot;_&quot;) 50个字符以内
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   string AppName{ get; set; }
    }
}