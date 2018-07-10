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
 * Ip高防攻击记录相关接口
 * Ip高防攻击记录相关接口
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

using JDCloudSDK.Ipanti.Model;

namespace  JDCloudSDK.Ipanti.Apis
{

    /// <summary>
    /// 查询DDos攻击日志
    /// </summary>
    public class DescribeDDosAttackLogsResult : JdcloudResult
    {
        ///<summary>
        ///DataList
        ///</summary>
        public List<DDosAttackLog> DataList{ get; set; }

        ///<summary>
        ///TotalCount
        ///</summary>
        public   int? TotalCount{ get; set; }
    }
}