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


namespace JDCloudSDK.Iothub.Model
{

    /// <summary>
    ///  sharedUsers
    /// </summary>
    public class SharedUsers
    {

        ///<summary>
        /// 用户Pin信息
        ///</summary>
        public int? UserPin{ get; set; }
        ///<summary>
        /// 用户对应的资源编号
        ///</summary>
        public int? SourceId{ get; set; }
        ///<summary>
        /// 用户所属region
        ///</summary>
        public int? RegionName{ get; set; }
        ///<summary>
        /// 用户开通时间
        ///</summary>
        public int? CreateTime{ get; set; }
        ///<summary>
        /// 租户状态[1-正常使用，2-欠费停服，3-软删除保护期]
        ///</summary>
        public int? TenantStatus{ get; set; }
        ///<summary>
        /// 在线设备数
        ///</summary>
        public int? OnDevices{ get; set; }
        ///<summary>
        /// 日消息条数
        ///</summary>
        public int? DailyMessages{ get; set; }
        ///<summary>
        /// 总消息条数
        ///</summary>
        public int? TotalMessages{ get; set; }
    }
}