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
 * Live API
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


namespace  JDCloudSDK.Live.Apis
{

    /// <summary>
    ///  查询转码模板详情
    /// </summary>
    public class DescribeCustomLiveStreamTranscodeResult : JdcloudResult
    {
        ///<summary>
        /// 转码输出的码率值
        ///</summary>
        public   int? VideoCodeRate{ get; set; }
        ///<summary>
        /// 转码输出的帧率值
        ///</summary>
        public   string VideoFrameRate{ get; set; }
        ///<summary>
        /// 转码输出视频宽度
        ///</summary>
        public   int? Width{ get; set; }
        ///<summary>
        /// 转码输出视频宽度
        ///</summary>
        public   int? Height{ get; set; }
        ///<summary>
        /// 转码模板自定义名称
        ///</summary>
        public   string Template{ get; set; }
        ///<summary>
        /// 转码输出音频编码格式
        ///</summary>
        public   string AudioCodec{ get; set; }
        ///<summary>
        /// 转码输出音频格式
        ///</summary>
        public   string AudioFormat{ get; set; }
        ///<summary>
        /// 转码输出音频采样率
        ///</summary>
        public   int? AudioSampleRate{ get; set; }
        ///<summary>
        /// 转码输出音频通道数
        ///</summary>
        public   int? AudioChannel{ get; set; }
        ///<summary>
        /// 转码输出音频码率
        ///</summary>
        public   int? AudioCodeRate{ get; set; }
    }
}