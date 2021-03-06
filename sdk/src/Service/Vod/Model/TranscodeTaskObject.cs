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


namespace JDCloudSDK.Vod.Model
{

    /// <summary>
    ///  获取视频转码任务信息
    /// </summary>
    public class TranscodeTaskObject
    {

        ///<summary>
        /// 任务ID
        ///</summary>
        public long? TaskId{ get; set; }
        ///<summary>
        /// 码率名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 媒体类型
        ///</summary>
        public int? MediaType{ get; set; }
        ///<summary>
        /// 状态
        ///</summary>
        public int? Status{ get; set; }
        ///<summary>
        /// 进度
        ///</summary>
        public string Progress{ get; set; }
        ///<summary>
        /// 文件大小
        ///</summary>
        public long? Size{ get; set; }
        ///<summary>
        /// 转码模板ID
        ///</summary>
        public int? TemplateId{ get; set; }
        ///<summary>
        /// 码率
        ///</summary>
        public long? Bitrate{ get; set; }
        ///<summary>
        /// 编码格式
        ///</summary>
        public string Codec{ get; set; }
        ///<summary>
        /// 封装格式
        ///</summary>
        public string Format{ get; set; }
        ///<summary>
        /// 宽度
        ///</summary>
        public int? Width{ get; set; }
        ///<summary>
        /// 高度
        ///</summary>
        public int? Height{ get; set; }
        ///<summary>
        /// 帧率
        ///</summary>
        public string Fps{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 更新时间
        ///</summary>
        public DateTime? UpdateTime{ get; set; }
    }
}
