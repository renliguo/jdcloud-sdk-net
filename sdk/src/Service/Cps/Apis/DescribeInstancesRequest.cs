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
 * 云物理服务器
 * 云物理服务器操作相关的接口
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

namespace  JDCloudSDK.Cps.Apis
{

    /// <summary>
    ///  批量查询云物理服务器详细信息&lt;br/&gt;
        ///         /// 支持分页查询，默认每页10条&lt;br/&gt;
        ///         /// 
    /// </summary>
    public class DescribeInstancesRequest : JdcloudRequest
    {
        ///<summary>
        /// 页码；默认为1
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 分页大小；默认为10；取值范围[10, 100]
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 可用区，精确匹配
        ///</summary>
        public   string Az{ get; set; }
        ///<summary>
        /// 云物理服务器名称，支持模糊匹配
        ///</summary>
        public   string Name{ get; set; }
        ///<summary>
        /// 网络类型，精确匹配，目前只支持basic
        ///</summary>
        public   string NetworkType{ get; set; }
        ///<summary>
        /// 实例类型，精确匹配，调用接口（describeDeviceTypes）获取实例类型
        ///</summary>
        public   string DeviceType{ get; set; }
        ///<summary>
        /// 云物理服务器状态，参考云物理服务器状态
        ///</summary>
        public   string Status{ get; set; }
        ///<summary>
        /// instanceId - 云物理服务器ID，精确匹配，支持多个
        /// 
        ///</summary>
        public List<JDCloudSDK.Common.Model.Filter> Filters{ get; set; }

        ///<summary>
        /// 地域ID，可调用接口（describeRegiones）获取云物理服务器支持的地域
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}