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
 * 直播域名操作类接口
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

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Cdn.Apis
{

    /// <summary>
    ///  查询用户推流域名app名/流名
    /// </summary>
    public class QueryPushDomainORAppOrStreamRequest : JdcloudRequest
    {
        ///<summary>
        /// app名，传appName查询流名列表
        ///</summary>
        public   string App{ get; set; }
        ///<summary>
        /// 流名模糊查询
        ///</summary>
        public   string Stream{ get; set; }
        ///<summary>
        /// 指定app/流名列表大小，默认50
        ///</summary>
        public   long? Limit{ get; set; }
        ///<summary>
        /// 用户域名
        ///Required:true
        ///</summary>
        [Required]
        public   string Domain{ get; set; }
    }
}