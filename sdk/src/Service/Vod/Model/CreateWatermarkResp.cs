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
 * Watermark Management
 * 水印管理
 *
 * OpenAPI spec version: v1
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
    ///  创建水印响应信息
    /// </summary>
    public class CreateWatermarkResp
    {

        ///<summary>
        /// 水印ID
        ///</summary>
        public long? Id{ get; set; }
        ///<summary>
        /// 水印名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 图片地址
        ///</summary>
        public string ImgUrl{ get; set; }
        ///<summary>
        /// 宽度
        ///</summary>
        public int? Width{ get; set; }
        ///<summary>
        /// 高度
        ///</summary>
        public int? Height{ get; set; }
        ///<summary>
        /// 水印位置
        ///</summary>
        public string Position{ get; set; }
        ///<summary>
        /// 偏移单位
        ///</summary>
        public string Unit{ get; set; }
        ///<summary>
        /// 水平偏移
        ///</summary>
        public int? OffsetX{ get; set; }
        ///<summary>
        /// 竖直偏移
        ///</summary>
        public int? OffsetY{ get; set; }
        ///<summary>
        /// CreateTime
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// UpdateTime
        ///</summary>
        public DateTime? UpdateTime{ get; set; }
    }
}
