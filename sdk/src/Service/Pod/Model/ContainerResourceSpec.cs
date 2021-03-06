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
 * 
 * 
 *
 * 
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Pod.Model
{

    /// <summary>
    ///  pod 中容器的计算资源配置。
        /// - resources 中，limit 和 request 不传，继续使用原有大小，建议调整实例类型同时调整 resources；
        /// - resources 中，request不传且原有的 request &#x3D; 0 时，request仍为 0；limit不传且原有limit为flavor最大值时，调整limit为新flavor最大值；
        /// - 无论是否扩、缩容，调整后的 containerResources 不可超过实例类型限制。
        /// 
    /// </summary>
    public class ContainerResourceSpec
    {

        ///<summary>
        /// 容器名称
        ///Required:true
        ///</summary>
        [Required]
        public string Name{ get; set; }
        ///<summary>
        /// 容器计算资源配置
        ///Required:true
        ///</summary>
        [Required]
        public ResourceRequestsSpec Resources{ get; set; }
    }
}
