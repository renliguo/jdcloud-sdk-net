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


namespace JDCloudSDK.Pod.Model
{

    /// <summary>
    ///  描述实例的网卡信息
    /// </summary>
    public class InstanceNetworkInterface
    {

        ///<summary>
        /// 弹性网卡ID
        ///</summary>
        public string NetworkInterfaceId{ get; set; }
        ///<summary>
        /// 以太网地址
        ///</summary>
        public string MacAddress{ get; set; }
        ///<summary>
        /// 虚拟网络ID
        ///</summary>
        public string VpcId{ get; set; }
        ///<summary>
        /// 子网ID
        ///</summary>
        public string SubnetId{ get; set; }
        ///<summary>
        /// 描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 安全组列表
        ///</summary>
        public List<SecurityGroupSimple> SecurityGroups{ get; set; }
        ///<summary>
        /// 源和目标IP地址校验，取值为0或者1
        ///</summary>
        public bool SanityCheck{ get; set; }
        ///<summary>
        /// 网卡主IP
        ///</summary>
        public NetworkInterfacePrivateIp PrimaryIp{ get; set; }
        ///<summary>
        /// SecondaryIps
        ///</summary>
        public List<NetworkInterfacePrivateIp> SecondaryIps{ get; set; }
    }
}
