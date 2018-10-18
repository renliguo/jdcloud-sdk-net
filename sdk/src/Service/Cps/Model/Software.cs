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


namespace JDCloudSDK.Cps.Model
{

    /// <summary>
    ///  software
    /// </summary>
    public class Software
    {

        ///<summary>
        /// 软件包名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 软件包版本
        ///</summary>
        public string Version{ get; set; }
        ///<summary>
        /// 操作系统系统类型ID
        ///</summary>
        public string OsTypeId{ get; set; }
        ///<summary>
        /// 软件包描述
        ///</summary>
        public string Description{ get; set; }
    }
}
