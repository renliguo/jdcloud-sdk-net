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
    ///  vpcInfoDetail
    /// </summary>
    public class VpcInfoDetail
    {

        ///<summary>
        /// Vpc的Id
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// 私有网络名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 地址范围
        ///</summary>
        public string CidrBlock{ get; set; }
        ///<summary>
        /// VPC 描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public string CreatedTime{ get; set; }
        ///<summary>
        /// 所属云提供商ID
        ///</summary>
        public string CloudID{ get; set; }
        ///<summary>
        /// 私有网络包含的子网列表
        ///</summary>
        public List<SubnetInfo> Subnets{ get; set; }
        ///<summary>
        /// 路由表ID集合
        ///</summary>
        public List<string> RouteTableIds{ get; set; }
    }
}
