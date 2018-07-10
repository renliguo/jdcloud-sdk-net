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
 * JDCLOUD 攻击信息 API
 * 态势感知弱点事件相关信息接口
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


namespace  JDCloudSDK.Csa.Apis
{

    /// <summary>
    /// 查询漏洞列表
    /// </summary>
    public class QuerWeakEventsRequest : JdcloudRequest
    {
        ///<summary>
        ///RiskName
        ///</summary>
        public   string RiskName{ get; set; }
        ///<summary>
        ///PageNumber
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        ///PageSize
        ///</summary>
        public   int? PageSize{ get; set; }
    }
}