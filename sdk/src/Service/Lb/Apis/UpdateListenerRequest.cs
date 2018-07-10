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
 * 监听器资源
 * 监听器资源相关接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Lb.Model;
using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Lb.Apis
{

    /// <summary>
    /// 修改一个监听器实例的信息
    /// </summary>
    public class UpdateListenerRequest : JdcloudRequest
    {
        ///<summary>
        ///监听器名字,只允许输入中文、数字、大小写字母、英文下划线“_”及中划线“-”，不允许为空且不超过32字符
        ///</summary>
        public   string ListenerName{ get; set; }
        ///<summary>
        ///Listener状态, 取值为On或者为Off
        ///</summary>
        public   string Status{ get; set; }
        ///<summary>
        ///【alb Https和Tls协议】ssl server证书列表，现只支持一个证书
        ///</summary>
        public List<CertificateSpec> CertificateSpecs{ get; set; }

        ///<summary>
        ///连接保持时间, &gt;&#x3D;1，范围为[1,86400]
        ///</summary>
        public   double? ConnectionIdleTimeSeconds{ get; set; }
        ///<summary>
        ///默认后端服务id
        ///</summary>
        public   string BackendId{ get; set; }
        ///<summary>
        ///监听器描述,允许输入UTF-8编码下的全部字符，不超过256字符
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        ///Region ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        ///监听器ID
        ///Required:true
        ///</summary>
        [Required]
        public   string ListenerId{ get; set; }
    }
}