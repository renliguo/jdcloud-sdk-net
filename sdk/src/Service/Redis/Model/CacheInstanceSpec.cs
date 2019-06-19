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
    ///  创建缓存Redis实例时，用户输入的参数
    /// </summary>
    public class CacheInstanceSpec
    {

        ///<summary>
        /// 缓存Redis实例所属的私有网络ID
        ///Required:true
        ///</summary>
        [Required]
        public string VpcId{ get; set; }
        ///<summary>
        /// 缓存Redis实例在私有网络下所属的子网ID
        ///Required:true
        ///</summary>
        [Required]
        public string SubnetId{ get; set; }
        ///<summary>
        /// 缓存Redis实例名称，只支持数字、字母、英文下划线、中文，且不少于2字符不超过32字符
        ///Required:true
        ///</summary>
        [Required]
        public string CacheInstanceName{ get; set; }
        ///<summary>
        /// 缓存Redis实例的规格代码，参考 https://docs.jdcloud.com/cn/jcs-for-redis/specifications
        ///Required:true
        ///</summary>
        [Required]
        public string CacheInstanceClass{ get; set; }
        ///<summary>
        /// 缓存Redis实例的连接密码，为空即为免密，包含且只支持字母及数字，不少于8字符不超过16字符
        ///</summary>
        public string Password{ get; set; }
        ///<summary>
        /// 缓存Redis实例所在区域的可用区ID
        ///Required:true
        ///</summary>
        [Required]
        public AzIdSpec AzId{ get; set; }
        ///<summary>
        /// 缓存Redis实例的描述，不能超过256个字符
        ///</summary>
        public string CacheInstanceDescription{ get; set; }
        ///<summary>
        /// 支持的缓存Redis引擎主次版本号：目前支持2.8和4.0，默认为2.8
        ///</summary>
        public string RedisVersion{ get; set; }
        ///<summary>
        /// 是否支持IPv6，0或空表示不支持，1表示支持IPv6，注意不是所有区域都支持IPv6
        ///</summary>
        public int? Ipv6On{ get; set; }
    }
}