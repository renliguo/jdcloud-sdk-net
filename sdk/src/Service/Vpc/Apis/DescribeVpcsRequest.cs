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
 * 私有网络
 * 私有网络相关接口
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

namespace  JDCloudSDK.Vpc.Apis
{

    /// <summary>
    /// 查询私有网络列表
    /// </summary>
    public class DescribeVpcsRequest : JdcloudRequest
    {
        ///<summary>
        ///页码, 默认为1, 取值范围：[1,∞), 页码超过总页数时, 显示最后一页
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        ///分页大小，默认为20，取值范围：[10,100]
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        ///vpcIds - vpc ID列表，支持多个
        ///vpcNames - vpc名称列表,支持多个
        ///
        ///</summary>
        public List<Filter> Filters{ get; set; }

        ///<summary>
        ///Region ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}