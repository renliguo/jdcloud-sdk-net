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


namespace JDCloudSDK.Nc.Model
{

    /// <summary>
    ///  挂载的Volume
    /// </summary>
    public class VolumeMount
    {

        ///<summary>
        /// 环境变量名称
        ///</summary>
        public string Category{ get; set; }
        ///<summary>
        /// 自动删除，删除容器时自动删除此volume
        ///</summary>
        public bool AutoDelete{ get; set; }
        ///<summary>
        /// 容器内的挂载目录
        ///</summary>
        public string MountPath{ get; set; }
        ///<summary>
        /// 只读，默认false；只针对data volume有效，root volume为false
        ///</summary>
        public bool ReadOnly{ get; set; }
        ///<summary>
        /// 云硬盘规格
        ///</summary>
        public InstanceCloudDisk CloudDisk{ get; set; }
        ///<summary>
        /// 指定volume文件系统类型，目前支持[xfs, ext4]
        ///</summary>
        public string FsType{ get; set; }
    }
}
