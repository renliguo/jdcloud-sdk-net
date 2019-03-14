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
 * 策略管理
 * 策略管理接口
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

namespace  JDCloudSDK.Iam.Apis
{

    /// <summary>
    ///  查询策略列表
    /// </summary>
    public class DescribePermissionsRequest : JdcloudRequest
    {
        ///<summary>
        /// 页码
        ///Required:true
        ///</summary>
        [Required]
        public   int PageNumber{ get; set; }
        ///<summary>
        /// 每页显示数目
        ///Required:true
        ///</summary>
        [Required]
        public   int PageSize{ get; set; }
        ///<summary>
        /// 关键字
        ///</summary>
        public   string Keyword{ get; set; }
        ///<summary>
        /// 权限类型,0-全部，1-系统权限，2-自定义权限
        ///Required:true
        ///</summary>
        [Required]
        public   int QueryType{ get; set; }
        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}