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
 * Repository
 * 容器镜像仓库相关接口
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

namespace  JDCloudSDK.Cr.Apis
{

    /// <summary>
    ///  查询指定镜像仓库名称是否已经存在以及是否符合命名规范。
        ///         /// 
    /// </summary>
    public class CheckRepositoryNameRequest : JdcloudRequest
    {
        ///<summary>
        /// 注册表名。
        ///Required:true
        ///</summary>
        [Required]
        public   string RegistryName{ get; set; }
        ///<summary>
        /// 待验证的镜像仓库名。
        ///Required:true
        ///</summary>
        [Required]
        public   string RepositoryName{ get; set; }
        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}