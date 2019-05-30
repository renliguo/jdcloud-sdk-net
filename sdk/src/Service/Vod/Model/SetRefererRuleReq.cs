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
 * Domain Management
 * 域名管理
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Vod.Model
{

    /// <summary>
    ///  设置域名REFERER访问控制规则配置请求消息体
    /// </summary>
    public class SetRefererRuleReq
    {

        ///<summary>
        /// 规则类型，取值 &#39;referer&#39;
        ///</summary>
        public string RuleType{ get; set; }
        ///<summary>
        /// 规则配置对象
        ///</summary>
        public Config Config{ get; set; }
        ///<summary>
        /// 是否启用该规则
        ///</summary>
        public bool Enabled{ get; set; }
    }
}
