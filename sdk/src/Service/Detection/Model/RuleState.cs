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


namespace JDCloudSDK.Detection.Model
{

    /// <summary>
    ///  ruleState
    /// </summary>
    public class RuleState
    {

        ///<summary>
        /// 资源id
        ///</summary>
        public string ResourceId{ get; set; }
        ///<summary>
        /// 规则个数
        ///</summary>
        public long? RuleCount{ get; set; }
        ///<summary>
        /// 资源的规则状态。1：正常、 2：报警、4：数据不足 -1:没有规则 -2:未启用
        ///</summary>
        public long? State{ get; set; }
    }
}
