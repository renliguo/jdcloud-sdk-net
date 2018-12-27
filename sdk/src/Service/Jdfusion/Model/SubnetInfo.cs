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
    ///  子网属性信息
    /// </summary>
    public class SubnetInfo
    {

        ///<summary>
        /// Subnet的Id
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// 子网所属VPC的Id
        ///</summary>
        public string VpcId{ get; set; }
        ///<summary>
        /// 子网名称
        ///</summary>
        public string SubnetName{ get; set; }
        ///<summary>
        /// 子网网段
        ///</summary>
        public string AddressPrefix{ get; set; }
        ///<summary>
        /// 子网可用ip数量
        ///</summary>
        public int? AvailableIpCount{ get; set; }
        ///<summary>
        /// 子网描述信息
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 子网的结束地址
        ///</summary>
        public string EndIp{ get; set; }
        ///<summary>
        /// 子网关联的路由表Id
        ///</summary>
        public string RouteTableId{ get; set; }
        ///<summary>
        /// 子网的起始地址
        ///</summary>
        public string StartIp{ get; set; }
        ///<summary>
        /// 所属云提供商ID
        ///</summary>
        public string CloudID{ get; set; }
    }
}
