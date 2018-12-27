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
 * Authentication
 * 用户认证相关接口
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


namespace  JDCloudSDK.Containerregistry.Apis
{

    /// <summary>
    ///  &lt;p&gt;申请12小时有效期的令牌。 使用&lt;code&gt;docker&lt;/code&gt; CLI push和pull镜像。&lt;/p&gt;
        ///         /// &lt;p&gt;&lt;code&gt;authorizationToken&lt;/code&gt;为每个registry返回一个base64编码的字符串，解码后&lt;code&gt;docker login&lt;/code&gt;命令
        ///         /// 可完成指定registry的鉴权。JCR CLI提供&lt;code&gt;jcr get-login&lt;/code&gt;进行认证处理。&lt;/p&gt;
        ///         /// 
    /// </summary>
    public class GetAuthorizationTokenResponse : JdcloudResponse<GetAuthorizationTokenResult>
    {
    }
}