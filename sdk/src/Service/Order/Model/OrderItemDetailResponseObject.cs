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
 * 相关接口
 * API related to order
 *
 * OpenAPI spec version: v2
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Order.Model
{

    /// <summary>
    ///  orderItemDetailResponseObject
    /// </summary>
    public class OrderItemDetailResponseObject
    {

        ///<summary>
        /// 订单总金额
        ///</summary>
        public double? TotalFee{ get; set; }
        ///<summary>
        /// 应付金额（订单总金额-折扣金额）
        ///</summary>
        public double? ActualFee{ get; set; }
        ///<summary>
        /// 余额支付金额
        ///</summary>
        public double? BalancePay{ get; set; }
        ///<summary>
        /// 计费时长
        ///</summary>
        public int? ChargeDuration{ get; set; }
        ///<summary>
        /// 现金支付金额
        ///</summary>
        public double? MoneyPay{ get; set; }
        ///<summary>
        /// 退款金额
        ///</summary>
        public double? RefundFee{ get; set; }
        ///<summary>
        /// 计费类型(CONFIG-按配置,FLOW-按用量MONTHLY-包年包月,ONCE-按次付费)
        ///</summary>
        public string ChargeMode{ get; set; }
        ///<summary>
        /// 订单创建时间（格式：yyyy-MM-dd HH:mm:ss）
        ///</summary>
        public string CreateTime{ get; set; }
        ///<summary>
        /// 续费后资源到期时间（格式：yyyy-MM-dd HH:mm:ss）
        ///</summary>
        public string ExpireDateAfter{ get; set; }
        ///<summary>
        /// 续费前资源到期时间（格式：yyyy-MM-dd HH:mm:ss）
        ///</summary>
        public string ExpireDateBefore{ get; set; }
        ///<summary>
        /// 销售属性
        ///</summary>
        public List<ExtraInfo> ExtraInfo{ get; set; }
        ///<summary>
        /// 续费后资源到期-销售属性
        ///</summary>
        public List<ExtraInfo> ExtraInfoAfter{ get; set; }
        ///<summary>
        /// 续费前资源到期-销售属性
        ///</summary>
        public List<ExtraInfo> ExtraInfoBefore{ get; set; }
        ///<summary>
        /// 代金券金额
        ///</summary>
        public double? FavorableFee{ get; set; }
        ///<summary>
        /// 配置计费项
        ///</summary>
        public string Formula{ get; set; }
        ///<summary>
        /// 资源id
        ///</summary>
        public string ItemId{ get; set; }
        ///<summary>
        /// 资源名称
        ///</summary>
        public string ItemName{ get; set; }
        ///<summary>
        /// 订单号
        ///</summary>
        public string OrderNumber{ get; set; }
        ///<summary>
        /// 价格快照
        ///</summary>
        public string PriceSnapshot{ get; set; }
        ///<summary>
        /// 数量
        ///</summary>
        public int? Quantity{ get; set; }
        ///<summary>
        /// 备注
        ///</summary>
        public string Remark{ get; set; }
        ///<summary>
        /// 变配明细(UP-升配补差价，DOWN-降配延时,MODIFY_CONFIG-调整配置，RENEW-续费，RENEW_UP-续费升配，RENEW_DOWN-续费降配，MONTHLY-配置转包年包月，RENEW_FREE-补偿续费)
        ///</summary>
        public string ResizeFormulaType{ get; set; }
        ///<summary>
        /// 产品名称
        ///</summary>
        public string ServiceName{ get; set; }
        ///<summary>
        /// 站点名称（MAIN_SITE-主站，INTERNATIONAL_SITE-国际站，SUQIAN_DEDICATED_CLOUD-宿迁专有云）
        ///</summary>
        public string SiteType{ get; set; }
        ///<summary>
        /// 资源状态（CREATING-创建中,SUCCESS-成功,FAIL-失败）
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 计费时长单位（HOUR-小时,DAY-天,MONTH-月,YEAR-年）
        ///</summary>
        public string Unit{ get; set; }
        ///<summary>
        /// 子订单
        ///</summary>
        public List<OrderItemDetailResponseObject> OrderItemDetailResponse{ get; set; }
    }
}
