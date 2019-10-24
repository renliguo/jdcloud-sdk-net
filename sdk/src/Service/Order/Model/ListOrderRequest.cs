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
    ///  listOrderRequest
    /// </summary>
    public class ListOrderRequest
    {

        ///<summary>
        /// 业务线
        ///</summary>
        public string AppCode{ get; set; }
        ///<summary>
        /// 计费类型(CONFIG-按配置,FLOW-按用量MONTHLY-包年包月,ONCE-按次付费)
        ///</summary>
        public string ChargeMode{ get; set; }
        ///<summary>
        /// 查询订单开始时间戳
        ///</summary>
        public long? StartTime{ get; set; }
        ///<summary>
        /// 查询订单结束时间戳
        ///</summary>
        public long? EndTime{ get; set; }
        ///<summary>
        /// 购买订单类型(NEW-新购,RENEW-续费,RESIZE_FORMULA-配置变更,TEMP_UPGRADE-临时升配)
        ///</summary>
        public string OrderType{ get; set; }
        ///<summary>
        /// 分页：订单第几页
        ///</summary>
        public int? PageNumber{ get; set; }
        ///<summary>
        /// 分页：订单条数
        ///</summary>
        public int? PageSize{ get; set; }
        ///<summary>
        /// 付费类型(PRE_PAID-预付费,POST_PAID-后付费)
        ///</summary>
        public string PayType{ get; set; }
        ///<summary>
        /// 产品线
        ///</summary>
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 订单状态（PAID-已支付,CANCELED-已取消,NO_PAY-未支付,FAILED-失败,DEALING-处理中,REFUND_PART-部分退款,REFUND_ALL-全部退款）
        ///</summary>
        public string Status{ get; set; }
    }
}