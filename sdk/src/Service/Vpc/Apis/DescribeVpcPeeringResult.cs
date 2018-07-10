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
 * 对等连接
 * 对等连接相关接口
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

using JDCloudSDK.Vpc.Model;

namespace  JDCloudSDK.Vpc.Apis
{

    /// <summary>
    /// 查询VpcPeering资源详情
    /// </summary>
    public class DescribeVpcPeeringResult : JdcloudResult
    {
        ///<summary>
        ///VpcPeering资源信息
        ///</summary>
        public   VpcPeering VpcPeering{ get; set; }
    }
}