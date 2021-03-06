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


namespace  JDCloudSDK.Vod.Apis
{

    /// <summary>
    ///  刷新视频上传地址和凭证
    /// </summary>
    public class RefreshVideoUploadTaskResult : JdcloudResult
    {
        ///<summary>
        /// 视频ID
        ///</summary>
        public   string VideoId{ get; set; }
        ///<summary>
        /// 上传地址
        ///</summary>
        public   string UploadUrl{ get; set; }
        ///<summary>
        /// 上传凭证
        ///</summary>
        public   string AuthToken{ get; set; }
    }
}