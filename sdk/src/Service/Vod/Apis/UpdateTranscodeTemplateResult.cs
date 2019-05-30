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
 * Transcode Template
 * 模板管理 - 视频转码模板
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

using JDCloudSDK.Vod.Model;

namespace  JDCloudSDK.Vod.Apis
{

    /// <summary>
    ///  修改转码模板
    /// </summary>
    public class UpdateTranscodeTemplateResult : JdcloudResult
    {
        ///<summary>
        /// 模板ID
        ///</summary>
        public   long? Id{ get; set; }
        ///<summary>
        /// 模板名称
        ///</summary>
        public   string Name{ get; set; }
        ///<summary>
        /// 视频参数
        ///</summary>
        public   Video Video{ get; set; }
        ///<summary>
        /// 音频参数
        ///</summary>
        public   Audio Audio{ get; set; }
        ///<summary>
        /// 封装配置
        ///</summary>
        public   Encapsulation Encapsulation{ get; set; }
        ///<summary>
        /// 清晰度规格
        ///</summary>
        public   string Definition{ get; set; }
        ///<summary>
        /// 模板来源
        ///</summary>
        public   string Source{ get; set; }
        ///<summary>
        /// CreateTime
        ///</summary>
        public   DateTime? CreateTime{ get; set; }
        ///<summary>
        /// UpdateTime
        ///</summary>
        public   DateTime? UpdateTime{ get; set; }
    }
}