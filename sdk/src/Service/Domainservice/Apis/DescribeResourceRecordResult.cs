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
 * 解析记录
 * 云解析OpenAPI解析记录接口
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
    ///  查询主域名的解析记录。  
        ///         /// 在使用解析记录相关的接口之前，请调用此接口获取解析记录的列表。
        ///         /// 
    /// </summary>
    public class DescribeResourceRecordResult : JdcloudResult
    {
        ///<summary>
        /// 解析记录列表
        ///</summary>
        public List<RRInfo> DataList{ get; set; }

        ///<summary>
        /// 所有解析记录的个数
        ///</summary>
        public   int? TotalCount{ get; set; }
        ///<summary>
        /// 所有解析记录的页数
        ///</summary>
        public   int? TotalPage{ get; set; }
        ///<summary>
        /// 当前页解析记录的个数
        ///</summary>
        public   int? CurrentCount{ get; set; }
    }
}