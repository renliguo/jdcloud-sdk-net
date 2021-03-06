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

namespace JDCloudSDK.Monitor.Model
{

    /// <summary>
    ///  dimension
    /// </summary>
    public class Dimension
    {

        ///<summary>
        /// 维度
        ///</summary>
        [JsonProperty("dimension")]
        public string DimensionValue{ get; set; }
        ///<summary>
        /// 维度名称
        ///</summary>
        public string DimensionName{ get; set; }
        ///<summary>
        /// 是否是子结点
        ///</summary>
        public bool IsNode{ get; set; }
        ///<summary>
        /// 对应标签服务的serviceCode
        ///</summary>
        public string TagServiceCode{ get; set; }
        ///<summary>
        /// tags
        ///</summary>
        public Dictionary<String,string> Tags{ get; set; }
    }
}
