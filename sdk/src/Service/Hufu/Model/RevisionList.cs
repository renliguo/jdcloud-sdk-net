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


namespace JDCloudSDK.Hufu.Model
{

    /// <summary>
    ///  修订版本列表
    /// </summary>
    public class RevisionList
    {

        ///<summary>
        /// 版本Id
        ///</summary>
        public string RevisionId{ get; set; }
        ///<summary>
        /// 修订版本号
        ///</summary>
        public string Revision{ get; set; }
        ///<summary>
        /// 基于此版本
        ///</summary>
        public string BaseRevision{ get; set; }
        ///<summary>
        /// 发布环境
        ///</summary>
        public string Environment{ get; set; }
        ///<summary>
        /// 修订日期
        ///</summary>
        public string CreatedAt{ get; set; }
        ///<summary>
        /// 修订备注
        ///</summary>
        public string RevisionNote{ get; set; }
    }
}
