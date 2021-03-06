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
    ///  dashboardInfo
    /// </summary>
    public class DashboardInfo
    {

        ///<summary>
        /// Description
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// Id
        ///</summary>
        public long? Id{ get; set; }
        ///<summary>
        /// Tags
        ///</summary>
        public List<string> Tags{ get; set; }
        ///<summary>
        /// Timezone
        ///</summary>
        public string Timezone{ get; set; }
        ///<summary>
        /// Title
        ///</summary>
        public string Title{ get; set; }
        ///<summary>
        /// Uid
        ///</summary>
        public string Uid{ get; set; }
        ///<summary>
        /// VersionValue
        ///</summary>
        [JsonProperty("version")]
        public long? VersionValue{ get; set; }
    }
}
