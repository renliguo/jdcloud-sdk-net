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


namespace JDCloudSDK.Vm.Model
{

    /// <summary>
    ///  instanceTemplate
    /// </summary>
    public class InstanceTemplate
    {

        ///<summary>
        /// 启动模板ID
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// 启动模板名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 启动模板描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 启动模板的数据
        ///</summary>
        public InstanceTemplateData InstanceTemplateData{ get; set; }
        ///<summary>
        /// 关联的高可用组(ag)信息
        ///</summary>
        public List<JDCloudSDK.Vm.Model.Ag> Ags{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? CreatedTime{ get; set; }
    }
}
