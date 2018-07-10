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
 * JDCLOUD 资产管理 API
 * 态势感知资产管理相关信息接口
 *
 * OpenAPI spec version: v2
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Csa.Apis
{

    /// <summary>
    /// 查看资产详情
    /// </summary>
    public class QueryAssetFixedIpsRequest : JdcloudRequest
    {
        ///<summary>
        ///公网Ip
        ///Required:true
        ///</summary>
        [Required]
        public   string FloatingIp{ get; set; }
        ///<summary>
        ///第几页，从1开始计数，最大值100
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        ///每页显示的数目，默认为10，最大值100
        ///</summary>
        public   int? PageSize{ get; set; }
    }
}