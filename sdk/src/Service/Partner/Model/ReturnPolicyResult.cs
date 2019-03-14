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
 * returnPolicy
 * 渠道管理平台返还政策
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
    ///  returnPolicyResult
    /// </summary>
    public class ReturnPolicyResult
    {

        ///<summary>
        /// ID
        ///</summary>
        public double? Id{ get; set; }
        ///<summary>
        /// 部门ID
        ///</summary>
        public int? DeptId{ get; set; }
        ///<summary>
        /// 部门名称
        ///</summary>
        public string DeptName{ get; set; }
        ///<summary>
        /// 渠道商类型
        ///</summary>
        public int? DistributorType{ get; set; }
        ///<summary>
        /// 渠道商类型名称
        ///</summary>
        public string DistributorTypeName{ get; set; }
        ///<summary>
        /// 返还类型
        ///</summary>
        public int? ReturnType{ get; set; }
        ///<summary>
        /// 项目编码
        ///</summary>
        public double? ItemId{ get; set; }
        ///<summary>
        /// 项目名称
        ///</summary>
        public string ItemName{ get; set; }
        ///<summary>
        /// 周期类型
        ///</summary>
        public int? CircleType{ get; set; }
        ///<summary>
        /// 周期名称
        ///</summary>
        public string CircleName{ get; set; }
        ///<summary>
        /// 指定周期标识
        ///</summary>
        public int? CircleFlag{ get; set; }
        ///<summary>
        /// 周期值
        ///</summary>
        public int? CircleValue{ get; set; }
        ///<summary>
        /// 返还项目条件
        ///</summary>
        public string Condition{ get; set; }
        ///<summary>
        /// 说明
        ///</summary>
        public string ConditionRemark{ get; set; }
        ///<summary>
        /// 返还比例
        ///</summary>
        public double? ReturnRatio{ get; set; }
        ///<summary>
        /// 状态
        ///</summary>
        public int? Status{ get; set; }
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
    }
}
