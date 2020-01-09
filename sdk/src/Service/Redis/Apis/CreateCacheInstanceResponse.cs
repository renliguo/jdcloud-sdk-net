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
 * Redis Instance API
 * 缓存Redis实例的创建、删除、修改基本信息、设置密码、变配、实例列表、备份、配置参数等接口
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


namespace  JDCloudSDK.Redis.Apis
{

    /// <summary>
    ///  创建一个指定配置的缓存Redis实例：可选择主从版或集群版，每种类型又分为多种规格（按CPU核数、内存容量、磁盘容量、带宽等划分），不同规格价格也不同，具体可参考产品规格代码，https://docs.jdcloud.com/cn/jcs-for-redis/specifications
        ///         /// 
    /// </summary>
    public class CreateCacheInstanceResponse : JdcloudResponse<CreateCacheInstanceResult>
    {
    }
}