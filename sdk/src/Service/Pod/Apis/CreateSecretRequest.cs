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
 * 镜像仓库认证信息
 * 关于镜像仓库认证信息的相关接口
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

using JDCloudSDK.Pod.Model;
using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Pod.Apis
{

    /// <summary>
    ///  创建一个 secret，用于存放镜像仓库机密相关信息。
        ///         /// 
    /// </summary>
    public class CreateSecretRequest : JdcloudRequest
    {
        ///<summary>
        /// 机密数据名称，不能重复
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   string Name{ get; set; }
        ///<summary>
        /// 机密数据的类型，目前仅支持：docker-registry 类型，用来和docker registry认证的类型。
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   string SecretType{ get; set; }
        ///<summary>
        /// 机密的数据。&lt;br&gt;
        /// key 的有效字符包括字母、数字、-、_和.； &lt;br&gt;
        /// value 是 Base64 编码的字符串，不能包含换行符（在 linux 下使用 base64 -w 0选项），每个value长度上限为4KB，整个data的长度不能超过256KB; &lt;br&gt;
        /// 必须包含server、username、password 字段，email 字段是可选的。&lt;br&gt;
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   DockerRegistryData Data{ get; set; }
        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}