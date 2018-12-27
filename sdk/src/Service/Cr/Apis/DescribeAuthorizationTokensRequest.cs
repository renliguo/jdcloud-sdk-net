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
 * Authentication
 * 用户认证相关接口
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

using JDCloudSDK.Common.Model;
using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Cr.Apis
{

    /// <summary>
    ///  &lt;p&gt;批量查询令牌。&lt;/p&gt; 
        ///         /// &lt;p&gt;暂时不支持分页和过滤条件。&lt;/p&gt;
        ///         /// 
    /// </summary>
    public class DescribeAuthorizationTokensRequest : JdcloudRequest
    {
        ///<summary>
        /// token - 令牌 ID，支持多个
        /// 
        ///</summary>
        public List<Filter> Filters{ get; set; }

        ///<summary>
        /// 页码；默认为1
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 分页大小；默认为20；取值范围[10, 100]
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 地域 ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// 注册表名称
        ///Required:true
        ///</summary>
        [Required]
        public   string RegistryName{ get; set; }
    }
}