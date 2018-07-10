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

using JDCloudSDK.Charge.Model;

namespace JDCloudSDK.Bds.Model
{

    /// <summary>
    /// instance
    /// </summary>
    public class Instance
    {

        ///<summary>
        ///实例ID
        ///</summary>
        public string InstanceId{ get; set; }
        ///<summary>
        ///实例名称
        ///</summary>
        public string InstanceName{ get; set; }
        ///<summary>
        ///可用区ID
        ///</summary>
        public string AzId{ get; set; }
        ///<summary>
        ///虚拟网络ID
        ///</summary>
        public string VpcId{ get; set; }
        ///<summary>
        ///子网ID
        ///</summary>
        public string SubnetId{ get; set; }
        ///<summary>
        ///实例状态
        ///</summary>
        public string InstanceStatus{ get; set; }
        ///<summary>
        ///实例域名
        ///</summary>
        public string InstanceDomain{ get; set; }
        ///<summary>
        ///实例端口
        ///</summary>
        public int? InstancePort{ get; set; }
        ///<summary>
        ///任务列表
        ///</summary>
        public List<Object> Tasks{ get; set; }
        ///<summary>
        ///机型配置
        ///</summary>
        public Object Flavor{ get; set; }
        ///<summary>
        ///计费配置
        ///</summary>
        public JDCloudSDK.Charge.Model.Charge Charge{ get; set; }
        ///<summary>
        ///创建时间
        ///</summary>
        public string CreatedTime{ get; set; }
        ///<summary>
        ///更新时间
        ///</summary>
        public string UpdatedTime{ get; set; }
    }
}
