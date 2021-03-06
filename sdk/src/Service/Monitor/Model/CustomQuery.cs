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


namespace JDCloudSDK.Monitor.Model
{

    /// <summary>
    ///  customQuery
    /// </summary>
    public class CustomQuery
    {

        ///<summary>
        /// 快捷检索条件名称，长度为32个字符，只允许中文、数字、大小写字母、英文下划线“_”及中划线“-”，且不允许重名
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 命名空间
        ///</summary>
        public string Namespace{ get; set; }
        ///<summary>
        /// 命名空间名字
        ///</summary>
        public string NamespaceName{ get; set; }
        ///<summary>
        /// Query
        ///</summary>
        public DescribeQueryOption Query{ get; set; }
        ///<summary>
        /// 快捷检索条件Uuid
        ///</summary>
        public string QueryUuid{ get; set; }
        ///<summary>
        /// 地域
        ///</summary>
        public string Region{ get; set; }
    }
}
