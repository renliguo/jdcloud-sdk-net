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
 * invoices相关接口
 * API related to invoices
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

using JDCloudSDK.Ucapi.Model;

namespace  JDCloudSDK.Ucapi.Apis
{

    /// <summary>
    /// 获取发票资质模板信息
    /// </summary>
    public class DescribeInvoiceMsgTemplateResult : JdcloudResult
    {
        ///<summary>
        ///发票资质模板信息
        ///</summary>
        public   InvoiceMsgTemplate InvoiceMsgTemplate{ get; set; }
        ///<summary>
        ///用户类型
        ///</summary>
        public   int? UserType{ get; set; }
        ///<summary>
        ///企业增值税专用发票资质信息
        ///</summary>
        public   VatQualification Vat{ get; set; }
    }
}