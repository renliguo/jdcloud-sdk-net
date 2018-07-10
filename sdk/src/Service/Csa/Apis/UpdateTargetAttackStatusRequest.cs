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
 * 态势感知定向攻击相关信息接口
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
    /// 更改事件状态
    /// </summary>
    public class UpdateTargetAttackStatusRequest : JdcloudRequest
    {
        ///<summary>
        ///事件状态(1:忽略;2:误报;3:确认)
        ///Required:true
        ///</summary>
        [Required]
        public   int Status{ get; set; }
        ///<summary>
        ///targetAttack事件ID
        ///Required:true
        ///</summary>
        [Required]
        public   string TargetAttackId{ get; set; }
    }
}