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
 * navigation ext相关接口
 * API related to cms
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

namespace  JDCloudSDK.Cms.Apis
{

    /// <summary>
    /// 根据位置获取导航列表
    /// </summary>
    public class NavigationExtRequest : JdcloudRequest
    {
        ///<summary>
        ///balanceAndArrearsCallback
        ///</summary>
        public   string BalanceAndArrearsCallback{ get; set; }
        ///<summary>
        ///position
        ///Required:true
        ///</summary>
        [Required]
        public   string Position{ get; set; }
        ///<summary>
        ///referer
        ///</summary>
        public   string Referer{ get; set; }
    }
}