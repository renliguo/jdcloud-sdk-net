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
 * 云主机
 * 与主机操作相关的接口
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

namespace  JDCloudSDK.Vm.Apis
{

    /// <summary>
    ///  云主机变更规格类型&lt;br&gt;
        ///         /// 云主机的状态必须为&lt;b&gt;stopped&lt;/b&gt;状态。&lt;br&gt;
        ///         /// 16年创建的云硬盘做系统盘的主机，一代与二代规格类型不允许相互调整。&lt;br&gt;
        ///         /// 本地盘(local类型)做系统盘的主机，一代与二代规格类型不允许相互调整。&lt;br&gt;
        ///         /// 使用高可用组(Ag)创建的主机，一代与二代规格类型不允许相互调整。&lt;br&gt;
        ///         /// 云硬盘(cloud类型)做系统盘的主机，一代与二代规格类型允许相互调整。&lt;br&gt;
        ///         /// 如果当前主机中的弹性网卡数量，大于规格类型允许的弹性网卡数量，会返回错误。可查询&lt;a href&#x3D;&quot;https://www.jdcloud.com/help/detail/2901/isCatalog/1&quot;&gt;DescribeInstanceTypes&lt;/a&gt;接口获得指定地域或可用区的规格信息。&lt;br&gt;
        ///         /// 当前主机所使用的镜像，需要支持要变更的目标规格类型，否则返回错误。可查询&lt;a href&#x3D;&quot;https://www.jdcloud.com/help/detail/2872/isCatalog/1&quot;&gt;DescribeImageConstraints&lt;/a&gt;接口获得指定镜像的规格类型限制信息。&lt;br&gt;
        ///         /// 云主机欠费时，无法更改规格类型。
        ///         /// 
    /// </summary>
    public class ResizeInstanceRequest : JdcloudRequest
    {
        ///<summary>
        /// 规格类型，可查询&lt;a href&#x3D;&quot;https://www.jdcloud.com/help/detail/2901/isCatalog/1&quot;&gt;DescribeInstanceTypes&lt;/a&gt;接口获得指定地域或可用区的规格信息。
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceType{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// 云主机ID
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
    }
}