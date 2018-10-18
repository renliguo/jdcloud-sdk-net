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

namespace JDCloudSDK.Monitor.Model
{

    /// <summary>
    ///  batchCreateAlarmsSpec
    /// </summary>
    public class BatchCreateAlarmsSpec
    {

        ///<summary>
        /// 幂等性校验参数，最长36位
        ///Required:true
        ///</summary>
        [Required]
        public string ClientToken{ get; set; }
        ///<summary>
        /// 通知的联系人
        ///</summary>
        public List<BaseContact> Contacts{ get; set; }
        ///<summary>
        /// 地域
        ///</summary>
        public string Datacenter{ get; set; }
        ///<summary>
        /// 报警规则对应实例列表，每次最多100个，例如&quot;[&#39;resourceId1&#39;,&#39;resourceId2&#39;]&quot;
        ///Required:true
        ///</summary>
        [Required]
        public List<string> ResourceIds{ get; set; }
        ///<summary>
        /// 规则类型, 1表示资源监控，6表示站点监控，默认为1
        ///</summary>
        public long? RuleType{ get; set; }
        ///<summary>
        /// 要批量创建的规则列表
        ///Required:true
        ///</summary>
        [Required]
        public List<BaseRule> Rules{ get; set; }
        ///<summary>
        /// 是否保存为模板
        ///</summary>
        public bool SaveTemplate{ get; set; }
        ///<summary>
        /// 产品线标识，规则对应的serviceCode
        ///Required:true
        ///</summary>
        [Required]
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 模板名称，保存模板时，不能为空
        ///</summary>
        public string TemplateName{ get; set; }
        ///<summary>
        /// 产品线标识，保存为模板时，模板对应的serviceCode
        ///</summary>
        public string TemplateServiceCode{ get; set; }
        ///<summary>
        /// 回调content 注：仅webHookUrl和webHookContent均不为空时，才会创建webHook
        ///</summary>
        public string WebHookContent{ get; set; }
        ///<summary>
        /// webHook协议
        ///</summary>
        public string WebHookProtocol{ get; set; }
        ///<summary>
        /// 回调secret，用户请求签名，防伪造
        ///</summary>
        public string WebHookSecret{ get; set; }
        ///<summary>
        /// 回调url
        ///</summary>
        public string WebHookUrl{ get; set; }
    }
}