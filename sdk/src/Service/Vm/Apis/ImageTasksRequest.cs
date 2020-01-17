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
 * 镜像
 * 关于主机镜像操作的相关接口
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

using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Vm.Apis
{

    /// <summary>
    ///  查询镜像导入导出任务详情
        ///         /// 
    /// </summary>
    public class ImageTasksRequest : JdcloudRequest
    {
        ///<summary>
        /// 任务种类。可选值：ImportImage， ExportImage
        ///Required:true
        ///</summary>
        [Required]
        public   string TaskAction{ get; set; }
        ///<summary>
        /// 任务id
        ///</summary>
        public List<int?> TaskIds{ get; set; }

        ///<summary>
        /// 任务状态。可选值：pending,running,failed,finished
        ///</summary>
        public   string TaskStatus{ get; set; }
        ///<summary>
        /// 任务开始时间
        ///</summary>
        public   DateTime? StartTime{ get; set; }
        ///<summary>
        /// 任务结束时间
        ///</summary>
        public   DateTime? EndTime{ get; set; }
        ///<summary>
        /// 页码；默认为1
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 分页大小；默认为20；取值范围[10, 100]
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}