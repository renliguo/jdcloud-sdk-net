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
 * Domain Management
 * 域名管理
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Vod.Model
{

    /// <summary>
    ///  查询域名响应信息
    /// </summary>
    public class GetDomainResp
    {

        ///<summary>
        /// 域名ID
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// 域名名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 域名CNAME
        ///</summary>
        public string Cname{ get; set; }
        ///<summary>
        /// 域名来源：系统生成 | 用户自建
        ///</summary>
        public string Source{ get; set; }
        ///<summary>
        /// 是否默认域名
        ///</summary>
        public bool AsDefault{ get; set; }
        ///<summary>
        /// CreateTime
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// UpdateTime
        ///</summary>
        public DateTime? UpdateTime{ get; set; }
    }
}