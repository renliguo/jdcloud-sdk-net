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
 * binlog日志
 * binlog日志相关接口
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


namespace  JDCloudSDK.Rds.Apis
{

    /// <summary>
    ///  获取MySQL实例的binlog的下载链接&lt;br&gt;- 仅支持MySQL
    /// </summary>
    public class DescribeBinlogDownloadURLResult : JdcloudResult
    {
        ///<summary>
        /// 公网下载链接
        ///</summary>
        public   string PublicURL{ get; set; }
        ///<summary>
        /// 内网下载链接
        ///</summary>
        public   string InternalURL{ get; set; }
    }
}