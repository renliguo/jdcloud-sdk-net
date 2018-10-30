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


namespace JDCloudSDK.Clouddnsservice.Model
{

    /// <summary>
    ///  nS
    /// </summary>
    public class NS
    {

        ///<summary>
        /// 0-&gt;京东NS服务器，1-&gt;非京东服务器
        ///</summary>
        public int? Tag{ get; set; }
        ///<summary>
        /// NS记录的值
        ///</summary>
        public string Server{ get; set; }
    }
}
