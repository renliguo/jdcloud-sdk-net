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


namespace JDCloudSDK.Mps.Model
{

    /// <summary>
    ///  转码任务信息
    /// </summary>
    public class TranscodeTaskInfo
    {

        ///<summary>
        /// 作业ID
        ///</summary>
        public string JobId{ get; set; }
        ///<summary>
        /// 任务ID
        ///</summary>
        public string TaskId{ get; set; }
        ///<summary>
        /// 输出文件 objectKey
        ///</summary>
        public string ObjectKey{ get; set; }
        ///<summary>
        /// 输出视频格式
        ///</summary>
        public string Format{ get; set; }
        ///<summary>
        /// 输出画面宽度
        ///</summary>
        public string Width{ get; set; }
        ///<summary>
        /// 输出画面高度
        ///</summary>
        public string Height{ get; set; }
        ///<summary>
        /// 输出码率
        ///</summary>
        public string Bitrate{ get; set; }
        ///<summary>
        /// 输出帧率
        ///</summary>
        public string Framerate{ get; set; }
        ///<summary>
        /// 输出清晰度
        ///</summary>
        public string Definition{ get; set; }
        ///<summary>
        /// 任务状态。in-process, succeeded, failed
        /// 
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 任务结束时间
        ///</summary>
        public DateTime? FinishTime{ get; set; }
    }
}
