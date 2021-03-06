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
 * 镜像
 * 关于主机镜像操作的相关接口
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
using Newtonsoft.Json;

namespace  JDCloudSDK.Vm.Apis
{

    /// <summary>
    ///  导出镜像，将京东云私有镜像导出至京东云以外环境
        ///         /// 
    /// </summary>
    public class ExportImageRequest : JdcloudRequest
    {
        ///<summary>
        /// 用户创建的服务角色名称
        ///Required:true
        ///</summary>
        [Required]
        public   string RoleName{ get; set; }
        ///<summary>
        /// 存储导出镜像文件的oss bucket的域名，请填写以 https:// 开头的完整url
        ///Required:true
        ///</summary>
        [Required]
        public   string OssUrl{ get; set; }
        ///<summary>
        /// 导出镜像文件名前缀，仅支持英文字母和数字，不能超过32个字符
        ///</summary>
        public   string OssPrefix{ get; set; }
        ///<summary>
        /// 用户导出镜像的幂等性保证。每次导出请传入不同的值，如果传值与某次的clientToken相同，则返还同一个请求结果，不能超过64个字符
        ///</summary>
        public   string ClientToken{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 镜像ID
        ///Required:true
        ///</summary>
        [Required]
        public   string ImageId{ get; set; }
    }
}