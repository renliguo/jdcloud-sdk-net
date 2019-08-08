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
 * Pod
 * Pod 相关接口
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

namespace  JDCloudSDK.Pod.Apis
{

    /// <summary>
    ///  启动处于关闭状态的单个 pod ，处在任务执行中的 pod 无法启动。&lt;br&gt;
        ///         /// pod 实例或其绑定的云盘已欠费时，容器将无法正常启动。&lt;br&gt;
        ///         /// 
    /// </summary>
    public class StartPodRequest : JdcloudRequest
    {
        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// Pod ID
        ///Required:true
        ///</summary>
        [Required]
        public   string PodId{ get; set; }
    }
}