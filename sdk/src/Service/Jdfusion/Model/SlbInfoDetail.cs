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


namespace JDCloudSDK.Jdfusion.Model
{

    /// <summary>
    ///  slbInfoDetail
    /// </summary>
    public class SlbInfoDetail
    {

        ///<summary>
        /// 所属云ID
        ///</summary>
        public string CloudID{ get; set; }
        ///<summary>
        /// 负载均衡实例ID。
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// 负载均衡实例的名称。
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 负载均衡实例状态
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 负载均衡实例的服务地址。
        ///</summary>
        public string IpAddress{ get; set; }
        ///<summary>
        /// 负载均衡实例的网络类型。
        ///</summary>
        public string AddressType{ get; set; }
        ///<summary>
        /// 私网负载均衡实例的交换机ID。
        ///</summary>
        public string SubnetId{ get; set; }
        ///<summary>
        /// 私网负载均衡实例的专有网络ID。
        ///</summary>
        public string Vpc{ get; set; }
        ///<summary>
        /// 私网负载均衡实例的网络类型
        ///</summary>
        public string NetworkType{ get; set; }
        ///<summary>
        /// 实例的主可用区ID。
        ///</summary>
        public string MasterAz{ get; set; }
        ///<summary>
        /// 实例的备可用区ID。
        ///</summary>
        public string SlaveAz{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public string CreatedTime{ get; set; }
        ///<summary>
        /// 负载均衡实例前端使用的端口和协议列表。
        ///</summary>
        public List<ListenerPortsAndProtocol> ListenerPortsAndProtocol{ get; set; }
        ///<summary>
        /// 负载均衡实例的后端服务器列表。
        ///</summary>
        public List<BackendServer2> BackendServers{ get; set; }
        ///<summary>
        /// 负载均衡实例的的性能规格。取值：slb.s1.small、slb.s2.small、slb.s2.medium、slb.s3.small、slb.s3.medium、slb.s3.large
        ///</summary>
        public string LoadBalancerSpec{ get; set; }
    }
}
