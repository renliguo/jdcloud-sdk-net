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

using Newtonsoft.Json;

namespace JDCloudSDK.Jdw.Model
{

    /// <summary>
    ///  nodeType
    /// </summary>
    public class NodeType
    {

        ///<summary>
        /// 节点规格代码
        ///</summary>
        [JsonProperty("nodeType")]
        public string NodeTypeValue{ get; set; }
        ///<summary>
        /// CPU核数
        ///</summary>
        public int? Cpu{ get; set; }
        ///<summary>
        /// 内存容量，单位GB
        ///</summary>
        public int? Memory{ get; set; }
        ///<summary>
        /// 存储空间容量，单位GB
        ///</summary>
        public int? Storage{ get; set; }
        ///<summary>
        /// 最小节点数量
        ///</summary>
        public int? MiniNodeNumber{ get; set; }
        ///<summary>
        /// 最大节点数量
        ///</summary>
        public int? MaxNodeNumber{ get; set; }
    }
}
