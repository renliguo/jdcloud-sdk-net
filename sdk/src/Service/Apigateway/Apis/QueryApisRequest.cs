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
 * API
 * 关于api操作的相关接口
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
using Newtonsoft.Json;

namespace  JDCloudSDK.Apigateway.Apis
{

    /// <summary>
    ///  查询api列表
    /// </summary>
    public class QueryApisRequest : JdcloudRequest
    {
        ///<summary>
        /// 页码, 默认为1, 取值范围：[1,∞)
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 分页大小，默认为20，取值范围：[10,100]
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// apiName - API名称，模糊匹配，支持单个
        /// action - 动作，精确匹配，支持多个
        /// backServiceType- 后端服务类型，精确匹配，支持多个
        /// path - 路径，模糊匹配，支持单个
        /// description - 描述，模糊匹配，支持单个
        /// isApiProduct - 是否API产品，精确匹配，1为是
        /// 
        ///</summary>
        public List<JDCloudSDK.Common.Model.Filter> Filters{ get; set; }

        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 分组ID
        ///Required:true
        ///</summary>
        [Required]
        public   string ApiGroupId{ get; set; }
        ///<summary>
        /// 版本号
        ///Required:true
        ///</summary>
        [Required]
        public   string Revision{ get; set; }
    }
}