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

namespace JDCloudSDK.Apigateway.Model
{

    /// <summary>
    ///  apiChargeSpecView
    /// </summary>
    public class ApiChargeSpecView
    {

        ///<summary>
        /// appCode
        ///</summary>
        public string AppCode{ get; set; }
        ///<summary>
        /// serviceCode
        ///</summary>
        public string ServiceCode{ get; set; }
        ///<summary>
        /// api中心展示，1展示，0 不展示 默认不展示
        ///</summary>
        public int? ShowStatus{ get; set; }
        ///<summary>
        /// 计费类型 0 标准计费 1 阶梯计费
        ///</summary>
        public int? ChargeType{ get; set; }
        ///<summary>
        /// 计费方式 0 200请求计费 1 后端处理计费
        ///</summary>
        public int? AccessSuccessType{ get; set; }
        ///<summary>
        /// 请求参数列表
        ///Required:true
        ///</summary>
        [Required]
        public List<ApiChargeSpec> ApiChargeSpecs{ get; set; }
    }
}
