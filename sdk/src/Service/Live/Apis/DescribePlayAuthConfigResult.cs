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
 * Live-Video
 * 直播管理API
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


namespace  JDCloudSDK.Live.Apis
{

    /// <summary>
    ///  查询播放鉴权配置
    /// </summary>
    public class DescribePlayAuthConfigResult : JdcloudResult
    {
        ///<summary>
        /// 播放鉴权开关，0关，1开
        /// 
        ///</summary>
        public   int? AuthFlag{ get; set; }
        ///<summary>
        /// 鉴权KEY
        ///</summary>
        public   string AuthKey{ get; set; }
        ///<summary>
        /// 过期时间
        ///</summary>
        public   int? ExpireInSec{ get; set; }
        ///<summary>
        /// IP黑名单开关
        ///</summary>
        public   int? IpRestrictFlag{ get; set; }
        ///<summary>
        /// IP黑名单
        ///</summary>
        public   string IpBlacklist{ get; set; }
        ///<summary>
        /// referfer类型
        ///</summary>
        public   string ReferRestrictFlag{ get; set; }
        ///<summary>
        /// 是否允许通过浏览器地址栏直接访问资源URL，true允许，false不允许，默认：true
        ///</summary>
        public   bool AllowNoReferFlag{ get; set; }
        ///<summary>
        /// referer黑名单
        ///</summary>
        public   string RefererBlacklist{ get; set; }
        ///<summary>
        /// referer白名单
        ///</summary>
        public   string RefererWhitelist{ get; set; }
    }
}