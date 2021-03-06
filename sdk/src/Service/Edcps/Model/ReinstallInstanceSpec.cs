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

namespace JDCloudSDK.Edcps.Model
{

    /// <summary>
    ///  reinstallInstanceSpec
    /// </summary>
    public class ReinstallInstanceSpec
    {

        ///<summary>
        /// 可用区, 如cn-east-tz1a
        ///Required:true
        ///</summary>
        [Required]
        public string Az{ get; set; }
        ///<summary>
        /// 镜像类型, 取值范围：standard
        ///Required:true
        ///</summary>
        [Required]
        public string ImageType{ get; set; }
        ///<summary>
        /// 操作系统类型ID
        ///Required:true
        ///</summary>
        [Required]
        public string OsTypeId{ get; set; }
        ///<summary>
        /// 系统盘RAID类型ID
        ///Required:true
        ///</summary>
        [Required]
        public string SysRaidTypeId{ get; set; }
        ///<summary>
        /// 是否保留数据盘数据, 取值为：yes、no
        ///Required:true
        ///</summary>
        [Required]
        public string KeepData{ get; set; }
        ///<summary>
        /// 数据盘RAID类型ID
        ///Required:true
        ///</summary>
        [Required]
        public string DataRaidTypeId{ get; set; }
        ///<summary>
        /// 密码
        ///Required:true
        ///</summary>
        [Required]
        public string Password{ get; set; }
        ///<summary>
        /// 主机名
        ///</summary>
        public string Hostname{ get; set; }
        ///<summary>
        /// 可执行脚本Base64编码后的内容，支持shell和python脚本
        ///</summary>
        public string UserData{ get; set; }
        ///<summary>
        /// 密钥对id
        ///</summary>
        public string KeypairId{ get; set; }
    }
}
