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
 * 操作列表
 * 云解析OpenAPI操作列表接口
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

namespace  JDCloudSDK.Clouddnsservice.Apis
{

    /// <summary>
    ///  查看用户在云解析服务下的操作记录
    /// </summary>
    public class GetActionLogRequest : JdcloudRequest
    {
        ///<summary>
        /// 分页参数，页的序号，默认是1
        ///Required:true
        ///</summary>
        [Required]
        public   int PageNumber{ get; set; }
        ///<summary>
        /// 分页参数，每页含有的结果的数目，默认是10
        ///Required:true
        ///</summary>
        [Required]
        public   int PageSize{ get; set; }
        ///<summary>
        /// 记录的起始时间，格式：UTC时间例如2017-11-10T23:00:00Z
        ///Required:true
        ///</summary>
        [Required]
        public   string StartTime{ get; set; }
        ///<summary>
        /// 记录的终止时间，格式：UTC时间例如2017-11-10T23:00:00Z
        ///Required:true
        ///</summary>
        [Required]
        public   string EndTime{ get; set; }
        ///<summary>
        /// 日志需要匹配的关键词
        ///</summary>
        public   string KeyWord{ get; set; }
        ///<summary>
        /// 日志里面的结果是成功还是失败
        ///</summary>
        public   bool Success{ get; set; }
        ///<summary>
        /// 日志的类型
        ///</summary>
        public   int? Type{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}