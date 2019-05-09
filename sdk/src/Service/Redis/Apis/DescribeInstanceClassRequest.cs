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
 * Redis Class API
 * 缓存Redis实例规格查询、修改接口
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

namespace  JDCloudSDK.Redis.Apis
{

    /// <summary>
    ///  查询某区域下的缓存Redis实例规格列表
    /// </summary>
    public class DescribeInstanceClassRequest : JdcloudRequest
    {
        ///<summary>
        /// 缓存Redis的版本号：目前有2.8和4.0，默认为2.8
        ///</summary>
        public   string RedisVersion{ get; set; }
        ///<summary>
        /// 缓存Redis实例所在区域的Region ID。目前有华北-北京、华南-广州、华东-上海三个区域，Region ID分别为cn-north-1、cn-south-1、cn-east-2
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}