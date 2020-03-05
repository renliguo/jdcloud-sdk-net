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


namespace JDCloudSDK.Vpc.Model
{

    /// <summary>
    ///  modifyNatGatewaySpec
    /// </summary>
    public class ModifyNatGatewaySpec
    {

        ///<summary>
        /// NAT网关名称
        ///</summary>
        public string NatGatewayName{ get; set; }
        ///<summary>
        /// 描述,允许输入UTF-8编码下的全部字符，不超过256字符
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 公网IP的限速（单位：Mbps），取值范围为[1-1000]
        ///</summary>
        public int? BandwidthMbps{ get; set; }
        ///<summary>
        /// NAT网关规格，取值small（100万并发连接数）,medium(300万并发连接数),large（1000万并发连接数）
        ///</summary>
        public string NatGatewaySpec{ get; set; }
    }
}