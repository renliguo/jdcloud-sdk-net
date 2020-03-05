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
 * 分布式云物理服务器
 * 分布式云物理服务器密钥对操作相关的接口
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


namespace  JDCloudSDK.Edcps.Apis
{

    /// <summary>
    ///  导入密钥对
    /// </summary>
    public class ImportKeypairsResult : JdcloudResult
    {
        ///<summary>
        /// 密钥对id
        ///</summary>
        public   string KeypairId{ get; set; }
        ///<summary>
        /// 地域
        ///</summary>
        public   string Region{ get; set; }
        ///<summary>
        /// 密钥对名称
        ///</summary>
        public   string Name{ get; set; }
        ///<summary>
        /// 公钥
        ///</summary>
        public   string PublicKey{ get; set; }
        ///<summary>
        /// 指纹
        ///</summary>
        public   string FingerPrint{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public   string CreateTime{ get; set; }
        ///<summary>
        /// 更新时间
        ///</summary>
        public   string UpdateTime{ get; set; }
    }
}