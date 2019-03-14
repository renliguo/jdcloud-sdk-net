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
    ///  pod 绑定弹性公网 IP，绑定的是主网卡、主内网IP对应的弹性IP. &lt;br&gt;
        ///         /// 一个 pod 只能绑定一个弹性公网 IP(主网卡)，若主网卡已存在弹性公网IP，会返回错误。&lt;br&gt;
        ///         /// 如果是黑名单中的用户，会返回错误。
        ///         /// 
    /// </summary>
    public class AssociateElasticIpResult : JdcloudResult
    {
    }
}