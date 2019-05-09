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

namespace JDCloudSDK.Rds.Model
{

    /// <summary>
    ///  dBInstanceSpec
    /// </summary>
    public class DBInstanceSpec
    {

        ///<summary>
        /// 实例名，具体规则可参见帮助中心文档:[名称及密码限制](../../../documentation/Database-and-Cache-Service/RDS/Introduction/Restrictions/SQLServer-Restrictions.md)
        ///</summary>
        public string InstanceName{ get; set; }
        ///<summary>
        /// 实例引擎类型，参见[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)
        ///Required:true
        ///</summary>
        [Required]
        public string Engine{ get; set; }
        ///<summary>
        /// 实例引擎版本，参见[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)
        ///Required:true
        ///</summary>
        [Required]
        public string EngineVersion{ get; set; }
        ///<summary>
        /// 实例规格代码，可以查看文档[MySQL 实例规格](../Instance-Specifications/Instance-Specifications-MySQL.md)、[SQL Server实例规格](../Instance-Specifications/Instance-Specifications-SQLServer.md)
        ///Required:true
        ///</summary>
        [Required]
        public string InstanceClass{ get; set; }
        ///<summary>
        /// 磁盘大小，单位GB
        ///Required:true
        ///</summary>
        [Required]
        public int InstanceStorageGB{ get; set; }
        ///<summary>
        /// 可用区ID， 第一个ID必须为主实例所在的可用区。如两个可用区一样，也需输入两个azId
        ///Required:true
        ///</summary>
        [Required]
        public List<string> AzId{ get; set; }
        ///<summary>
        /// VPC的ID
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
        /// 参数组ID, 缺省系统会创建一个默认参数组&lt;br&gt;- 仅支持MySQL
        ///</summary>
        public string ParameterGroup{ get; set; }
        ///<summary>
        /// 计费规格，包括计费类型，计费周期等
        ///Required:true
        ///</summary>
        [Required]
        public ChargeSpec ChargeSpec{ get; set; }
        ///<summary>
        /// 存储类型，参见[枚举参数定义](../Enum-Definitions/Enum-Definitions.md), 缺省值为：LOCAL_SSD&lt;br&gt;- 仅支持MySQL
        ///</summary>
        public string InstanceStorageType{ get; set; }
        ///<summary>
        /// 实例数据加密(存储类型为云硬盘才支持数据加密)。false：不加密，true：加密，缺省为false&lt;br&gt;- 仅支持MySQL
        ///</summary>
        public bool StorageEncrypted{ get; set; }
        ///<summary>
        /// 实例的高可用架构。standalone：单机，cluster：主备双机架构，缺省为cluster&lt;br&gt;- 仅支持SQL Server
        ///</summary>
        public string InstanceType{ get; set; }
    }
}
