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


namespace JDCloudSDK.Jdro.Model
{

    /// <summary>
    ///  resourceOut
    /// </summary>
    public class ResourceOut
    {

        ///<summary>
        /// 资源运行操作
        ///</summary>
        public string Action{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 删除策略
        ///</summary>
        public string DeletePolicy{ get; set; }
        ///<summary>
        /// 删除时间
        ///</summary>
        public DateTime? DeleteTime{ get; set; }
        ///<summary>
        /// 资源逻辑ID
        ///</summary>
        public string LogicId{ get; set; }
        ///<summary>
        /// 资源ID
        ///</summary>
        public string PhysicalId{ get; set; }
        ///<summary>
        /// 地域信息
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// Snapshot信息，仅针对磁盘资源类型
        ///</summary>
        public string Snapshot{ get; set; }
        ///<summary>
        /// 资源栈ID
        ///</summary>
        public string StackId{ get; set; }
        ///<summary>
        /// 资源运行状态
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 资源运行状态原因
        ///</summary>
        public string StatusReason{ get; set; }
        ///<summary>
        /// 资源类型
        ///</summary>
        public string Type{ get; set; }
        ///<summary>
        /// 更新时间
        ///</summary>
        public DateTime? UpdateTime{ get; set; }
    }
}