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
 * 大屏数据查询接口
 * 陕西苹果大屏数据查询接口
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

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Industrydata.Apis
{

    /// <summary>
    ///  根据区域、行业、一级指标、二级指标、起始时间等条件查询数据
    /// </summary>
    public class GetLargeScreenDataRequest : JdcloudRequest
    {
        ///<summary>
        /// 查询区域，比如某某省或某某市（可选区域以最终授权为准）
        ///Required:true
        ///</summary>
        [Required]
        public   string Region{ get; set; }
        ///<summary>
        /// 查询行业，比如某个水果或者农作物（可选行业以最终授权为准）
        ///Required:true
        ///</summary>
        [Required]
        public   string Industry{ get; set; }
        ///<summary>
        /// 查询起始时间，格式如下：yyyy-MM-dd
        ///Required:true
        ///</summary>
        [Required]
        public   string StartDate{ get; set; }
        ///<summary>
        /// 查询结束时间，格式如下：yyyy-MM-dd
        ///Required:true
        ///</summary>
        [Required]
        public   string EndDate{ get; set; }
        ///<summary>
        /// 数据对应的第一级分析指标（可选一级指标以最终授权为准）
        ///Required:true
        ///</summary>
        [Required]
        public   string FirstIndex{ get; set; }
        ///<summary>
        /// 数据对应的第二级分析指标，如不填写，则默认把一级指标下的所有二级指标都查询出来（可选二级指标以最终授权为准）
        ///</summary>
        public   string SecondIndex{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}