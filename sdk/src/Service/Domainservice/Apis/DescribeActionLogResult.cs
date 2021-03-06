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
 * OpenAPI spec version: v2
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Domainservice.Model;

namespace  JDCloudSDK.Domainservice.Apis
{

    /// <summary>
    ///  查看用户在云解析服务下的操作记录
    /// </summary>
    public class DescribeActionLogResult : JdcloudResult
    {
        ///<summary>
        /// 操作记录列表
        ///</summary>
        public List<Actionlog> DataList{ get; set; }

        ///<summary>
        /// 当前页的操作记录列表里的个数
        ///</summary>
        public   int? CurrentCount{ get; set; }
        ///<summary>
        /// 所有操作记录的个数
        ///</summary>
        public   int? TotalCount{ get; set; }
        ///<summary>
        /// 操作记录列表按照分页参数一共的页数
        ///</summary>
        public   int? TotalPage{ get; set; }
    }
}