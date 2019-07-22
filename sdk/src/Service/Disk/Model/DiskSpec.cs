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
using JDCloudSDK.Charge.Model;

namespace JDCloudSDK.Disk.Model
{

    /// <summary>
    ///  diskSpec
    /// </summary>
    public class DiskSpec
    {

        ///<summary>
        /// 云硬盘所属的可用区
        ///Required:true
        ///</summary>
        [Required]
        public string Az{ get; set; }
        ///<summary>
        /// 云硬盘名称
        ///Required:true
        ///</summary>
        [Required]
        public string Name{ get; set; }
        ///<summary>
        /// 云硬盘描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 云硬盘类型，取值为ssd、premium-hdd、ssd.gp1、ssd.io1、hdd.std1之一
        ///Required:true
        ///</summary>
        [Required]
        public string DiskType{ get; set; }
        ///<summary>
        /// 云硬盘大小，单位为 GiB，ssd 类型取值范围[20,1000]GB，步长为10G，premium-hdd 类型取值范围[20,3000]GB，步长为10G
        ///Required:true
        ///</summary>
        [Required]
        public int DiskSizeGB{ get; set; }
        ///<summary>
        /// 用于创建云硬盘的快照ID
        ///</summary>
        public string SnapshotId{ get; set; }
        ///<summary>
        /// 计费配置；如不指定，默认计费类型是后付费-按使用时常付费
        ///</summary>
        public ChargeSpec Charge{ get; set; }
        ///<summary>
        /// 云硬盘是否支持一盘多主机挂载，默认为false（不支持）
        ///</summary>
        public bool MultiAttachable{ get; set; }
        ///<summary>
        /// 云硬盘是否加密，默认为false（不加密）
        ///</summary>
        public bool Encrypt{ get; set; }
    }
}