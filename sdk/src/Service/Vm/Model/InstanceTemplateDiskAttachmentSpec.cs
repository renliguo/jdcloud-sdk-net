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


namespace JDCloudSDK.Vm.Model
{

    /// <summary>
    /// instanceTemplateDiskAttachmentSpec
    /// </summary>
    public class InstanceTemplateDiskAttachmentSpec
    {

        ///<summary>
        ///磁盘分类，local或者cloud；系统盘仅支持local；数据盘仅支持cloud
        ///</summary>
        public string DiskCategory{ get; set; }
        ///<summary>
        ///自动删除，删除主机时自动删除此磁盘，默认为true，本地盘不能更改此值
        ///</summary>
        public bool AutoDelete{ get; set; }
        ///<summary>
        ///云硬盘规格
        ///</summary>
        public InstanceTemplateDiskSpec CloudDiskSpec{ get; set; }
        ///<summary>
        ///数据盘逻辑挂载点vdb,vdc,vdd,vde,vdf,vdg,vdh
        ///</summary>
        public string DeviceName{ get; set; }
        ///<summary>
        ///排除镜像数据盘映射中的逻辑挂载点
        ///</summary>
        public bool NoDevice{ get; set; }
    }
}
