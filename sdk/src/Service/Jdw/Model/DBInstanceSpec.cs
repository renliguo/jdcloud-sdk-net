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
using JDCloudSDK.Charge.Model;

namespace JDCloudSDK.Jdw.Model
{

    /// <summary>
    ///  dBInstanceSpec
    /// </summary>
    public class DBInstanceSpec
    {

        ///<summary>
        /// 实例名称，名称只支持数字、小写字母、中文及英文下划线，且不少于2字符不超过32字符；未填写取实例ID作为实例名称
        ///</summary>
        public string InstanceName{ get; set; }
        ///<summary>
        /// 节点规格，目前支持jdw.dc1.4xlarge
        ///Required:true
        ///</summary>
        [Required]
        public string NodeType{ get; set; }
        ///<summary>
        /// 节点数量，目前支持3个
        ///Required:true
        ///</summary>
        [Required]
        public int NodeNumber{ get; set; }
        ///<summary>
        /// 可用区
        ///Required:true
        ///</summary>
        [Required]
        public string AzId{ get; set; }
        ///<summary>
        /// VPCID
        ///Required:true
        ///</summary>
        [Required]
        public string VpcId{ get; set; }
        ///<summary>
        /// 子网ID
        ///Required:true
        ///</summary>
        [Required]
        public string SubnetId{ get; set; }
        ///<summary>
        /// 数据库账号，账号只支持数字、大小写字母及英文下划线“_”，不超过16字符 ，非必填
        ///</summary>
        public string AccountName{ get; set; }
        ///<summary>
        /// 数据库密码，密码必须包含且只支持大小写字母及数字，不少于8字符不超过16字符，非必填，可创建后设置
        ///</summary>
        public string AccountPassword{ get; set; }
        ///<summary>
        /// 计费规格，包括计费类型，计费周期等
        ///Required:true
        ///</summary>
        [Required]
        public ChargeSpec ChargeSpec{ get; set; }
    }
}
