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
 * JDCLOUD 密钥管理服务(Key Management Service) API
 * 基于硬件保护密钥的安全数据托管服务
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Kms.Client
{

    /// <summary>
    /// 计划在以后的是个时间点删除密钥，默认为7天
    /// </summary>
    public class DeleteKeyExecutor : JdcloudExecutor
    {
        /// <summary>
        /// 计划在以后的是个时间点删除密钥，默认为7天接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "DELETE";
            }
        }
        /// <summary>
        /// 计划在以后的是个时间点删除密钥，默认为7天接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/key/{keyId}:delete";
            }
        }
    }
}
