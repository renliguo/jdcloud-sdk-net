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
    ///  设置直播录制回调通知
        ///         /// 
    /// </summary>
    public class SetLiveStreamRecordNotifyConfigRequest : JdcloudRequest
    {
        ///<summary>
        /// 推流域名
        ///Required:true
        ///</summary>
        [Required]
        public   string PublishDomain{ get; set; }
        ///<summary>
        /// 录制回调通知的URL地址
        /// - 以 http:// 开头,外网可访问的地址
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   string NotifyUrl{ get; set; }
    }
}