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


namespace JDCloudSDK.Jdfusion.Model
{

    /// <summary>
    ///  RDS实例账号
    /// </summary>
    public class RdsAccountInfo
    {

        ///<summary>
        /// 账号名
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 账号状态
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// AccountPrivileges
        ///</summary>
        public List<RdsAccountPrivilege> AccountPrivileges{ get; set; }
        ///<summary>
        /// 所属云提供商ID
        ///</summary>
        public string CloudID{ get; set; }
    }
}
