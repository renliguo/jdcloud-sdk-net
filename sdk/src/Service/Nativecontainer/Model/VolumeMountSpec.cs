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
using JDCloudSDK.Disk.Model;

namespace JDCloudSDK.Nativecontainer.Model
{

    /// <summary>
    ///  指定挂载的Volume
    /// </summary>
    public class VolumeMountSpec
    {

        ///<summary>
        /// 磁盘分类 cloud：基于云硬盘的卷 仅支持cloud类型
        ///Required:true
        ///</summary>
        [Required]
        public string Category{ get; set; }
        ///<summary>
        /// 自动删除，删除容器时自动删除此volume，默认为True；只支持磁盘是云硬盘的场景
        ///</summary>
        public bool AutoDelete{ get; set; }
        ///<summary>
        /// 容器内的挂载目录；root volume不需要指定，挂载目录是（/）；data volume必须指定；必须是绝对路径，不能包含(:)
        ///</summary>
        public string MountPath{ get; set; }
        ///<summary>
        /// 只读，默认false；只针对data volume有效；root volume为false，也就是可读可写
        ///</summary>
        public bool ReadOnly{ get; set; }
        ///<summary>
        /// 云硬盘规格；随容器自动创建的云硬盘，不会对磁盘分区，只会格式化文件系统
        ///</summary>
        public DiskSpec CloudDiskSpec{ get; set; }
        ///<summary>
        /// 云硬盘ID，使用已有的云硬盘，必须同时指定fsType
        ///</summary>
        public string CloudDiskId{ get; set; }
        ///<summary>
        /// 指定volume文件系统类型，目前支持[xfs, ext4]；如果新创建的盘，不指定文件系统类型默认格式化成xfs
        ///</summary>
        public string FsType{ get; set; }
        ///<summary>
        /// 随容器自动创建的新盘，会自动格式化成指定的文件系统类型；挂载已有的盘，默认不会格式化，只会按照指定的fsType去挂载；如果希望格式化，必须设置此字段为true
        ///</summary>
        public bool FormatVolume{ get; set; }
    }
}
