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


namespace JDCloudSDK.Cdn.Model
{

    /// <summary>
    ///  null
    /// </summary>
    public class Action
    {

        ///<summary>
        /// 1：forbidden，493封禁并返回自定义页面 2：redirect，302跳转 3： verify@captcha 4： verify@jscookie
        ///</summary>
        public int? AtOp{ get; set; }
        ///<summary>
        /// action为1时为自定义页面名称,缺省为默认页面，2时为跳转url，其他时无效
        ///</summary>
        public string AtVal{ get; set; }
    }
}
