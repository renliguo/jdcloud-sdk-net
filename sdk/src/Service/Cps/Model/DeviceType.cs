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


namespace JDCloudSDK.Cps.Model
{

    /// <summary>
    ///  deviceType
    /// </summary>
    public class DeviceType
    {

        ///<summary>
        /// 实例类型英文名称, 如 cps.c.normal
        ///</summary>
        public string NameEN{ get; set; }
        ///<summary>
        /// 实例类型中文名称, 如 计算型
        ///</summary>
        public string NameZH{ get; set; }
        ///<summary>
        /// 镜像类型英文描述, 如 standard
        ///</summary>
        public string UseTypeEN{ get; set; }
        ///<summary>
        /// 镜像类型中文描述, 如 标准型
        ///</summary>
        public string UseTypeZH{ get; set; }
        ///<summary>
        /// 区域代码, 如 cn-east-1
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// CPU概要描述
        ///</summary>
        public string CpuConcise{ get; set; }
        ///<summary>
        /// CPU详细信息
        ///</summary>
        public string CpuDetail{ get; set; }
        ///<summary>
        /// 内存概要信息
        ///</summary>
        public string MemConcise{ get; set; }
        ///<summary>
        /// 内存详细信息
        ///</summary>
        public string MemDetail{ get; set; }
        ///<summary>
        /// 网口概要信息
        ///</summary>
        public string IfConcise{ get; set; }
        ///<summary>
        /// 网口详细信息
        ///</summary>
        public string IfDetail{ get; set; }
        ///<summary>
        /// 系统磁盘概要信息
        ///</summary>
        public string SystemDiskConcise{ get; set; }
        ///<summary>
        /// 系统磁盘详细信息
        ///</summary>
        public string SystemDiskDetail{ get; set; }
        ///<summary>
        /// 数据磁盘概要信息
        ///</summary>
        public string DataDiskConcise{ get; set; }
        ///<summary>
        /// 数据磁盘详细信息
        ///</summary>
        public string DataDiskDetail{ get; set; }
        ///<summary>
        /// GPU概要信息
        ///</summary>
        public string GpuConcise{ get; set; }
        ///<summary>
        /// GPU详细信息
        ///</summary>
        public string GpuDetail{ get; set; }
    }
}
