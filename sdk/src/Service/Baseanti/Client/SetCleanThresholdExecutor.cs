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
 * IP Resource APIs
 * Anti DDoS Basic IP Resource APIs
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

namespace JDCloudSDK.Baseanti.Client
{

    /// <summary>
    ///  设置基础防护已防护公网 IP 的清洗阈值, 仅支持 ipv4. (已废弃, 建议使用 &lt;a href&#x3D;&quot;http://docs.jdcloud.com/anti-ddos-basic/api/setipcleanthreshold&quot;&gt;setIpCleanThreshold&lt;/a&gt; 接口)
        /// 
    /// </summary>
    public class SetCleanThresholdExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  设置基础防护已防护公网 IP 的清洗阈值, 仅支持 ipv4. (已废弃, 建议使用 &lt;a href&#x3D;&quot;http://docs.jdcloud.com/anti-ddos-basic/api/setipcleanthreshold&quot;&gt;setIpCleanThreshold&lt;/a&gt; 接口)
        /// 接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "POST";
            }
        }
        /// <summary>
        ///  设置基础防护已防护公网 IP 的清洗阈值, 仅支持 ipv4. (已废弃, 建议使用 &lt;a href&#x3D;&quot;http://docs.jdcloud.com/anti-ddos-basic/api/setipcleanthreshold&quot;&gt;setIpCleanThreshold&lt;/a&gt; 接口)
        /// 接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/regions/{regionId}/ipResources/{ip}:setCleanThreshold";
            }
        }
    }
}