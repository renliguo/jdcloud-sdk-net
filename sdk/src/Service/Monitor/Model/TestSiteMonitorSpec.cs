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
    ///  testSiteMonitorSpec
    /// </summary>
    public class TestSiteMonitorSpec
    {

        ///<summary>
        /// Address
        ///</summary>
        public string Address{ get; set; }
        ///<summary>
        /// AdvanceChecked
        ///</summary>
        public string AdvanceChecked{ get; set; }
        ///<summary>
        /// CreatedTime
        ///</summary>
        public long? CreatedTime{ get; set; }
        ///<summary>
        /// Cycle
        ///</summary>
        public long? Cycle{ get; set; }
        ///<summary>
        /// DefaultSource
        ///</summary>
        public string DefaultSource{ get; set; }
        ///<summary>
        /// Enabled
        ///</summary>
        public string Enabled{ get; set; }
        ///<summary>
        /// FtpOption
        ///</summary>
        public SiteMonitorFtpOption FtpOption{ get; set; }
        ///<summary>
        /// HawkeyeId
        ///</summary>
        public long? HawkeyeId{ get; set; }
        ///<summary>
        /// HttpOption
        ///</summary>
        public SiteMonitorHttpOption HttpOption{ get; set; }
        ///<summary>
        /// Id
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// IsDeleted
        ///</summary>
        public string IsDeleted{ get; set; }
        ///<summary>
        /// Name
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// Pin
        ///</summary>
        public string Pin{ get; set; }
        ///<summary>
        /// Port
        ///</summary>
        public string Port{ get; set; }
        ///<summary>
        /// SmtpOption
        ///</summary>
        public SiteMonitorSmtpOption SmtpOption{ get; set; }
        ///<summary>
        /// Source
        ///</summary>
        public List<SiteMonitorSource> Source{ get; set; }
        ///<summary>
        /// Stats
        ///</summary>
        public Dictionary<String,object> Stats{ get; set; }
        ///<summary>
        /// TaskType
        ///</summary>
        public string TaskType{ get; set; }
        ///<summary>
        /// TcpOption
        ///</summary>
        public SiteMonitorTcpOption TcpOption{ get; set; }
        ///<summary>
        /// UdpOption
        ///</summary>
        public SiteMonitorUdpOption UdpOption{ get; set; }
        ///<summary>
        /// UpdatedTime
        ///</summary>
        public long? UpdatedTime{ get; set; }
    }
}
