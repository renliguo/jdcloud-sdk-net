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

namespace JDCloudSDK.Vpcwaf.Model
{

    /// <summary>
    /// 恶意IP封禁配置
    /// </summary>
    public class MaliciousIPEngineConfig
    {

        ///<summary>
        ///配置Id
        ///Required:true
        ///</summary>
        [Required]
        public string ConfigId{ get; set; }
        ///<summary>
        ///状态(0:停用;1:启用)
        ///</summary>
        public int? Status{ get; set; }
        ///<summary>
        ///攻击阈值
        ///</summary>
        public int? Threshold{ get; set; }
        ///<summary>
        ///统计时间间隔(单位:分钟)
        ///</summary>
        public int? Interval{ get; set; }
        ///<summary>
        ///封禁时间(单位:秒)
        ///</summary>
        public int? BlockTime{ get; set; }
    }
}
