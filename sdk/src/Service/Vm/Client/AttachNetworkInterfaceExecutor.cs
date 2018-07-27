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


using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Vm.Client
{

    /// <summary>
    ///  云主机挂载一块弹性网卡。&lt;br&gt;
        /// 云主机状态必须为&lt;b&gt;running&lt;/b&gt;或&lt;b&gt;stopped&lt;/b&gt;状态，并且没有正在进行中的任务才可操作。&lt;br&gt;
        /// 弹性网卡上如果绑定了公网IP，那么公网IP所在az需要与云主机的az保持一致，或者公网IP属于全可用区，才可挂载。&lt;br&gt;
        /// 云主机挂载弹性网卡的数量，不能超过实例规格的限制。可查询&lt;a href&#x3D;&quot;https://www.jdcloud.com/help/detail/2901/isCatalog/1&quot;&gt;DescribeInstanceTypes&lt;/a&gt;接口获得指定地域或可用区的规格信息。&lt;br&gt;
        /// 弹性网卡与云主机必须在相同vpc下。
        /// 
    /// </summary>
    public class AttachNetworkInterfaceExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  云主机挂载一块弹性网卡。&lt;br&gt;
        /// 云主机状态必须为&lt;b&gt;running&lt;/b&gt;或&lt;b&gt;stopped&lt;/b&gt;状态，并且没有正在进行中的任务才可操作。&lt;br&gt;
        /// 弹性网卡上如果绑定了公网IP，那么公网IP所在az需要与云主机的az保持一致，或者公网IP属于全可用区，才可挂载。&lt;br&gt;
        /// 云主机挂载弹性网卡的数量，不能超过实例规格的限制。可查询&lt;a href&#x3D;&quot;https://www.jdcloud.com/help/detail/2901/isCatalog/1&quot;&gt;DescribeInstanceTypes&lt;/a&gt;接口获得指定地域或可用区的规格信息。&lt;br&gt;
        /// 弹性网卡与云主机必须在相同vpc下。
        /// 接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "POST";
            }
        }
        /// <summary>
        ///  云主机挂载一块弹性网卡。&lt;br&gt;
        /// 云主机状态必须为&lt;b&gt;running&lt;/b&gt;或&lt;b&gt;stopped&lt;/b&gt;状态，并且没有正在进行中的任务才可操作。&lt;br&gt;
        /// 弹性网卡上如果绑定了公网IP，那么公网IP所在az需要与云主机的az保持一致，或者公网IP属于全可用区，才可挂载。&lt;br&gt;
        /// 云主机挂载弹性网卡的数量，不能超过实例规格的限制。可查询&lt;a href&#x3D;&quot;https://www.jdcloud.com/help/detail/2901/isCatalog/1&quot;&gt;DescribeInstanceTypes&lt;/a&gt;接口获得指定地域或可用区的规格信息。&lt;br&gt;
        /// 弹性网卡与云主机必须在相同vpc下。
        /// 接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/regions/{regionId}/instances/{instanceId}:attachNetworkInterface";
            }
        }
    }
}
