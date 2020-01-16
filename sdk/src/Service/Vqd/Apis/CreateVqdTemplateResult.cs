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
 * Vqd Template
 * 视频质检模板管理相关接口
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


namespace  JDCloudSDK.Vqd.Apis
{

    /// <summary>
    ///  创建视频质检模板
    /// </summary>
    public class CreateVqdTemplateResult : JdcloudResult
    {
        ///<summary>
        /// 模板ID
        ///</summary>
        public   string TemplateId{ get; set; }
        ///<summary>
        /// 模板名称。长度不超过128个字符。UTF-8编码。
        /// 
        ///</summary>
        public   string TemplateName{ get; set; }
        ///<summary>
        /// 缺陷判定时间阈值
        ///</summary>
        public   double? Threshold{ get; set; }
        ///<summary>
        /// 检测项列表
        ///</summary>
        public List<string> Detections{ get; set; }

        ///<summary>
        /// 创建时间
        ///</summary>
        public   DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 修改时间
        ///</summary>
        public   DateTime? UpdateTime{ get; set; }
    }
}