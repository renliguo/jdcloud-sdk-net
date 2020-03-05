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
 * es定时创建删除索引接口
 * 支持针对索引模板每天、每周或每月定时创建索引；支持定期删除索引。
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

namespace  JDCloudSDK.Es.Apis
{

    /// <summary>
    ///  查询实例索引模板定时任务列表
    /// </summary>
    public class DescribeIndexTemplateCronTasksRequest : JdcloudRequest
    {
        ///<summary>
        /// 页码，默认1
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 分页大小，默认10
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 过滤条件：
        /// templateName - 索引模板名称，模糊匹配，支持单个
        /// 
        ///</summary>
        public List<JDCloudSDK.Common.Model.Filter> Filters{ get; set; }

        ///<summary>
        /// regionId
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 实例ID
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
    }
}