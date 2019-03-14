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

namespace JDCloudSDK.Pod.Model
{

    /// <summary>
    ///  tcpSocket
    /// </summary>
    public class TcpSocket
    {

        ///<summary>
        /// 连接到pod的host信息，默认使用pod_ip
        ///</summary>
        public string Host{ get; set; }
        ///<summary>
        /// 范围：[1-65535]
        ///Required:true
        ///</summary>
        [Required]
        public int Port{ get; set; }
    }
}
