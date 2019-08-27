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

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Redis.Model
{

    /// <summary>
    ///  慢查询日志记录
    /// </summary>
    public class SlowLog
    {

        ///<summary>
        /// 命令
        ///Required:true
        ///</summary>
        [Required]
        public string Command{ get; set; }
        ///<summary>
        /// 命令开始执行时间（ISO 8601标准的UTC时间，格式为：YYYY-MM-DDTHH:mm:ssZ）
        ///Required:true
        ///</summary>
        [Required]
        public DateTime StartTime{ get; set; }
        ///<summary>
        /// 命令执行时长（带单位）
        ///Required:true
        ///</summary>
        [Required]
        public string ExecutionTime{ get; set; }
        ///<summary>
        /// 执行命令的分片id
        ///</summary>
        public string ShardId{ get; set; }
    }
}
