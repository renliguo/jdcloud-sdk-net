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
 * Logset APIs
 * 日志服务日志集相关管理控制接口
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

namespace  JDCloudSDK.Logs.Apis
{

    /// <summary>
    ///  查询日志集列表。支持按照名称进行模糊查询。结果中包含了该日志集是否存在日志主题的信息。存在日志主题的日志集不允许删除。
    /// </summary>
    public class DescribeLogsetsResult : JdcloudResult
    {
        ///<summary>
        /// 日志集列表
        ///</summary>
        public List<LogsetEnd> Data{ get; set; }

        ///<summary>
        /// 总页数
        ///</summary>
        public   long? NumberPages{ get; set; }
        ///<summary>
        /// 总记录数
        ///</summary>
        public   long? NumberRecords{ get; set; }
        ///<summary>
        /// 当前页码
        ///</summary>
        public   long? PageNumber{ get; set; }
        ///<summary>
        /// 分页大小
        ///</summary>
        public   long? PageSize{ get; set; }
    }
}