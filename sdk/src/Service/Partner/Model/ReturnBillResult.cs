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
 * returnBill
 * 渠道管理平台返还单
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Partner.Model
{

    /// <summary>
    ///  returnBillResult
    /// </summary>
    public class ReturnBillResult
    {

        ///<summary>
        /// ID
        ///</summary>
        public double? Id{ get; set; }
        ///<summary>
        /// 返还单号
        ///</summary>
        public string RetrunBillId{ get; set; }
        ///<summary>
        /// 服务商ID
        ///</summary>
        public string DistributorId{ get; set; }
        ///<summary>
        /// 服务商名称
        ///</summary>
        public string DistributorName{ get; set; }
        ///<summary>
        /// 渠道商类型
        ///</summary>
        public int? DistributorType{ get; set; }
        ///<summary>
        /// month
        ///</summary>
        public string Month{ get; set; }
        ///<summary>
        /// 生成时间
        ///</summary>
        public string GenerateTime{ get; set; }
        ///<summary>
        /// 开始时间
        ///</summary>
        public string BillBegin{ get; set; }
        ///<summary>
        /// 结束时间
        ///</summary>
        public string BillEnd{ get; set; }
        ///<summary>
        /// 周期类型
        ///</summary>
        public int? CircleType{ get; set; }
        ///<summary>
        /// 返还类型
        ///</summary>
        public int? ReturnType{ get; set; }
        ///<summary>
        /// 返还类型名称
        ///</summary>
        public string ReturnTypeName{ get; set; }
        ///<summary>
        /// 返还金额
        ///</summary>
        public double? ReturnMount{ get; set; }
        ///<summary>
        /// 次数
        ///</summary>
        public int? RedoQty{ get; set; }
        ///<summary>
        /// 状态
        ///</summary>
        public int? Status{ get; set; }
        ///<summary>
        /// 状态名称
        ///</summary>
        public string StatusName{ get; set; }
        ///<summary>
        /// 驳回原因
        ///</summary>
        public string Reason{ get; set; }
        ///<summary>
        /// 部门ID
        ///</summary>
        public int? DeptId{ get; set; }
        ///<summary>
        /// 部门名称
        ///</summary>
        public string DeptName{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public string CreateTime{ get; set; }
        ///<summary>
        /// 创建人
        ///</summary>
        public string CreateUser{ get; set; }
        ///<summary>
        /// 修改时间
        ///</summary>
        public string UpdateTime{ get; set; }
        ///<summary>
        /// 修改人
        ///</summary>
        public string UpdateUser{ get; set; }
        ///<summary>
        /// 是否删除0未删除,1已删除
        ///</summary>
        public int? Yn{ get; set; }
        ///<summary>
        /// 返还单明细
        ///</summary>
        public List<ReturnBillDetailResult> ReturnBillDetailList{ get; set; }
        ///<summary>
        /// 返还单状态
        ///</summary>
        public List<ReturnBillStatusResult> ReturnBillStatusList{ get; set; }
    }
}
