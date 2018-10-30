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
 * 解析记录
 * 云解析OpenAPI解析记录接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Clouddnsservice.Apis
{

    /// <summary>
    ///  启用、停用、删除主域名下的解析记录
    /// </summary>
    public class OperateRRRequest : JdcloudRequest
    {
        ///<summary>
        /// 需要操作的解析记录ID
        ///Required:true
        ///</summary>
        [Required]
        public List<int?> Ids{ get; set; }

        ///<summary>
        /// 操作类型，on-&gt;启用 off-&gt;停用 del-&gt;删除
        ///Required:true
        ///</summary>
        [Required]
        public   string Action{ get; set; }
        ///<summary>
        /// 实例所属的地域ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// 域名ID，请使用getDomains接口获取。
        ///Required:true
        ///</summary>
        [Required]
        public   string DomainId{ get; set; }
    }
}