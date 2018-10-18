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

using JDCloudSDK.Charge.Model;

namespace JDCloudSDK.Cps.Model
{

    /// <summary>
    ///  instance
    /// </summary>
    public class Instance
    {

        ///<summary>
        /// 云物理服务器实例ID
        ///</summary>
        public string InstanceId{ get; set; }
        ///<summary>
        /// 区域代码, 如 cn-east-1
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// 可用区, 如 cn-east-1a
        ///</summary>
        public string Az{ get; set; }
        ///<summary>
        /// 实例类型, 如 cps.c.normal
        ///</summary>
        public string DeviceType{ get; set; }
        ///<summary>
        /// 云物理服务器名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 云物理服务器描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 云物理服务器生命周期状态
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 是否启用外网, 如 yes/no
        ///</summary>
        public string EnableInternet{ get; set; }
        ///<summary>
        /// 带宽, 单位Mbps
        ///</summary>
        public int? Bandwidth{ get; set; }
        ///<summary>
        /// 镜像类型, 如 standard/standard_app
        ///</summary>
        public string ImageType{ get; set; }
        ///<summary>
        /// 操作系统类型ID
        ///</summary>
        public string OsTypeId{ get; set; }
        ///<summary>
        /// 操作系统名称
        ///</summary>
        public string OsName{ get; set; }
        ///<summary>
        /// 操作系统类型, 如 ubuntu/centos
        ///</summary>
        public string OsType{ get; set; }
        ///<summary>
        /// 操作系统版本, 如 16.04
        ///</summary>
        public string OsVersion{ get; set; }
        ///<summary>
        /// 系统盘RAID类型ID
        ///</summary>
        public string SysRaidTypeId{ get; set; }
        ///<summary>
        /// 系统盘RAID类型, 如 NORAID, RAID0, RAID1
        ///</summary>
        public string SysRaidType{ get; set; }
        ///<summary>
        /// 数据盘RAID类型ID
        ///</summary>
        public string DataRaidTypeId{ get; set; }
        ///<summary>
        /// 数据盘RAID类型, 如 NORAID, RAID0, RAID1
        ///</summary>
        public string DataRaidType{ get; set; }
        ///<summary>
        /// 网络类型, 如 basic
        ///</summary>
        public string NetworkType{ get; set; }
        ///<summary>
        /// 外网链路类型, 如 bgp
        ///</summary>
        public string LineType{ get; set; }
        ///<summary>
        /// 子网编号
        ///</summary>
        public string SubnetId{ get; set; }
        ///<summary>
        /// 内网IP
        ///</summary>
        public string PrivateIp{ get; set; }
        ///<summary>
        /// 公网IP
        ///</summary>
        public string PublicIp{ get; set; }
        ///<summary>
        /// 计费信息
        ///</summary>
        public JDCloudSDK.Charge.Model.Charge Charge{ get; set; }
    }
}
