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

namespace JDCloudSDK.Redis.Model
{

    /// <summary>
    /// cacheInstanceSpec
    /// </summary>
    public class CacheInstanceSpec
    {

        ///<summary>
        ///所属VPC的ID
        ///Required:true
        ///</summary>
        [Required]
        public string VpcId{ get; set; }
        ///<summary>
        ///所属子网的ID
        ///Required:true
        ///</summary>
        [Required]
        public string SubnetId{ get; set; }
        ///<summary>
        ///实例名称，只支持数字、字母、英文下划线、中文，且不少于2字符不超过32字符
        ///Required:true
        ///</summary>
        [Required]
        public string CacheInstanceName{ get; set; }
        ///<summary>
        ///实例规格代码，参见实例规格代码表。
        ///Required:true
        ///</summary>
        [Required]
        public string CacheInstanceClass{ get; set; }
        ///<summary>
        ///密码，必须包含且只支持字母及数字，不少于8字符不超过16字符
        ///Required:true
        ///</summary>
        [Required]
        public string Password{ get; set; }
        ///<summary>
        ///缓存Redis实例所在区域可用区ID信息
        ///Required:true
        ///</summary>
        [Required]
        public AzIdSpec AzId{ get; set; }
        ///<summary>
        ///缓存Redis实例描述
        ///</summary>
        public string CacheInstanceDescription{ get; set; }
    }
}
