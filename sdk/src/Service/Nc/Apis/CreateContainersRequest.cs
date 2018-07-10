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

using JDCloudSDK.Nc.Model;
using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Nc.Apis
{

    /// <summary>
    /// 创建一台或多台指定配置的实例
    /// </summary>
    public class CreateContainersRequest : JdcloudRequest
    {
        ///<summary>
        ///创建容器规格
        ///</summary>
        public   ContainerSpec ContainerSpec{ get; set; }
        ///<summary>
        ///购买实例数量；取值范围：[1,100]
        ///</summary>
        public   int? MaxCount{ get; set; }
        ///<summary>
        ///Region ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}