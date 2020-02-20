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
    ///  parameter
    /// </summary>
    public class Parameter
    {

        ///<summary>
        /// 名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 参数位置
        ///</summary>
        public string ParamLocation{ get; set; }
        ///<summary>
        /// 参数类型
        ///</summary>
        public string ParamType{ get; set; }
        ///<summary>
        /// 默认值
        ///</summary>
        public string DefaultValue{ get; set; }
        ///<summary>
        /// 默认值
        ///</summary>
        public bool IsRequired{ get; set; }
    }
}
