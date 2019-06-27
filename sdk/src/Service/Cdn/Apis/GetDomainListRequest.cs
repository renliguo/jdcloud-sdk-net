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


namespace  JDCloudSDK.Cdn.Apis
{

    /// <summary>
    ///  查询加速域名接口
    /// </summary>
    public class GetDomainListRequest : JdcloudRequest
    {
        ///<summary>
        /// 根据关键字进行模糊匹配
        ///</summary>
        public   string KeyWord{ get; set; }
        ///<summary>
        /// pageNumber,默认值1
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// pageSize,最大值50,默认值20
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 根据域名状态查询, 可选值[offline, online, configuring, auditing, audit_reject]
        ///</summary>
        public   string Status{ get; set; }
        ///<summary>
        /// 域名类型，(web:静态小文件，download:大文件加速，vod:视频加速，live:直播加速),不传查所有
        ///</summary>
        public   string Type{ get; set; }
    }
}