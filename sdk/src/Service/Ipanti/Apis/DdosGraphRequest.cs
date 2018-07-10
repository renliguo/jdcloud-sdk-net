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
 * Ip高防报表相关接口
 * Ip高防报表相关接口，包括cc防护、ddos防护、转发流量
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

namespace  JDCloudSDK.Ipanti.Apis
{

    /// <summary>
    /// ddos防护报表
    /// </summary>
    public class DdosGraphRequest : JdcloudRequest
    {
        ///<summary>
        ///开始时间，最多查最近30天，UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ssZ
        ///Required:true
        ///</summary>
        [Required]
        public   string StartTime{ get; set; }
        ///<summary>
        ///查询的结束时间，UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ssZ
        ///Required:true
        ///</summary>
        [Required]
        public   string EndTime{ get; set; }
        ///<summary>
        ///高防实例id，可以传0个或多个
        ///</summary>
        public List<string> InstanceId{ get; set; }

        ///<summary>
        ///Region ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}