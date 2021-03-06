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

namespace JDCloudSDK.Billing.Model
{

    /// <summary>
    ///  billQueryCondition
    /// </summary>
    public class BillQueryCondition
    {

        ///<summary>
        /// 查询类别   1：资源账单   2：消费记录
        ///Required:true
        ///</summary>
        [Required]
        public int QueryType{ get; set; }
        ///<summary>
        /// 用户pin
        ///Required:true
        ///</summary>
        [Required]
        public string Pin{ get; set; }
        ///<summary>
        /// appCode
        ///Required:true
        ///</summary>
        [Required]
        public string AppCode{ get; set; }
        ///<summary>
        /// serviceCode
        ///Required:true
        ///</summary>
        [Required]
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 计费类型
        ///Required:true
        ///</summary>
        [Required]
        public int BillingType{ get; set; }
        ///<summary>
        /// 支付类型
        ///Required:true
        ///</summary>
        [Required]
        public int PayType{ get; set; }
        ///<summary>
        /// 支付状态
        ///Required:true
        ///</summary>
        [Required]
        public int PayState{ get; set; }
        ///<summary>
        /// 1按账期、2按消费时间
        ///Required:true
        ///</summary>
        [Required]
        public int TimeType{ get; set; }
        ///<summary>
        /// 开始时间
        ///Required:true
        ///</summary>
        [Required]
        public string StartTime{ get; set; }
        ///<summary>
        /// 结束时间
        ///Required:true
        ///</summary>
        [Required]
        public string EndTime{ get; set; }
        ///<summary>
        /// 是否忽略0元账单
        ///Required:true
        ///</summary>
        [Required]
        public int IgnoreZero{ get; set; }
        ///<summary>
        /// 资源id
        ///Required:true
        ///</summary>
        [Required]
        public string ResourceId{ get; set; }
        ///<summary>
        /// 站点
        ///Required:true
        ///</summary>
        [Required]
        public int Site{ get; set; }
        ///<summary>
        /// 角色
        ///Required:true
        ///</summary>
        [Required]
        public int Role{ get; set; }
        ///<summary>
        /// 区域
        ///Required:true
        ///</summary>
        [Required]
        public string Region{ get; set; }
    }
}
