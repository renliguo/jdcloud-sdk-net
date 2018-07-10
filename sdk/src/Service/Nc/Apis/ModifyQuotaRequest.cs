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
 * 配额
 * 容器配额
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

namespace  JDCloudSDK.Nc.Apis
{

    /// <summary>
    /// 修改资源的配额
    /// </summary>
    public class ModifyQuotaRequest : JdcloudRequest
    {
        ///<summary>
        ///资源类型  container：用户能创建的容器的配额  secret：用户能创建的secret的配额
        ///Required:true
        ///</summary>
        [Required]
        public   string ResourceType{ get; set; }
        ///<summary>
        ///上限
        ///Required:true
        ///</summary>
        [Required]
        public   int Limit{ get; set; }
        ///<summary>
        ///Region ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}