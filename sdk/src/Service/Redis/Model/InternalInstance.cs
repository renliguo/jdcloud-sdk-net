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


namespace JDCloudSDK.Redis.Model
{

    /// <summary>
    ///  internalInstance
    /// </summary>
    public class InternalInstance
    {

        ///<summary>
        /// pin
        ///</summary>
        public string Pin{ get; set; }
        ///<summary>
        /// region
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// 实例ID
        ///</summary>
        public string InstanceId{ get; set; }
        ///<summary>
        /// 实例名称
        ///</summary>
        public string InstanceName{ get; set; }
        ///<summary>
        /// 实例类型：master-slave表示主从版，cluster表示集群版
        ///</summary>
        public string InstanceType{ get; set; }
        ///<summary>
        /// 实例状态：creating表示创建中，running表示运行中，error表示错误，changing表示变更规格中，deleting表示删除中，configuring表示修改参数中，restoring表示备份恢复中
        ///</summary>
        public string InstanceStatus{ get; set; }
        ///<summary>
        /// 实例版本：包括2.8、4.0
        ///</summary>
        public string InstanceVersion{ get; set; }
        ///<summary>
        /// 创建时间（ISO 8601标准的UTC时间，格式为：YYYY-MM-DDTHH:mm:ssZ）
        ///</summary>
        public DateTime? CreatedTime{ get; set; }
        ///<summary>
        /// 所属VPC的ID
        ///</summary>
        public string VpcId{ get; set; }
        ///<summary>
        /// 所属子网的ID
        ///</summary>
        public string SubnetId{ get; set; }
        ///<summary>
        /// 访问域名
        ///</summary>
        public string ConnectionDomain{ get; set; }
        ///<summary>
        /// 访问端口
        ///</summary>
        public int? ConnectionPort{ get; set; }
        ///<summary>
        /// 连接redis实例时，是否需要密码认证，false表示无密码
        ///</summary>
        public bool Auth{ get; set; }
        ///<summary>
        /// 前端app ip
        ///</summary>
        public string FrontAppIp{ get; set; }
        ///<summary>
        /// 实例内部节点ip列表
        ///</summary>
        public List<string> Ips{ get; set; }
        ///<summary>
        /// 实例内部节点所在宿主机ip列表
        ///</summary>
        public List<string> HostIps{ get; set; }
    }
}
