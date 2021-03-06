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
 * Registry
 * 容器镜像服务注册表相关接口
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


namespace  JDCloudSDK.Cr.Apis
{

    /// <summary>
    ///  查询指定注册表名称是否已经存在以及是否符合命名规范。
        ///         /// 
    /// </summary>
    public class CheckRegistryNameResult : JdcloudResult
    {
        ///<summary>
        /// 表示用户指定的注册表是否通过校验， 0 通过 1 名称为空 2 不符合规范 3 重名
        ///</summary>
        public   int? Code{ get; set; }
        ///<summary>
        /// code字段非零时，给出详细原因。
        ///</summary>
        public   string Reason{ get; set; }
    }
}