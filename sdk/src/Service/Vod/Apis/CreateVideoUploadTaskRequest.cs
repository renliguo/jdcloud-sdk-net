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
 * Media Upload
 * 媒体上传相关接口
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
    ///  获取视频上传地址和凭证
    /// </summary>
    public class CreateVideoUploadTaskRequest : JdcloudRequest
    {
        ///<summary>
        /// HTTP 请求方法，取值范围：GET、POST、PUT、DELETE、HEAD、PATCH，默认值为 PUT
        ///</summary>
        public   string HttpMethod{ get; set; }
        ///<summary>
        /// 视频标题
        ///Required:true
        ///</summary>
        [Required]
        public   string Title{ get; set; }
        ///<summary>
        /// 文件名称
        ///Required:true
        ///</summary>
        [Required]
        public   string FileName{ get; set; }
        ///<summary>
        /// 文件大小
        ///</summary>
        public   long? FileSize{ get; set; }
        ///<summary>
        /// 封面地址
        ///</summary>
        public   string CoverUrl{ get; set; }
        ///<summary>
        /// 视频描述
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// 分类ID
        ///</summary>
        public   long? CategoryId{ get; set; }
        ///<summary>
        /// 视频标签集合
        ///</summary>
        public List<string> Tags{ get; set; }

        ///<summary>
        /// 转码模板ID集合
        ///</summary>
        public List<long?> TranscodeTemplateIds{ get; set; }

        ///<summary>
        /// 水印ID集合
        ///</summary>
        public List<long?> WatermarkIds{ get; set; }

    }
}