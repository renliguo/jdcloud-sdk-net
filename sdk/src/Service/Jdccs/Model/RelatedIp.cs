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


namespace JDCloudSDK.Jdccs.Model
{

    /// <summary>
    ///  关联的公网IP
    /// </summary>
    public class RelatedIp
    {

        ///<summary>
        /// IP地址段
        ///</summary>
        public string CidrAddr{ get; set; }
        ///<summary>
        /// 线路类型 bgp:BGP telecom:电信单线 unicom:联通单线 mobile:移动单线
        ///</summary>
        public string LineType{ get; set; }
    }
}
