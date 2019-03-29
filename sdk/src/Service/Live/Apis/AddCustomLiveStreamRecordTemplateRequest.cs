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
    ///  添加用户自定义直播录制模板
        ///         /// 
    /// </summary>
    public class AddCustomLiveStreamRecordTemplateRequest : JdcloudRequest
    {
        ///<summary>
        /// 自动录制周期
        /// - 取值: [15,360]
        /// - 单位: 分钟
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   int RecordPeriod{ get; set; }
        ///<summary>
        /// 存储桶
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   string SaveBucket{ get; set; }
        ///<summary>
        /// endpoint
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   string SaveEndpoint{ get; set; }
        ///<summary>
        /// 录制文件格式:
        /// - 取值: ts,flv,mp4 (多种类型之间用;隔开)
        /// - 不区分大小写
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   string RecordFileType{ get; set; }
        ///<summary>
        /// 录制模板自定义名称:
        ///  - 取值要求：数字、大小写字母或短横线(&quot;-&quot;)
        ///  - &lt;b&gt;注意: 不能与已定义命名重复&lt;/b&gt;
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   string Template{ get; set; }
    }
}