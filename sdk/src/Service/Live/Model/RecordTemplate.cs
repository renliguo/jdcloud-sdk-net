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


namespace JDCloudSDK.Live.Model
{

    /// <summary>
    ///  recordTemplate
    /// </summary>
    public class RecordTemplate
    {

        ///<summary>
        /// 自动录制周期
        /// - 取值:[15,360]
        /// - 单位: 分钟
        /// 
        ///</summary>
        public int? RecordPeriod{ get; set; }
        ///<summary>
        /// 存储桶
        ///</summary>
        public string SaveBucket{ get; set; }
        ///<summary>
        /// 存储地址
        ///</summary>
        public string SaveEndpoint{ get; set; }
        ///<summary>
        /// 录制文件格式
        /// - 取值: ts,flv,mp4 (多种类型之前用;隔开)
        /// - 不区分大小写
        /// 
        ///</summary>
        public string RecordFileType{ get; set; }
        ///<summary>
        /// 录制模板
        /// - 取值要求：数字、大小写字母或短横线(&quot;-&quot;),
        ///           首尾不能有特殊字符(&quot;-&quot;)
        /// - &lt;b&gt;注意: 不能与已定义命名重复&lt;/b&gt;
        /// 
        ///</summary>
        public string Template{ get; set; }
    }
}
