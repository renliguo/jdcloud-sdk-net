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


namespace JDCloudSDK.Logs.Model
{

    /// <summary>
    ///  collectInfoDetailEnd
    /// </summary>
    public class CollectInfoDetailEnd
    {

        ///<summary>
        /// UID
        ///</summary>
        public string UID{ get; set; }
        ///<summary>
        /// 日志来源，只能是 custom
        ///</summary>
        public string AppCode{ get; set; }
        ///<summary>
        /// Detail
        ///</summary>
        public CollectTempalteEnd Detail{ get; set; }
        ///<summary>
        /// Enabled
        ///</summary>
        public long? Enabled{ get; set; }
        ///<summary>
        /// 采集实例类型, 只能是 all/part
        ///</summary>
        public string ResourceType{ get; set; }
        ///<summary>
        /// 采集实例数量
        ///</summary>
        public long? ResourcesCount{ get; set; }
        ///<summary>
        /// 产品线
        ///</summary>
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 日志类型名称
        ///</summary>
        public string TemplateName{ get; set; }
        ///<summary>
        /// 日志类型
        ///</summary>
        public string TemplateUID{ get; set; }
    }
}
