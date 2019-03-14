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


namespace JDCloudSDK.Iam.Model
{

    /// <summary>
    ///  groupInfo
    /// </summary>
    public class GroupInfo
    {

        ///<summary>
        /// 用户组ID
        ///</summary>
        public string GroupId{ get; set; }
        ///<summary>
        /// 用户组名
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// jrn描述
        ///</summary>
        public string Jrn{ get; set; }
        ///<summary>
        /// Description
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 用户组创建时间
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 用户组更新时间
        ///</summary>
        public DateTime? UpdateTime{ get; set; }
        ///<summary>
        /// Policies
        ///</summary>
        public List<string> Policies{ get; set; }
    }
}
