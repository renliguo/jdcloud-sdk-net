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
 * 
 * 
 *
 * 
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Iam.Model
{

    /// <summary>
    ///  authenticationInfo
    /// </summary>
    public class AuthenticationInfo
    {

        ///<summary>
        /// 主账号pin
        ///</summary>
        public string Account{ get; set; }
        ///<summary>
        /// 子账号pin
        ///</summary>
        public string SubUser{ get; set; }
        ///<summary>
        /// 操作类型,格式：serviceName:operationId
        ///Required:true
        ///</summary>
        [Required]
        public string Action{ get; set; }
        ///<summary>
        /// 资源信息,格式：jrn:service:region:accountId:resourceType/resourceId/subresourceType/subresourceId
        ///Required:true
        ///</summary>
        [Required]
        public string Resource{ get; set; }
    }
}
