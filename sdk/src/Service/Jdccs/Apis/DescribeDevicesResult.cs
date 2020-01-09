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
 * Resource API
 * 云托管服务的资源API
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

using JDCloudSDK.Jdccs.Model;

namespace  JDCloudSDK.Jdccs.Apis
{

    /// <summary>
    ///  查询设备列表
    /// </summary>
    public class DescribeDevicesResult : JdcloudResult
    {
        ///<summary>
        /// 设备列表
        ///</summary>
        public List<DescribeDevice> Devices{ get; set; }

        ///<summary>
        /// 页码
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 分页大小
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 总数量
        ///</summary>
        public   int? TotalCount{ get; set; }
    }
}