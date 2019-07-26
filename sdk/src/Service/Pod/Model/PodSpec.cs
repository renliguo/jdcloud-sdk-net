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

namespace JDCloudSDK.Pod.Model
{

    /// <summary>
    ///  指定的创建 pod 参数
    /// </summary>
    public class PodSpec
    {

        ///<summary>
        /// Pod名称
        ///Required:true
        ///</summary>
        [Required]
        public string Name{ get; set; }
        ///<summary>
        /// 描述信息，默认为空；允许输入UTF-8编码下的全部字符，不超过256字符。
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 主机名；范围：[1-63]个ASCII字符，默认值为 podId
        ///</summary>
        public string Hostname{ get; set; }
        ///<summary>
        /// pod中容器重启策略；Always, OnFailure, Never；默认：Always
        ///</summary>
        public string RestartPolicy{ get; set; }
        ///<summary>
        /// 优雅关机宽限时长，如果超时，则触发强制关机。默认：30s，值不能是负数，范围：[0-300]
        ///</summary>
        public int? TerminationGracePeriodSeconds{ get; set; }
        ///<summary>
        /// 实例类型；参考[文档](https://www.jdcloud.com/help/detail/1992/isCatalog/1)
        ///Required:true
        ///</summary>
        [Required]
        public string InstanceType{ get; set; }
        ///<summary>
        /// 容器所属可用区
        ///Required:true
        ///</summary>
        [Required]
        public string Az{ get; set; }
        ///<summary>
        /// pod内容器的/etc/resolv.conf配置
        ///</summary>
        public DnsConfig DnsConfig{ get; set; }
        ///<summary>
        /// 容器日志配置信息；默认会在本地分配10MB的存储空间
        ///</summary>
        public LogConfig LogConfig{ get; set; }
        ///<summary>
        /// 域名和IP映射的信息；&lt;/br&gt; 最大10个alias
        ///</summary>
        public List<HostAlias> HostAliases{ get; set; }
        ///<summary>
        /// 域名和IP映射的信息；&lt;/br&gt; 最大10个alias
        ///</summary>
        public List<Volume> Volumes{ get; set; }
        ///<summary>
        /// 域名和IP映射的信息；&lt;/br&gt; 最大10个alias
        ///Required:true
        ///</summary>
        [Required]
        public List<ContainerSpec> Containers{ get; set; }
        ///<summary>
        /// 预付费（prepaid_by_duration）, 按配置后付费（postpaid_by_duration）。默认：按配置后付费
        ///</summary>
        public ChargeSpec Charge{ get; set; }
        ///<summary>
        /// 主网卡主IP关联的弹性IP规格
        ///</summary>
        public ElasticIp ElasticIp{ get; set; }
        ///<summary>
        /// 主网卡配置信息
        ///Required:true
        ///</summary>
        [Required]
        public NetworkInterfaceAttachmentSpec PrimaryNetworkInterface{ get; set; }
    }
}
