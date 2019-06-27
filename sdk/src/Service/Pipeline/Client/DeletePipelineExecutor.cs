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
 * pipeline
 * API OF Pipeline Create|Update|Read|Delete|Execute
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

namespace JDCloudSDK.Pipeline.Client
{

    /// <summary>
    ///  删除一个流水线任务
    /// </summary>
    public class DeletePipelineExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  删除一个流水线任务接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "DELETE";
            }
        }
        /// <summary>
        ///  删除一个流水线任务接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/regions/{regionId}/pipeline/{uuid}";
            }
        }
    }
}
