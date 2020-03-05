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

namespace JDCloudSDK.Cloudauth.Model
{

    /// <summary>
    ///  accountInfo
    /// </summary>
    public class AccountInfo
    {

        ///<summary>
        /// 组织名称
        ///Required:true
        ///</summary>
        [Required]
        public string OrgName{ get; set; }
        ///<summary>
        /// 身份证号码
        ///</summary>
        public string IdCard{ get; set; }
        ///<summary>
        /// 银行卡号
        ///Required:true
        ///</summary>
        [Required]
        public string BankCardNum{ get; set; }
        ///<summary>
        /// 银行名称
        ///Required:true
        ///</summary>
        [Required]
        public string BankName{ get; set; }
        ///<summary>
        /// 支行名称
        ///Required:true
        ///</summary>
        [Required]
        public string BranchBankName{ get; set; }
        ///<summary>
        /// 银行代码
        ///</summary>
        public string BankCode{ get; set; }
        ///<summary>
        /// 城市代码
        ///</summary>
        public string CityCode{ get; set; }
        ///<summary>
        /// 省份代码
        ///</summary>
        public string ProvinceCode{ get; set; }
    }
}