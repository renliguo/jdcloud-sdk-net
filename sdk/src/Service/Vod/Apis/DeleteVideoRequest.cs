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
 * Video
 * 视频资源管理相关接口
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

namespace  JDCloudSDK.Vod.Apis
{

    /// <summary>
    ///  删除视频，调用该接口会同时删除与指定视频相关的所有信息，包括转码任务信息、转码流数据等，同时清除云存储中相关文件资源。
    /// </summary>
    public class DeleteVideoRequest : JdcloudRequest
    {
        ///<summary>
        /// 视频ID
        ///Required:true
        ///</summary>
        [Required]
        public   string VideoId{ get; set; }
    }
}