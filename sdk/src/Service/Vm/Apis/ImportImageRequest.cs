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

namespace  JDCloudSDK.Vm.Apis
{

    /// <summary>
    ///  导入镜像，将外部镜像导入到京东云中
        ///         /// 
    /// </summary>
    public class ImportImageRequest : JdcloudRequest
    {
        ///<summary>
        /// 系统架构，可选值：x86_64,i386
        ///Required:true
        ///</summary>
        [Required]
        public   string Architecture{ get; set; }
        ///<summary>
        /// 操作系统，可选值：windows,linux
        ///Required:true
        ///</summary>
        [Required]
        public   string OsType{ get; set; }
        ///<summary>
        /// 平台名称，可选值：CentOS,Ubuntu,Windows Server,Other Linux,Other Windows
        ///Required:true
        ///</summary>
        [Required]
        public   string Platform{ get; set; }
        ///<summary>
        /// 磁盘格式，可选值：qcow2,vhd,vmdk,raw
        ///Required:true
        ///</summary>
        [Required]
        public   string DiskFormat{ get; set; }
        ///<summary>
        /// 以此镜像需要制作的系统盘的默认大小，单位GB。最小值40，最大值500，要求值是10的整数倍
        ///Required:true
        ///</summary>
        [Required]
        public   int SystemDiskSizeGB{ get; set; }
        ///<summary>
        /// 要导入镜像的对象存储外链地址
        ///Required:true
        ///</summary>
        [Required]
        public   string ImageUrl{ get; set; }
        ///<summary>
        /// 镜像的操作系统版本
        ///</summary>
        public   string OsVersion{ get; set; }
        ///<summary>
        /// 导入镜像的自定义名称
        ///Required:true
        ///</summary>
        [Required]
        public   string ImageName{ get; set; }
        ///<summary>
        /// 导入镜像的描述信息
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// 是否强制导入。强制导入则忽略镜像的合规性检测
        ///</summary>
        public   bool ForceImport{ get; set; }
        ///<summary>
        /// 用户导入镜像的幂等性保证。每次创建请传入不同的值，如果传值与某次的clientToken相同，则返还该次的请求结果
        ///</summary>
        public   string ClientToken{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}