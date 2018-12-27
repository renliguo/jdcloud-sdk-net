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
 * custom domain name openapi
 * custom domain name openapi
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Ossopenapi.Model
{

    /// <summary>
    ///  cNameInfo
    /// </summary>
    public class CNameInfo
    {

        ///<summary>
        /// 自定义域名
        ///Required:true
        ///</summary>
        [Required]
        public string Cname{ get; set; }
        ///<summary>
        /// http版本，0：http，1：https
        ///</summary>
        public int? ProtoType{ get; set; }
        ///<summary>
        /// 域名
        ///Required:true
        ///</summary>
        [Required]
        public string EndPoint{ get; set; }
        ///<summary>
        /// 是否拦截内部域名添，任意值跳过拦截
        ///</summary>
        public string Internal{ get; set; }
    }
}
