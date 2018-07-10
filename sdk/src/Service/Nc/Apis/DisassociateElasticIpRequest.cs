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
 * 容器服务
 * 关于容器服务相前接口
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

namespace  JDCloudSDK.Nc.Apis
{

    /// <summary>
    /// 容器解绑公网IP 解绑的是主网卡、主内网IP对应的弹性IP
    /// </summary>
    public class DisassociateElasticIpRequest : JdcloudRequest
    {
        ///<summary>
        ///弹性IP ID
        ///Required:true
        ///</summary>
        [Required]
        public   string ElasticIpId{ get; set; }
        ///<summary>
        ///Region ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        ///Container ID
        ///Required:true
        ///</summary>
        [Required]
        public   string ContainerId{ get; set; }
    }
}