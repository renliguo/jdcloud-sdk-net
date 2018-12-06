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
 * JCloud Openapi For CDN
 * Openapi For JCLOUD cdn
 *
 * OpenAPI spec version: v1
 * Contact: pid-cdn@jd.com
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Cdn.Model;

namespace  JDCloudSDK.Cdn.Apis
{

    /// <summary>
    ///  查询TOP IP
    /// </summary>
    public class QueryStatisticsTopIpResult : JdcloudResult
    {
        ///<summary>
        /// StartTime
        ///</summary>
        public   string StartTime{ get; set; }
        ///<summary>
        /// EndTime
        ///</summary>
        public   string EndTime{ get; set; }
        ///<summary>
        /// Domain
        ///</summary>
        public   string Domain{ get; set; }
        ///<summary>
        /// IpData
        ///</summary>
        public List<StatisticsTopIpData> IpData{ get; set; }

    }
}