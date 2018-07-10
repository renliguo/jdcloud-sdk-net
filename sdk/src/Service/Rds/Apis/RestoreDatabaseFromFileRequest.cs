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
 * 数据库管理
 * 数据库管理相关接口
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

namespace  JDCloudSDK.Rds.Apis
{

    /// <summary>
    /// 从用户上传的备份文件中恢复SQL Server数据库&lt;/br&gt;- SQL Server：支持&lt;/br&gt;- MySQL：暂不支持
    /// </summary>
    public class RestoreDatabaseFromFileRequest : JdcloudRequest
    {
        ///<summary>
        ///共享文件的全局ID，可从上传文件查询接口describeImportFiles获取；如果该文件不是共享文件，则全局ID为空
        ///</summary>
        public   string SharedFileGid{ get; set; }
        ///<summary>
        ///用户在单库上云中上传的文件名称
        ///Required:true
        ///</summary>
        [Required]
        public   string FileName{ get; set; }
        ///<summary>
        ///区域代码
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        ///实例ID
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
        ///<summary>
        ///库名称
        ///Required:true
        ///</summary>
        [Required]
        public   string DbName{ get; set; }
    }
}