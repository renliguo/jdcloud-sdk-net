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
    ///  instanceTemplateData
    /// </summary>
    public class InstanceTemplateData
    {

        ///<summary>
        /// 规格类型
        ///</summary>
        public string InstanceType{ get; set; }
        ///<summary>
        /// 主网卡所属VPC的ID
        ///</summary>
        public string VpcId{ get; set; }
        ///<summary>
        /// 镜像ID
        ///</summary>
        public string ImageId{ get; set; }
        ///<summary>
        /// 启动模板中是否包含自定义密码，true：包含密码，false：不包含密码
        ///</summary>
        public bool IncludePassword{ get; set; }
        ///<summary>
        /// 系统盘信息
        ///</summary>
        public InstanceTemplateDiskAttachment SystemDisk{ get; set; }
        ///<summary>
        /// 数据盘信息，本地盘(local类型)做系统盘的云主机可挂载8块数据盘，云硬盘(cloud类型)做系统盘的云主机可挂载7块数据盘。
        ///</summary>
        public List<InstanceTemplateDiskAttachment> DataDisks{ get; set; }
        ///<summary>
        /// 主网卡信息
        ///</summary>
        public InstanceTemplateNetworkInterfaceAttachmentSpec PrimaryNetworkInterface{ get; set; }
        ///<summary>
        /// 主网卡主IP关联的弹性IP规格
        ///</summary>
        public InstanceTemplateElasticIp ElasticIp{ get; set; }
        ///<summary>
        /// 密钥对名称；当前只支持一个
        ///</summary>
        public List<string> KeyNames{ get; set; }
    }
}
