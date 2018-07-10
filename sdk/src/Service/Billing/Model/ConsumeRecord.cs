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


namespace JDCloudSDK.Billing.Model
{

    /// <summary>
    /// consumeRecord
    /// </summary>
    public class ConsumeRecord
    {

        ///<summary>
        ///消费记录数据库唯一id
        ///</summary>
        public double? Id{ get; set; }
        ///<summary>
        ///消费记录id
        ///</summary>
        public int? BillingRecordId{ get; set; }
        ///<summary>
        ///appCode
        ///</summary>
        public string AppCode{ get; set; }
        ///<summary>
        ///serviceCode
        ///</summary>
        public string ServiceCode{ get; set; }
        ///<summary>
        ///区域
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        ///资源id
        ///</summary>
        public string ResourceId{ get; set; }
        ///<summary>
        ///用户pin
        ///</summary>
        public string Pin{ get; set; }
        ///<summary>
        ///规格
        ///</summary>
        public string Formula{ get; set; }
        ///<summary>
        ///计费类型
        ///</summary>
        public int? BillingType{ get; set; }
        ///<summary>
        ///价格快照
        ///</summary>
        public string PriceSnapShot{ get; set; }
        ///<summary>
        ///开始时间
        ///</summary>
        public string StartTime{ get; set; }
        ///<summary>
        ///结束时间
        ///</summary>
        public string EndTime{ get; set; }
        ///<summary>
        ///创建日期
        ///</summary>
        public string CreateTime{ get; set; }
        ///<summary>
        ///账单金额
        ///</summary>
        public double? BillFee{ get; set; }
        ///<summary>
        ///账单金额保留小数点后2位
        ///</summary>
        public double? BillFee2{ get; set; }
        ///<summary>
        ///折扣金额
        ///</summary>
        public double? DiscountFee{ get; set; }
        ///<summary>
        ///优惠券id
        ///</summary>
        public string CouponId{ get; set; }
        ///<summary>
        ///优惠金额
        ///</summary>
        public double? CouponFee{ get; set; }
        ///<summary>
        ///交易单号
        ///</summary>
        public string TransactionNo{ get; set; }
        ///<summary>
        ///null
        ///</summary>
        public int? IsBillGenerated{ get; set; }
        ///<summary>
        ///子账单id
        ///</summary>
        public double? SubBillId{ get; set; }
        ///<summary>
        ///退款单号
        ///</summary>
        public string RefundNo{ get; set; }
    }
}
