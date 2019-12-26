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
 * 域名
 * 云解析OpenAPI域名接口
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


namespace  JDCloudSDK.Domainservice.Apis
{

    /// <summary>
    ///  查看域名的查询流量
    /// </summary>
    public class DescribeDomainQueryTrafficResult : JdcloudResult
    {
        ///<summary>
        /// 时间序列
        ///</summary>
        public List<long?> Time{ get; set; }

        ///<summary>
        /// 数据序列的单位
        ///</summary>
        public   string Unit{ get; set; }
        ///<summary>
        /// 与时间序列对应的数据序列
        ///</summary>
        public List<double?> Traffic{ get; set; }

    }
}