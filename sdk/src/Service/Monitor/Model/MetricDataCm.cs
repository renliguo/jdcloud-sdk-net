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

namespace JDCloudSDK.Monitor.Model
{

    /// <summary>
    ///  metricDataCm
    /// </summary>
    public class MetricDataCm
    {

        ///<summary>
        /// 命名空间 ，长度不超过255字节，只允许英文、数字、下划线_、点., [0-9][a-z] [A-Z] [. _ ]，  其它会返回err
        ///Required:true
        ///</summary>
        [Required]
        public string Namespace{ get; set; }
        ///<summary>
        /// 监控指标名称，长度不超过255字节，只允许英文、数字、下划线_、点.,  [0-9][a-z] [A-Z] [. _ ]， 其它会返回err
        ///Required:true
        ///</summary>
        [Required]
        public string Metric{ get; set; }
        ///<summary>
        /// 数据维度，数据类型为map类型，支持最少一个，最多6个标签，总长度不大于1024字节，只允许英文、数字、下划线_、点., [0-9][a-z] [A-Z] [. _ ]，  其它会返回err。eg:{&quot;host&quot;:&quot;127.0.0.1&quot;,&quot;region&quot;:&quot;cn-north-1&quot;,&quot;role&quot;:&quot;M&quot;}
        ///Required:true
        ///</summary>
        [Required]
        public Dictionary<String,string> Dimensions{ get; set; }
        ///<summary>
        /// 上报数据点的时间戳,只支持10位，秒级时间戳，不能写入过去30天的时间
        ///Required:true
        ///</summary>
        [Required]
        public long Timestamp{ get; set; }
        ///<summary>
        /// 数据上报类型，1为原始值
        ///Required:true
        ///</summary>
        [Required]
        public int Type{ get; set; }
        ///<summary>
        /// 指标值集合，数据类型必须为map类型，key为数据类型，value为数据值，当type&#x3D;1时，key只能为”value”，上报的是原始值，value内容为整型或浮点型数字，最大值为9223372036854775807
        ///Required:true
        ///</summary>
        [Required]
        public Dictionary<String,string> Values{ get; set; }
        ///<summary>
        /// 数据的单位，长度不超过64字节，只允许英文、数字、下划线_、点., [0-9][a-z] [A-Z] [. _ ]，  其它会返回err
        ///</summary>
        public string Unit{ get; set; }
    }
}
