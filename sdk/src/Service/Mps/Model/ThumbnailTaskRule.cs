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
 * 媒体处理相关接口
 * 媒体处理API
 *
 * OpenAPI spec version: 1.0.0
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
    /// 视频截图规则参数
    /// </summary>
    public class ThumbnailTaskRule
    {

        ///<summary>
        ///截图模式 单张: single 多张: multi 平均: average default: single
        ///</summary>
        public string Mode{ get; set; }
        ///<summary>
        ///是否开启关键帧截图 default: true
        ///</summary>
        public bool KeyFrame{ get; set; }
        ///<summary>
        ///生成截图的开始时间, mode&#x3D;average 时不可选. default:0
        ///</summary>
        public int? StartTimeInSecond{ get; set; }
        ///<summary>
        ///生成截图的结束时间, mode&#x3D;single/average时不可选, 且不得小于startTimeInSecond. default:-1(代表视频时长)
        ///</summary>
        public int? EndTimeInSecond{ get; set; }
        ///<summary>
        ///截图数量, mode&#x3D;single时不可选. default:1
        ///</summary>
        public int? Count{ get; set; }
    }
}
