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
 * pod
 * pod 相关接口
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


namespace  JDCloudSDK.Pod.Apis
{

    /// <summary>
    ///  pod 状态必须为 stopped、running 或 error状态。 &lt;br&gt;
        ///         /// 按量付费的实例，如不主动删除将一直运行，不再使用的实例，可通过本接口主动停用。&lt;br&gt;
        ///         /// 只能支持主动删除按量计费类型的实例。包年包月过期的 pod 也可以删除，其它的情况还请发工单系统。计费状态异常的容器无法删除。
        ///         /// 
    /// </summary>
    public class DeletePodResponse : JdcloudResponse<DeletePodResult>
    {
    }
}