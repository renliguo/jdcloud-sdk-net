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


namespace JDCloudSDK.Jdfusion.Model
{

    /// <summary>
    ///  vmInfo
    /// </summary>
    public class VmInfo
    {

        ///<summary>
        /// 资源ID，如果为空，则执行创建操作，否则执行修改操作
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// 可用区,根据各云平台规范填写
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// 云主机所属的可用区
        ///</summary>
        public string Az{ get; set; }
        ///<summary>
        /// 云主机名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 云主机
        ///</summary>
        public string HostName{ get; set; }
        ///<summary>
        /// ImageType
        ///</summary>
        public ImageType ImageType{ get; set; }
        ///<summary>
        /// InstanceType
        ///</summary>
        public InstanceType InstanceType{ get; set; }
        ///<summary>
        /// 云主机描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 子网ID
        ///</summary>
        public string SubnetId{ get; set; }
        ///<summary>
        /// Tags
        ///</summary>
        public List<Tag> Tags{ get; set; }
        ///<summary>
        /// 所属云提供商ID
        ///</summary>
        public string CloudID{ get; set; }
        ///<summary>
        /// 密钥对名称,jd当前只支持传入一个
        ///</summary>
        public List<string> KeyNames{ get; set; }
        ///<summary>
        /// 主网卡主IP绑定弹性IP的地址
        ///</summary>
        public string ElasticIpAddress{ get; set; }
        ///<summary>
        /// 私有ip地址
        ///</summary>
        public string PrivateIpAddress{ get; set; }
        ///<summary>
        /// 云主机状态
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public string CreatedTime{ get; set; }
        ///<summary>
        /// 镜像ID
        ///</summary>
        public string ImageId{ get; set; }
        ///<summary>
        /// 安全组ID
        ///</summary>
        public List<string> SecurityGroupIds{ get; set; }
    }
}
