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
 * 非网站转发配置相关接口
 * 非网站转发配置相关接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Ipanti.Model;
using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Ipanti.Apis
{

    /// <summary>
    /// 添加非网站类规则
    /// </summary>
    public class CreateForwardRuleRequest : JdcloudRequest
    {
        ///<summary>
        ///非网站类规则参数
        ///Required:true
        ///</summary>
        [Required]
        public   ForwardRuleSpec ForwardRuleSpec{ get; set; }
        ///<summary>
        ///Region ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        ///实例id
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
    }
}