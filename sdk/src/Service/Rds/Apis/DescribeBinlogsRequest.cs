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

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Rds.Apis
{

    /// <summary>
    ///  获取MySQL实例中binlog的详细信息&lt;br&gt;- 仅支持MySQL
    /// </summary>
    public class DescribeBinlogsRequest : JdcloudRequest
    {
        ///<summary>
        /// 显示数据的页码，默认为1，取值范围：[-1,∞)。pageNumber为-1时，返回所有数据页码；超过总页数时，显示最后一页。
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 每页显示的数据条数，默认为10，取值范围：10、20、30、50、100
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 查询开始时间，格式为：YYYY-MM-DD HH:mm:ss，开始时间到结束时间不超过三天
        ///</summary>
        public   string StartTime{ get; set; }
        ///<summary>
        /// 查询结束时间，格式为：YYYY-MM-DD HH:mm:ss，开始时间到结束时间不超过三天
        ///</summary>
        public   string EndTime{ get; set; }
        ///<summary>
        /// 地域代码，取值范围参见[《各地域及可用区对照表》](../Enum-Definitions/Regions-AZ.md)
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// RDS 实例ID，唯一标识一个RDS实例
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
    }
}