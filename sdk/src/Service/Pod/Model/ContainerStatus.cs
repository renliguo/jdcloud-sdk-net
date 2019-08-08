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


namespace JDCloudSDK.Pod.Model
{

    /// <summary>
    ///  pod 中的容器状态
    /// </summary>
    public class ContainerStatus
    {

        ///<summary>
        /// 容器名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 容器被重新启动的次数
        ///</summary>
        public int? RestartCount{ get; set; }
        ///<summary>
        /// 容器是否通过了就绪探针探测
        ///</summary>
        public bool Ready{ get; set; }
        ///<summary>
        /// 关于容器当前状态详细信息
        ///</summary>
        public ContainerState State{ get; set; }
        ///<summary>
        /// 关于容器最后一次termination详细信息
        ///</summary>
        public ContainerState LastState{ get; set; }
    }
}
