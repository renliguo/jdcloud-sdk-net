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
    ///  listRoleInfo
    /// </summary>
    public class ListRoleInfo
    {

        ///<summary>
        /// 角色名称
        ///</summary>
        public string RoleName{ get; set; }
        ///<summary>
        /// 角色类型，2-服务相关角色，3-服务角色，4-用户角色
        ///</summary>
        public int? Type{ get; set; }
        ///<summary>
        /// 角色信任关系策略
        ///</summary>
        public string AssumeRolePolicyDocument{ get; set; }
        ///<summary>
        /// 描述，0~1000个字符
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 创建角色的时间
        ///</summary>
        public string CreateTime{ get; set; }
    }
}
