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


namespace JDCloudSDK.Pod.Model
{

    /// <summary>
    ///  主网卡配置信息。
    /// </summary>
    public class NetworkInterfaceAttachment
    {

        ///<summary>
        /// 指明删除pod时是否删除网卡。
        ///</summary>
        public bool AutoDelete{ get; set; }
        ///<summary>
        /// 设备Index，目前pod只支持一个网卡，所以只能设置为1
        ///</summary>
        public int? DeviceIndex{ get; set; }
        ///<summary>
        /// 绑定状态
        ///</summary>
        public string AttachStatus{ get; set; }
        ///<summary>
        /// 绑定时间
        ///</summary>
        public string AttachTime{ get; set; }
        ///<summary>
        /// 网卡接口规范
        ///</summary>
        public InstanceNetworkInterface NetworkInterface{ get; set; }
    }
}
