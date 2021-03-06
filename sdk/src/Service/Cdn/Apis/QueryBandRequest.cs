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
 * 统计查询类接口
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


namespace  JDCloudSDK.Cdn.Apis
{

    /// <summary>
    ///  带宽查询接口
    /// </summary>
    public class QueryBandRequest : JdcloudRequest
    {
        ///<summary>
        /// 查询起始时间,UTC时间，格式为:yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，示例:2018-10-21T10:00:00Z
        ///</summary>
        public   string StartTime{ get; set; }
        ///<summary>
        /// 查询截止时间,UTC时间，格式为:yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，示例:2018-10-21T10:00:00Z
        ///</summary>
        public   string EndTime{ get; set; }
        ///<summary>
        /// 需要查询的域名, 必须为用户pin下有权限的域名
        ///</summary>
        public   string Domain{ get; set; }
        ///<summary>
        /// 地域
        ///</summary>
        public   string Area{ get; set; }
        ///<summary>
        /// 运营商
        ///</summary>
        public   string Isp{ get; set; }
        ///<summary>
        /// 查询周期
        ///</summary>
        public   string Period{ get; set; }
    }
}