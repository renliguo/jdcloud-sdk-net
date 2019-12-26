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


namespace JDCloudSDK.Kubernetes.Model
{

    /// <summary>
    ///  工作节点配置信息
    /// </summary>
    public class NodeConfig
    {

        ///<summary>
        /// 实例类型
        ///</summary>
        public string InstanceType{ get; set; }
        ///<summary>
        /// 镜像信息
        ///</summary>
        public string ImageId{ get; set; }
        ///<summary>
        /// 云主机SSH密钥对名称
        ///</summary>
        public List<string> KeyNames{ get; set; }
        ///<summary>
        /// 云主机磁盘类型
        ///</summary>
        public string SystemDiskCategory{ get; set; }
        ///<summary>
        /// 云主机云盘系统盘大小  单位(GB)
        ///</summary>
        public int? SystemDiskSize{ get; set; }
        ///<summary>
        /// 云主机云盘系统盘类型
        ///</summary>
        public string SystemDiskType{ get; set; }
        ///<summary>
        /// 云主机云盘 iops，仅限 ssd 类型云盘有效
        ///</summary>
        public int? SystemDiskIops{ get; set; }
        ///<summary>
        /// 工作节点组标签
        ///</summary>
        public List<LabelSpec> Labels{ get; set; }
    }
}