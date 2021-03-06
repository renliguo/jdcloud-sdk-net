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


namespace JDCloudSDK.Es.Model
{

    /// <summary>
    ///  instanceClassSpec
    /// </summary>
    public class InstanceClassSpec
    {

        ///<summary>
        /// data节点规格代码，详细规格请参考：https://docs.jdcloud.com/cn/jcs-for-elasticsearch/specifications
        ///</summary>
        public string NodeClass{ get; set; }
        ///<summary>
        /// data节点存储大小，单位GB。单点存储规格范围20-4000GB，只允许输入整数且步长为10GB，
        ///</summary>
        public int? NodeDiskGB{ get; set; }
        ///<summary>
        /// data节点存储类型，包括zbs(性能型SSD云盘)、ssd.gp1(通用型SSD云盘)、hdd.std1(容量型HDD云盘)，默认zbs
        ///</summary>
        public string NodeDiskType{ get; set; }
        ///<summary>
        /// data节点数量，各region和可用区的节点数量规格限制不完全相同，详情请参考：https://docs.jdcloud.com/cn/jcs-for-elasticsearch/restrictions
        ///</summary>
        public int? NodeCount{ get; set; }
        ///<summary>
        /// master节点规格代码，与data节点规格代码一致。
        ///</summary>
        public string MasterClass{ get; set; }
        ///<summary>
        /// master节点存储大小，固定为20GB，不可调整
        ///</summary>
        public int? MasterDiskGB{ get; set; }
        ///<summary>
        /// master节点存储类型，默认zbs
        ///</summary>
        public string MasterDiskType{ get; set; }
        ///<summary>
        /// master节点数量，固定为3，不可调整
        ///</summary>
        public int? MasterCount{ get; set; }
        ///<summary>
        /// coordinating节点规格代码，与data节点规格代码一致。
        ///</summary>
        public string CoordinatingClass{ get; set; }
        ///<summary>
        /// coordinating节点存储大小，固定为20GB，不可调整
        ///</summary>
        public int? CoordinatingDiskGB{ get; set; }
        ///<summary>
        /// coordinating存储类型，默认zbs
        ///</summary>
        public string CoordinatingDiskType{ get; set; }
        ///<summary>
        /// coordinating节点数量，各region和可用区的节点数量规格限制不完全相同，详情请参考：https://docs.jdcloud.com/cn/jcs-for-elasticsearch/restrictions
        ///</summary>
        public int? CoordinatingCount{ get; set; }
    }
}
