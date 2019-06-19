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


namespace JDCloudSDK.Cps.Model
{

    /// <summary>
    ///  subnet
    /// </summary>
    public class Subnet
    {

        ///<summary>
        /// 地域代码, 如cn-east-1
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// 可用区, 如cn-east-1a
        ///</summary>
        public string Az{ get; set; }
        ///<summary>
        /// 子网ID
        ///</summary>
        public string SubnetId{ get; set; }
        ///<summary>
        /// 子网名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 子网CIDR
        ///</summary>
        public string Cidr{ get; set; }
        ///<summary>
        /// 私有网络Id
        ///</summary>
        public string VpcId{ get; set; }
        ///<summary>
        /// 私有网络名称
        ///</summary>
        public string VpcName{ get; set; }
        ///<summary>
        /// 可用ip数量
        ///</summary>
        public int? AvailableIpCount{ get; set; }
        ///<summary>
        /// 总ip数量
        ///</summary>
        public int? TotalIpCount{ get; set; }
        ///<summary>
        /// 网络类型
        ///</summary>
        public string NetworkType{ get; set; }
        ///<summary>
        /// 描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public string CreateTime{ get; set; }
    }
}