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


namespace JDCloudSDK.Monitor.Model
{

    /// <summary>
    ///  nsInfo
    /// </summary>
    public class NsInfo
    {

        ///<summary>
        /// metric个数
        ///</summary>
        public long? MetricCount{ get; set; }
        ///<summary>
        /// 命名空间名称
        ///</summary>
        public string NsName{ get; set; }
        ///<summary>
        /// 命名空间uid
        ///</summary>
        public string NsUid{ get; set; }
        ///<summary>
        /// obj个数
        ///</summary>
        public long? ObjCount{ get; set; }
    }
}