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
 * 相关接口
 * API related to order
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

using JDCloudSDK.Order.Model;

namespace  JDCloudSDK.Order.Apis
{

    /// <summary>
    ///  查询订单列表
    /// </summary>
    public class QueryOrdersResult : JdcloudResult
    {
        ///<summary>
        /// ResultList
        ///</summary>
        public List<OrderResponseObject> ResultList{ get; set; }

        ///<summary>
        /// TotalCount
        ///</summary>
        public   int? TotalCount{ get; set; }
        ///<summary>
        /// TotalPage
        ///</summary>
        public   int? TotalPage{ get; set; }
    }
}