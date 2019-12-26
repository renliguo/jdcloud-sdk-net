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
 * 直播域名操作类接口
 * Openapi For JCLOUD cdn
 *
 * OpenAPI spec version: v1
 * Contact: pid-cdn@jd.com
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;


namespace  JDCloudSDK.Cdn.Apis
{

    /// <summary>
    ///  设置IP白名单
    /// </summary>
    public class SetPushIpWhiteListResult : JdcloudResult
    {
        ///<summary>
        /// 是否忽略参数
        ///</summary>
        public   string IgnoreQueryString{ get; set; }
        ///<summary>
        /// 推流IP白名单（用逗号分隔）
        ///</summary>
        public   string PushIpWhiteList{ get; set; }
        ///<summary>
        /// 推流超时时间
        ///</summary>
        public   int? PublishNormalTimeout{ get; set; }
        ///<summary>
        /// 推断流时，通知客户系统的URL
        ///</summary>
        public   string NotifyCustomUrl{ get; set; }
        ///<summary>
        /// 通知客户系统的鉴权key
        ///</summary>
        public   string NotifyCustomAuthKey{ get; set; }
        ///<summary>
        /// 转推鉴权类型（0：不鉴权，1：参数鉴权，2：URL鉴权）
        ///</summary>
        public   int? ForwardAccessKeyType{ get; set; }
        ///<summary>
        /// 转推的鉴权key
        ///</summary>
        public   string ForwardPrivateKey{ get; set; }
        ///<summary>
        /// 回源鉴权类型（0：不鉴权，1：参数鉴权，2：URL鉴权）
        ///</summary>
        public   int? OriginAccessKeyType{ get; set; }
        ///<summary>
        /// 回源的鉴权key
        ///</summary>
        public   string OriginPrivateKey{ get; set; }
    }
}