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


namespace JDCloudSDK.Clouddnsservice.Model
{

    /// <summary>
    ///  addRR
    /// </summary>
    public class AddRR
    {

        ///<summary>
        /// 主机记录
        ///</summary>
        public string HostRecord{ get; set; }
        ///<summary>
        /// 解析记录的值
        ///</summary>
        public string HostValue{ get; set; }
        ///<summary>
        /// 是否是京东云资源
        ///</summary>
        public bool JcloudRes{ get; set; }
        ///<summary>
        /// 优先级，只存在于MX, SRV解析记录类型
        ///</summary>
        public int? MxPriority{ get; set; }
        ///<summary>
        /// 端口，只存在于SRV解析记录类型
        ///</summary>
        public int? Port{ get; set; }
        ///<summary>
        /// 解析记录的生存时间
        ///</summary>
        public int? Ttl{ get; set; }
        ///<summary>
        /// 解析的类型
        ///</summary>
        public string Type{ get; set; }
        ///<summary>
        /// 解析记录的权重
        ///</summary>
        public int? Weight{ get; set; }
        ///<summary>
        /// 解析线路的ID
        ///</summary>
        public int? ViewValue{ get; set; }
    }
}
