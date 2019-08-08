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
    ///  容器终止的详细信息
    /// </summary>
    public class ContainerStateTerminated
    {

        ///<summary>
        /// 容器被终止的信号。
        ///</summary>
        public int? Signal{ get; set; }
        ///<summary>
        /// 容器被终止的退出码。
        ///</summary>
        public int? ExitCode{ get; set; }
        ///<summary>
        /// （简要）容器被终止的原因。
        ///</summary>
        public string Reason{ get; set; }
        ///<summary>
        /// 容器被终止的详细信息。
        ///</summary>
        public string Message{ get; set; }
        ///<summary>
        /// 容器被终止的时间。
        ///</summary>
        public string FinishedAt{ get; set; }
        ///<summary>
        /// 容器开始执行的时间。
        ///</summary>
        public string StartedAt{ get; set; }
    }
}
