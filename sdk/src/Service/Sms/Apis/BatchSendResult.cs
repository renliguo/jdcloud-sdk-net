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
 * Send-Message-Related-APIs
 * 短信发送相关API
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

using JDCloudSDK.Sms.Model;

namespace  JDCloudSDK.Sms.Apis
{

    /// <summary>
    ///  指定模板群发短信
    /// </summary>
    public class BatchSendResult : JdcloudResult
    {
        ///<summary>
        /// 指定短信Id群发短信响应参数
        ///</summary>
        public   BatchSendResp Data{ get; set; }
        ///<summary>
        /// 请求状态
        ///</summary>
        public   bool Status{ get; set; }
        ///<summary>
        /// 错误码
        ///</summary>
        public   string Code{ get; set; }
        ///<summary>
        /// 错误消息
        ///</summary>
        public   string Message{ get; set; }
    }
}