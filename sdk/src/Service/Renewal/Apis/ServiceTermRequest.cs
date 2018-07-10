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
 * renewal相关接口
 * API related to JDCLOUD
 *
 * 
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Renewal.Apis
{

    /// <summary>
    /// 查询服务条款
    /// </summary>
    public class ServiceTermRequest : JdcloudRequest
    {
        ///<summary>
        ///ServiceCode
        ///Required:true
        ///</summary>
        [Required]
        public   string ServiceCode{ get; set; }
        ///<summary>
        ///RegionId
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}