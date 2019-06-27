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
 * SSL Certificate
 * SSL数字证书相关信息接口
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


namespace  JDCloudSDK.Cdn.Apis
{

    /// <summary>
    ///  查看证书列表
    /// </summary>
    public class GetSslCertListRequest : JdcloudRequest
    {
        ///<summary>
        /// 第几页，从1开始计数
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 每页显示的数目
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 域名，支持按照域名检索证书
        ///</summary>
        public   string Domain{ get; set; }
    }
}