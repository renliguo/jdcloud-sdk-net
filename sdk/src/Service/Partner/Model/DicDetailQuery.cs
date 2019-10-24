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


namespace JDCloudSDK.Partner.Model
{

    /// <summary>
    ///  dicDetailQuery
    /// </summary>
    public class DicDetailQuery
    {

        ///<summary>
        /// ID
        ///</summary>
        public double? Id{ get; set; }
        ///<summary>
        /// 字典类型
        ///</summary>
        public string CodeType{ get; set; }
        ///<summary>
        /// 字典编码
        ///</summary>
        public string Code{ get; set; }
        ///<summary>
        /// 字典编码名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 字典编码值
        ///</summary>
        public string Value{ get; set; }
        ///<summary>
        /// null
        ///</summary>
        public bool UseFlag{ get; set; }
        ///<summary>
        /// 系统类型
        ///</summary>
        public string SystemType{ get; set; }
        ///<summary>
        /// 引用值
        ///</summary>
        public string RefValue{ get; set; }
        ///<summary>
        /// 顺序
        ///</summary>
        public int? Seq{ get; set; }
        ///<summary>
        /// 字典说明
        ///</summary>
        public string Remark{ get; set; }
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
        /// 当前页序号
        ///</summary>
        public int? PageIndex{ get; set; }
        ///<summary>
        /// 每页结果数量
        ///</summary>
        public int? PageSize{ get; set; }
        ///<summary>
        /// Offset
        ///</summary>
        public int? Offset{ get; set; }
    }
}