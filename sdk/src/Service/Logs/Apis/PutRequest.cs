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
 * Put APIs
 * 自定义日志上报
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

using JDCloudSDK.Logs.Model;
using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Logs.Apis
{

    /// <summary>
    ///  自定义日志上报。
    /// </summary>
    public class PutRequest : JdcloudRequest
    {
        ///<summary>
        /// 全局 strean 日志流标识符（建议起能唯一界定一个文件的名字，如 /i-iqnvqpinkjiq/app.log），不传则写入default日志流中（会导致很多文件混合在一起，不推荐）
        ///</summary>
        public   string Stream{ get; set; }
        ///<summary>
        /// 全局时间戳，UTC格式，最多支持到纳秒级别，不传入则取服务器时间。如 2019-04-08T03:08:04.437670934Z、2019-04-08T03:08:04Z、2019-04-08T03:08:04.123Z
        ///</summary>
        public   string Timestamp{ get; set; }
        ///<summary>
        /// 全局标签 map[string]string
        ///</summary>
        public   object Tags{ get; set; }
        ///<summary>
        /// 日志数据
        ///Required:true
        ///</summary>
        [Required]
        public List<Entry> Entries{ get; set; }

        ///<summary>
        /// 日志主题uid
        ///Required:true
        ///</summary>
        [Required]
        public   string LogtopicUID{ get; set; }
    }
}